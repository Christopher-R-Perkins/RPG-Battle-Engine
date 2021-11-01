using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Battle_Engine
{
    public class UnconciousBattleAbility : PassiveBattleAbility
    {
        public UnconciousBattleAbility()
        {
            Guid = new Guid("525047460000972F5041000000000000");
        }
        public override IEnumerable<IBattleEffect> GenerateEffects(Guid[] effected)
        {
            List<IBattleEffect> list = new();
            var endTurnEffect = new EndTurnEffect(effected[1]);
            var changeNewTurnEffect = new ChangeIntoEffectBattleEffect(effected[0], endTurnEffect);
            list.Add(changeNewTurnEffect);
            list.Add(new DelayEffect(effected[0], effected[0], 200));
            return list;
        }

        public override IEnumerable<IBattleEffect> Trigger(Guid Owner, BattleState state, IBattleEffect effect)
        {
            List<IBattleEffect> list = new();
            
            if (effect is not NewTurnEffect) return list;
            if (state.GetTurnEntity().Guid != Owner) return list;
            Guid[] effected =  { Owner, effect.Guid };

            return GenerateEffects(effected);
        }
    }
}
