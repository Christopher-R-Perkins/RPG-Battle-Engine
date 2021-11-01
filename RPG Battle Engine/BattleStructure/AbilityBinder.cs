using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Battle_Engine
{
    /// <summary>
    /// Holds all our abilities
    /// </summary>
    public static class AbilityBinder
    {
        public static void InstantiateBinder()
        {
            _dictionary = new();
            _localization = new();

            IBattleAbility ability = new UnconciousBattleAbility();
            _dictionary.Add(ability.Guid, ability);
            _localization.Add(ability.Guid, "Unconscious");

            ability = new PoisonedPassiveAbility();
            _dictionary.Add(ability.Guid, ability);
            _localization.Add(ability.Guid, "Poisioned");

            Guid guid = new Guid("525047460000BA794141000000000002");
            List<(Type, int[])> list = new();
            list.Add((typeof(DelayEffect),new int[]{ 100,1}));
            ability = new ActiveBattleAbility(guid, list, TargetType.Self);
            _dictionary.Add(guid, ability);
            _localization.Add(guid, "Pass");
        }

        public static IBattleAbility GetAbility(Guid guid)
        {
            if (!_dictionary.ContainsKey(guid)) return null;
            return _dictionary[guid];
        }

        public static IBattleAbility GetAbility(string guid)
        {
            var guidValue = new Guid(guid);
            return GetAbility(guidValue);
        }

        public static string GetName(Guid guid)
        {
            if (!_localization.ContainsKey(guid)) return "";
            return _localization[guid];
        }

        public static string GetName(string guid)
        {
            var guidValue = new Guid(guid);
            return GetName(guidValue);
        }

        private static Dictionary<Guid, IBattleAbility> _dictionary;
        private static Dictionary<Guid, string> _localization;
    }
}
