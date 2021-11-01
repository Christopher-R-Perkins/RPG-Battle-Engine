using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Battle_Engine
{
    public class ChangeIntoEffectBattleEffect : IBattleEffect
    {
        public Guid Guid { get; init; }
        public Guid Target { get; init; }
        public Guid Source { get; init; }
        public IBattleEffect Effect { get; init; }

        public ChangeIntoEffectBattleEffect(Guid source, IBattleEffect newEffect, Guid? guid = null)
        {
            Source = source;
            Guid = guid ?? Guid.NewGuid();
            Effect = newEffect;
            Target = newEffect.Guid;
        }

        public BattleState TakeEffect(BattleState currentState)
        {
            var stack = currentState.Stack;
            stack = stack.Replace(Effect);
            return new(currentState, stack: stack);
        }

        public override string ToString()
        {
            return "Change Effect Into Effect Battle Effect";
        }
    }
}
