﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Battle_Engine
{
    /// <summary>
    /// EndTurnEffect is added to the stack at the bottom everytime an Ability is queued. When it takes effect, it checks for Death and Win Conditions, increments the 
    /// turn counter, cleans up the BattleState, and Pushes either NewTurnEffect or EndBattleEffect to the Effect Stack based on the outcome of its checks. 
    /// </summary>
    public class EndTurnEffect : IBattleEffect
    {
        public Guid Guid { get; init ; }
        /// <summary>
        /// Target is an Empty GUID, because this is autogenerated and has no Target.
        /// </summary>
        public Guid Target { get; init; }
        /// <summary>
        /// Source is an Empty GUID, because this is autogenerated and has no Target.
        /// </summary>
        public Guid Source { get; init; }

        public EndTurnEffect(Guid? guid = null)
        {
            Guid = guid ?? Guid.NewGuid();
            Target = Guid.Empty;
            Source = Guid.Empty;
        }

        /// <summary>
        /// SetUnconciousIfDead checks an entity to see if it recently became unconscious, and if it did, adds the Unconscious Passive Ability to the entity, changing the
        /// referenced entity in accordance to the check, then returning if it is dead or not.
        /// </summary>
        /// <param name="entity">Reference</param>
        /// <returns>Entity that was checked and changed accordingly</returns>
        private static bool SetUnconciousIfDead(ref BattleEntity entity)
        {
            var health = entity.GetHP();
            
            if (entity.Damage < health) return false;
            if (entity.Abilities.Exists(ability => ability is UnconciousBattleAbility)) return true;

            var abilities = entity.Abilities;
            abilities = abilities.Add(new UnconciousBattleAbility());

            entity = new(entity, abilities: abilities);
            return true;
        }

        public BattleState TakeEffect(BattleState currentState)
        {
            var entities = currentState.GetEntities();
            
            var teamOneOwner = currentState.Fields[0].Owner;
            var teamTwoOwner = currentState.Fields[1].Owner;

            int teamOneCount = 0;
            int teamTwoCount = 0;

            for (int i = 0; i < entities.Length; i++)
            {
                bool isDead = SetUnconciousIfDead(ref entities[i]);
                currentState = currentState.ReplaceEntity(entities[i]);
                if (!isDead) 
                    _ = entities[i].Owner == teamOneOwner ? teamOneCount++ : teamTwoCount++;
            }

            EffectStack stack;
            
            if (teamOneCount > 0 && teamTwoCount > 0)
            {
                stack = currentState.Stack.Push(currentState, new NewTurnEffect());
                return new BattleState(currentState, stack: stack, turnCount: currentState.TurnCount + 1);
            }

            if (teamOneCount > 0)
            {
                stack = currentState.Stack.Push(currentState, new EndBattleEffect(teamOneOwner));
                return new BattleState(currentState, stack: stack, turnCount: currentState.TurnCount + 1);
            }
            
            stack = currentState.Stack.Push(currentState, new EndBattleEffect(teamTwoOwner));
            return new BattleState(currentState, stack: stack, turnCount: currentState.TurnCount + 1);
        }

        public override string ToString()
        {
            return "End Turn Battle Effect";
        }
    }
}