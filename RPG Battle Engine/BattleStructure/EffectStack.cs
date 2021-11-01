using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace RPG_Battle_Engine
{
    public readonly struct EffectStack
    {
        public bool IsEmpty { get { return Effects.IsEmpty; } }
        public ImmutableStack<IBattleEffect> Effects { get; init; }
        
        public static EffectStack Create()
        {
            return new EffectStack { Effects = ImmutableStack.Create<IBattleEffect>() };
        }

        public EffectStack(EffectStack old, ImmutableStack<IBattleEffect> effects = null)
        {
            Effects = effects ?? old.Effects;
        }

        /// <summary>
        /// Pushes IBattleEffect on the stack and then checks for and recursively pushes triggers onto the stack the same way
        /// </summary>
        /// <param name="state">BattleState is used to check entities passives for triggers</param>
        /// <param name="effect">The effect to push</param>
        /// <returns>The new Immutable EffectStack</returns>
        public EffectStack Push(BattleState state, IBattleEffect effect)
        {
            ImmutableStack<IBattleEffect> stack = this.Effects.Push(effect);
            EffectStack newStack = new(this, stack);

            List<IBattleEffect> list = new();
            var entities = state.GetEntities();
            foreach(BattleEntity entity in entities)
            {
                list.AddRange(entity.TriggerPassives(state, effect));
            }
            list.Reverse();

            Stack<IBattleEffect> checkStack = new(list);

            while(checkStack.Count > 0) newStack = newStack.Push(state, checkStack.Pop());
            return newStack;
        }

        /// <summary>
        /// Pops the top IBattleEffect off the stack and returns a new Immutable Stack
        /// </summary>
        /// <param name="effect">The effect being popped( use out)</param>
        /// <returns>The new immutable stack</returns>
        public EffectStack Pop(out IBattleEffect effect)
        {
            var stack = this.Effects.Pop(out effect);
            return new EffectStack(this, stack);
        }

        /// <summary>
        /// Finds the effect with Guid guid and returns it. Returns null if it doesn't exist.
        /// </summary>
        /// <param name="guid">The Guid of the effect you want to find</param>
        /// <returns>The Effect or null</returns>
        public IBattleEffect Find(Guid guid)
        {
            foreach (IBattleEffect effect in Effects)
            {
                if (effect.Guid == guid) return effect;
            }
            return null;
        }

        /// <summary>
        /// Find the effect of Type type and returns it. Returns null if it doesn't exist.
        /// </summary>
        /// <param name="type">The Type of the battle effect to find</param>
        /// <returns>The Effect or null</returns>
        public IBattleEffect Find(Type type)
        {
            foreach(var effect in Effects)
            {
                if (effect.GetType() == type) return effect;
            }
            return null;
        }

        /// <summary>
        /// Replaces the Effect in the stack with the same guid as the effect you replace it with
        /// </summary>
        /// <param name="effect">The new effect you want to place</param>
        /// <returns>A new Immutable Stack</returns>
        public EffectStack Replace(IBattleEffect effect)
        {
            var list = Effects.ToList();
            for(int i = 0; i < list.Count; i++)
            {
                if (list[i].Guid == effect.Guid) list[i] = effect;
            }
            var stack = ImmutableStack.CreateRange<IBattleEffect>(list);
            return new EffectStack(this, stack);
        }

        public override string ToString()
        {
            string output = "[Effect Stack Start]\n";
            foreach(IBattleEffect effect in Effects)
            {
                output += effect.ToString() + "\n";
            }
            return output + "[Effect Stack End]";
        }
    }
}
