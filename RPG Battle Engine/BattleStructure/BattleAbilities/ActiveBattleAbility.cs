using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Battle_Engine
{
    public enum TargetType { Self=1, Ally=2, Enemy=4, Left=8, Right=16, Field=32, All=64}
    public partial class ActiveBattleAbility : IBattleAbility
    {
        public Guid Guid { get; init; }
        public ReadOnlyCollection<(Type, int[])> Effects { get; init; }
        public TargetType Targeting { get; init; }

        public ActiveBattleAbility(Guid guid, List<(Type, int[])> effects, TargetType targeting)
        {
            Guid = guid;
            Targeting = targeting;
            foreach((Type type, _) in effects) { 
                if (!typeof(IBattleEffect).IsAssignableFrom(type)) throw new ArgumentException("ActiveBattleAbility was passed a type that was not an effect.");
            }
            Effects = new ReadOnlyCollection<(Type, int[])>(effects);
        }

        public IEnumerable<IBattleEffect> GenerateEffects(Guid[] effected)
        {
            var guidBase = Guid.ToByteArray();
            // change value of type to EF for effect
            guidBase[8] = 0x45;
            guidBase[9] = 0x46;

            List<IBattleEffect> effects = new List<IBattleEffect>();
            for(int i = 0; i < Effects.Count; i++)
            {
                effects.AddRange(CreateIndividualEffects(effected, i, guidBase));
            }
            return effects;
        }

        private Guid GenerateGuid(byte[] guidBase, int id)
        {
            byte[] newID = BitConverter.GetBytes(id);
            if (BitConverter.IsLittleEndian) Array.Reverse(newID);
            for(int i = 0; i < 3; i++)
            {
                guidBase[10 + i] = newID[1 + i];
            }
            return new Guid(guidBase);
        }

        // on active abilities effected[0] = self and effected[1] = this, the rest are units that are effected by this
        private List<IBattleEffect> CreateIndividualEffects(Guid[] effected, int iterator, byte[] guidBase)
        {
            List<IBattleEffect> list = new List<IBattleEffect>();
            (Type type, int[] operators) = Effects[iterator];

            switch (type)
            {
                case Type delayType when delayType == typeof(DelayEffect):
                    list.AddRange(GenerateDelayEffect(effected, (ulong)operators[0], operators[1] == 1, guidBase, iterator));
                    break;
            }
            return list;
        }
    }
}
