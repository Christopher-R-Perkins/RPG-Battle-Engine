using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Battle_Engine
{
    public interface IBattleAbility
    {
        public Guid Guid { get; init; }

        public IEnumerable<IBattleEffect> GenerateEffects(Guid[] effected);
    }
}
