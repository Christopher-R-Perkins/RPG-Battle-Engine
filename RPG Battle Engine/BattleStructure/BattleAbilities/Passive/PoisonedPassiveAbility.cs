using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Battle_Engine
{
    public class PoisonedPassiveAbility : PassiveBattleAbility
    {
        public PoisonedPassiveAbility()
        {
            Guid = new Guid("52504746000085C05041000000000001");
        }

        public override IEnumerable<IBattleEffect> GenerateEffects(Guid[] effected)
        {
            List<IBattleEffect> effects = new();
            effects.Add(new PoisonDamageEffect(effected[0], Guid));
            return effects;
        }

        public override IEnumerable<IBattleEffect> Trigger(Guid Owner, BattleState state, IBattleEffect effect)
        {
            if (effect is not NewTurnEffect) return new List<IBattleEffect>();
            if (state.GetTurnEntity().Guid != Owner) return new List<IBattleEffect>();
            
            Guid[] effected = { Owner };
            return GenerateEffects(effected);
        }
    }
}
