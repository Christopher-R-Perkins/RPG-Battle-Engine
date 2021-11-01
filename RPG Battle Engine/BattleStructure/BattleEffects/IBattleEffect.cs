using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Battle_Engine
{
    /// <summary>
    /// IBattleEffect is an interface defining how to interact with Battle Effects
    /// </summary>
    public interface IBattleEffect
    {
        /// <summary>
        /// Guid is the readonly GUID for the effect.
        /// </summary>
        public Guid Guid { get; init; }

        /// <summary>
        /// Target is the readonly GUID for the target of the effect. This can be the Guid to an entity, ability, or battlefield, only the inherited Effect and Ability
        /// that created it will know.
        /// </summary>
        public Guid Target { get; init; }

        /// <summary>
        /// Source is the readonly GUID for the source of an effect. It will usually be the GUID to an entity, but may also be an ability on the Target entity itself.
        /// Again only the ability and the inherited effect will know what's up.
        /// </summary>
        public Guid Source { get; init; }

        /// <summary>
        /// TakeEffect is used when you want to run the Effects. It takes the current BattleState and returns a new one after the Effect goes into effect.
        /// </summary>
        /// <param name="currentState">The current state of the battle prior to the effect running</param>
        /// <returns></returns>
        public BattleState TakeEffect(BattleState currentState);
    }
}
