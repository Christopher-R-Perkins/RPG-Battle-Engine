using System;
using System.Collections.Immutable;
using System.Collections.Generic;

namespace RPG_Battle_Engine
{
    public readonly struct BattleEntity
    {
        private const double StatExponent = .5842597;
        private const double MagExponent = 0.4151646;
        private const double BaseHP = 38.9794239;
        private const double BaseStat = 10.02772478;
        private const double BaseMag = 1.00048;

        public Guid Owner { get; }
        public Guid Guid { get; }
        public byte Power { get; }
        public byte Armor { get; }
        public byte Speed { get; }
        public byte Guile { get; }
        public byte Magic { get; }
        public byte Vitality { get; }
        public int Damage { get; }
        public ulong Timing { get; }
        public ImmutableList<IBattleAbility> Abilities { get; }
        public ImmutableDictionary<Guid, int> AbilityData { get; }

        public BattleEntity(Guid owner, Guid guid, byte pow, byte arm, byte spd, byte gul, byte mag, byte vit, 
            ImmutableList<IBattleAbility> abilities, ImmutableDictionary<Guid, int> abilityData, int dam = 0)
        {
            Owner = owner;
            Guid = guid;
            Power = pow;
            Armor = arm;
            Speed = spd;
            Guile = gul;
            Magic = mag;
            Vitality = vit;
            Damage = dam;
            Timing = GetInitiative(spd);
            Abilities = abilities;
            AbilityData = abilityData;
       }

        public BattleEntity(BattleEntity oldEntity, ulong? timing = null, ImmutableList<IBattleAbility> abilities = null, 
            ImmutableDictionary<Guid, int> abilityData = null, int? dam = null)
        {
            Owner = oldEntity.Owner;
            Guid = oldEntity.Guid;
            Power = oldEntity.Power;
            Armor = oldEntity.Armor;
            Speed = oldEntity.Speed;
            Guile = oldEntity.Guile;
            Magic = oldEntity.Magic;
            Vitality = oldEntity.Vitality;
            Damage = Math.Clamp(dam ?? oldEntity.Damage,0,GetHPValue(Vitality));
            Timing = timing ?? oldEntity.Timing;
            Abilities = abilities ?? oldEntity.Abilities;
            AbilityData = abilityData ?? oldEntity.AbilityData;
        }

        public IEnumerable<IBattleEffect> TriggerPassives(BattleState state, IBattleEffect triggeringEffect)
        {
            List<IBattleEffect> list = new();
            foreach(IBattleAbility ability in Abilities)
            {
                if (ability is not PassiveBattleAbility) continue;
                list.AddRange((ability as PassiveBattleAbility).Trigger(Guid, state, triggeringEffect));
            }
            return list;
        }

        /// <summary>
        /// GetInitiative converts speed to intiative.
        /// </summary>
        /// <returns>Initiative - base value to add to timing for turn system</returns>
        public ulong GetInitiative() => GetInitiative(Speed);

        /// <summary>
        /// GetHP converts the vitality stat to HP.
        /// </summary>
        /// <returns>HP - How much damage you can take before fainting.</returns>
        public int GetHP() => GetHPValue(Vitality);
        
        /// <summary>
        /// GetAccuracy translates your Guile and the person you are hitting's guile to determine accuracy damage.
        /// </summary>
        /// <param name="defender">Defender's guile</param>
        /// <returns>Accuracy - percentage * 100, used to add/remove damage ignoring armor</returns>
        public int GetAccuracy(byte defender) => GetGuilePercentage(Guile, defender);
        
        /// <summary>
        /// GetPhysicalMultiplier determines the amount to multiply physical damage by based on your power and the oppenents Armor.
        /// </summary>
        /// <param name="defender">Defender's armor</param>
        /// <returns>Physical Multiplier - percentage * 100, multiplied to base potency on physical attacks</returns>
        public int GetPhysicalMultiplier(byte defender) => GetPhysPercentage(Power, defender);

        /// <summary>
        /// GetMagicalMultiplier determines the amount to multiply magical damage by based on your magic
        /// </summary>
        /// <returns>Magical Multiplier - percentage * 100, multiplied to base potency on magic attacks</returns>
        public int GetMagicalMultiplier() => (int)(100 * GetMagPercentage(Magic));

        public override string ToString()
        {
            return Owner.ToString() + " - |" + Guid.ToString() + "| - " + Power + ", " + Armor + ", " + Speed + ", " + 
                Guile + ", " + Magic + ", " + Vitality + " | " + Damage + " | " + Timing;
            // TODO Add Abilities and Ability Damage to the Mix.
        }

        private static ulong GetInitiative(byte speed) => (ulong)(256*Math.Pow(speed+1, -StatExponent));
        private static int GetModifiedStat(byte stat) => (int)(BaseStat * Math.Pow(stat + 1, StatExponent));
        private static int GetHPValue(byte vit) => (int)(BaseHP * Math.Pow(vit + 1, StatExponent));
        private static double GetMagPercentage(byte magic) => BaseMag * Math.Pow(magic, MagExponent);
        private static int GetGuilePercentage(byte attacker, byte defender)
        {
            var aValue = GetModifiedStat(attacker);
            var dValue = GetModifiedStat(defender);

            if (aValue == dValue) return 0;
            if (aValue > dValue) return (10 * aValue) / dValue;
            return (10 * dValue) / aValue;
        }
        private static int GetPhysPercentage(byte power, byte armor)
        {
            var attacker = GetModifiedStat(power);
            var defender = GetModifiedStat(armor);
            return (attacker * 100) / defender;
        }
    }
}
