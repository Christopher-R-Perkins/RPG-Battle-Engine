using System;
using System.Collections.Generic;

namespace RPG_Battle_Engine
{
    /// <summary>
    /// DelayEffect is an effect used to increase the delay between turns. It is mainly used by Active Battle Abilities.
    /// </summary>
    public class DelayEffect : IBattleEffect
    {
        public Guid Guid { get; init; }

        /// <summary>
        /// Target is the Target Entity we want to take some time before their next turn.
        /// </summary>
        public Guid Target { get; init; }

        /// <summary>
        /// Source is the source entity that made them take some time before their next turn. This will usually be the Target Entity, 
        /// as most of the time this effect is added alongside an Active Ability.
        /// </summary>
        public Guid Source { get; init; }

        /// <summary>
        /// Multiplier is the percentage in whole number form that will be multiplied by the entities Initiative in order to find out how long
        /// the delay is.
        /// </summary>
        public ulong Multiplier { get; init; }

        public DelayEffect(Guid target, Guid source, ulong multiplier, Guid? guid = null)
        {
            Target = target;
            Source = source;
            Multiplier = multiplier;
            Guid = guid ?? Guid.NewGuid();
        }

        public BattleState TakeEffect(BattleState state) 
        {
            BattleEntity entity = state.GetEntity(Target);
            
            entity = new(entity, entity.Timing + Multiplier * entity.GetInitiative() / 100);

            return state.ReplaceEntity(entity);
        }

        public override string ToString()
        {
            return "Delay Battle Effect | ( " + Multiplier.ToString() + " / 100 )";
        }
    }
}

namespace RPG_Battle_Engine
{
    public partial class ActiveBattleAbility
    {
        public List<IBattleEffect> GenerateDelayEffect(Guid[] effected, ulong multiplier, bool self, byte[] guidBase, int id)
        {
            List<IBattleEffect> list = new List<IBattleEffect>();
            if (self)
            {
                var guid = GenerateGuid(guidBase, id);
                list.Add(new DelayEffect(effected[0], effected[0], multiplier, guid));
                return list;
            }

            for (int i = 0; i < effected.Length - 2; i++)
            {
                var guid = GenerateGuid(guidBase, id + 256 * i);
                list.Add(new DelayEffect(effected[2 + i], effected[0], multiplier, guid));
            }
            return list;
        }
    }
}
