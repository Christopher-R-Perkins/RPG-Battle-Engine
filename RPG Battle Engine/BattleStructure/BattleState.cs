using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace RPG_Battle_Engine
{
    public readonly struct BattleState
    {
        public readonly int TurnCount;
        public readonly ImmutableList<BattleField> Fields;
        public readonly EffectStack Stack;

        public BattleState(BattleField playerOneField, BattleField playerTwoField, EffectStack stack, int turnCount = 0)
        {
            List<BattleField> list = new();
            list.Add(playerOneField);
            list.Add(playerTwoField);
            Fields = list.ToImmutableList();
            TurnCount = turnCount;
            Stack = stack;
        }

        public BattleState(BattleState old, BattleField? playerOneField = null, BattleField? playerTwoField = null, EffectStack? stack = null, int? turnCount = null)
        {
            List<BattleField> list = new();
            list.Add(playerOneField ?? old.Fields[0]);
            list.Add(playerTwoField ?? old.Fields[1]);
            Fields = list.ToImmutableList();
            TurnCount = turnCount ?? old.TurnCount;
            Stack = stack ?? old.Stack;
        }

        public BattleState ReplaceEntity(BattleEntity entity)
        {
            int fieldIndex = Fields[0].Owner == entity.Owner ? 0 : 1;
            BattleField newField = Fields[fieldIndex].ReplaceEntity(entity);
            
            if (fieldIndex == 1) return new BattleState(this, playerTwoField: newField);
            
            return new BattleState(this, playerOneField: newField);
        }

        public int GetEntityCount()
        {
            int count = 0;
            
            foreach (BattleField field in Fields) count += field.GetEntityCount();

            return count;
        }

        public BattleEntity GetEntity(Guid guid)
        {
            var entities = GetEntities();
            foreach(BattleEntity entity in entities)
            {
                if (entity.Guid == guid) return entity;
            }
            throw new IndexOutOfRangeException("GUID of entity does not match one in battle");
        }

        public BattleEntity[] GetEntities()
        {
            List<BattleEntity> list = new List<BattleEntity>();
            
            foreach (BattleField field in Fields) list.AddRange(field.GetEntities());
            
            return list.ToArray();
        }

        public BattleEntity GetTurnEntity()
        {
            BattleEntity[] entities = GetEntities();

            ulong lowestTiming = ulong.MaxValue;
            int lowestIndex = 0;

            for(int i = 0; i < entities.Length; i++)
            {
                if (entities[i].Timing >= lowestTiming) continue;
                lowestIndex = i;
                lowestTiming = entities[i].Timing;
            }

            return entities[lowestIndex];
        }

        public override string ToString()
        {
            string value = "";
            value += Fields[0].ToString();
            value += Fields[1].ToString();
            value += TurnCount.ToString();
            return value;
        }

        public byte[] ToHash()
        {
            MD5 hasher = MD5.Create();
            string value = ToString();
            var bytes = Encoding.ASCII.GetBytes(value);
            hasher.ComputeHash(bytes);
            return hasher.Hash;
        }
    }
}
