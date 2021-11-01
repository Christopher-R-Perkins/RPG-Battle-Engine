using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Battle_Engine
{
    public class NewTurnEffect : IBattleEffect
    {
        public Guid Guid { get; init; }
        public Guid Target { get; init; }
        public Guid Source { get; init; }

        public NewTurnEffect(Guid? guid = null)
        {
            Guid = guid ?? Guid.NewGuid();
            Target = Guid.Empty;
            Source = Guid.Empty;
        }

        public BattleState TakeEffect(BattleState currentState)
        {
            return currentState;
        }

        public override string ToString()
        {
            return "New Turn Battle Effect";
        }
    }
}
