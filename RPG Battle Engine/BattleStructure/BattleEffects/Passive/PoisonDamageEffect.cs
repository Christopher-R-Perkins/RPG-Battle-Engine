using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Battle_Engine
{
    public class PoisonDamageEffect : IBattleEffect
    {
        public Guid Guid { get; init; }
        public Guid Target { get; init; }
        public Guid Source { get; init; }

        public PoisonDamageEffect(Guid target, Guid source, Guid? guid = null)
        {
            Guid = guid ?? Guid.NewGuid();
            Target = target;
            Source = source;
        }

        public BattleState TakeEffect(BattleState currentState)
        {
            var entity = currentState.GetEntity(Target);
            var health = entity.GetHP();
            var damage = entity.Damage + health / 20;

            var list = entity.Abilities;
            if (damage >= health)
            {
                list = list.RemoveAll(ability => ability.Guid == Source);
                
                var stack = currentState.Stack;
                var effect = stack.Find(typeof(NewTurnEffect));
                effect = new EndTurnEffect(effect.Guid);
                stack = stack.Push(currentState, new ChangeIntoEffectBattleEffect(Target, effect));
                stack = stack.Push(currentState, new DelayEffect(Target, Target, 100));
                currentState = new(currentState, stack: stack);
            }

            return currentState.ReplaceEntity(new(entity, abilities: list, dam:damage));
        }

        public override string ToString()
        {
            return "Poison Damage Battle Effect";
        }
    }
}
