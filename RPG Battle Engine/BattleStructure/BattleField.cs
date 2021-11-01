using System;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace RPG_Battle_Engine
{
    public enum Position { Error = -1, Left = 0, Middle = 1, Right = 2 };

    public readonly struct BattleField
    {
        public readonly Guid Owner;
        public readonly ImmutableList<BattleEntity?> Entities;

        public BattleField(Guid owner, BattleEntity? leftEntity = null, BattleEntity? middleEntity = null, BattleEntity? rightEntity = null)
        {
            List<BattleEntity?> list = new()
            {
                leftEntity,
                middleEntity,
                rightEntity
            };
            Entities = list.ToImmutableList();
            Owner = owner;
        }

        public BattleField(Guid owner, List<BattleEntity?> list)
        {
            if (list.Count != 3) throw new IndexOutOfRangeException("BattleField requires exactly 3 BattleEntity?'s to be constructed. " + list.Count + " was passed to the contructor!");
            Owner = owner;
            Entities = list.ToImmutableList();
        }

        public BattleField ReplaceEntity(BattleEntity entity)
        {
            if (entity.Owner != Owner) return this;
            List<BattleEntity?> list = new(Entities);
            for(int i = 0; i < list.Count; i++)
            {
                if (!list[i].HasValue) continue;
                if (list[i].Value.Guid == entity.Guid) list[i] = entity;
            }
            return new(Owner, list);
        }

        public BattleEntity[] GetEntities()
        {
            List<BattleEntity> list = new();
            foreach(BattleEntity? entity in Entities)
            {
                if (entity.HasValue) list.Add(entity.Value);
            }
            return list.ToArray();
        }

        public int GetEntityCount()
        {
            int count = 0;
            for(int i = 0; i < 3; i++)
            {
                count += Entities != null ? 1 : 0;
            }
            return count;
        }

        public Position GetEntityPosition(Guid guid)
        {
            for(int i = 0; i < 3; i++)
            {
                if (!Entities[i].HasValue) continue;
                if (Entities[i].Value.Guid == guid) return (Position)i;
            }
            return Position.Error;
        }

        public override string ToString()
        {
            string value = Owner.ToString() + "\n";
            for(int i = 0; i < 3; i++)
            {
                if (Entities[i].HasValue) value += Entities[i].Value.ToString();
                value += "\n";
            }
            return value;
        }
    }
}
