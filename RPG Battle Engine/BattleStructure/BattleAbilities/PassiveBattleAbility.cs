using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Battle_Engine
{
    public abstract class PassiveBattleAbility : IBattleAbility
    {
        public Guid Guid { get; init; }

        public abstract IEnumerable<IBattleEffect> GenerateEffects(Guid[] effected);

        public abstract IEnumerable<IBattleEffect> Trigger(Guid Owner, BattleState state, IBattleEffect effect);
    }
}
