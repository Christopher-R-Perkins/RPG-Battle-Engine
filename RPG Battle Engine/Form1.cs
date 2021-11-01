using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Windows.Forms;

namespace RPG_Battle_Engine
{
    public partial class BattleViewForm : Form
    {
        Guid Hero;
        Guid Enemy;
        BattleState currentState;
        EntityValuesOnForm[] formValues;

        public BattleViewForm()
        {
            InitializeComponent();
            AbilityBinder.InstantiateBinder();
            Hero = new Guid("afe2ef2f-54f2-4f28-adfa-a88606718b7c");
            Enemy = new Guid("be12d0c8-1d2f-4cbb-8f3e-e6a2cc9b40b2");

            EffectStack stack = EffectStack.Create();
            List<IBattleAbility> list = new List<IBattleAbility>();
            var ability = AbilityBinder.GetAbility("525047460000BA794141000000000002");
            list.Add(ability);
            var dict = ImmutableDictionary.Create<Guid, int>();

            BattleEntity enemyMid = new BattleEntity(Enemy,new Guid("a96e18b6-16e0-4f10-ac25-fd4999cf25ac"),3,2,5,0,0,0, list.ToImmutableList(),dict);
            BattleEntity enemyRight = new BattleEntity(Enemy,new Guid("20a878a3-51cf-4a1b-840b-6aa6b88fefb1"),0,1,10,4,1,1, list.ToImmutableList(), dict);
            BattleEntity heroLeft = new BattleEntity(Hero,new Guid("56695cc0-5bd5-437b-9e35-65ca6f7378d0"),0,0,20,6,0,1, list.ToImmutableList(), dict,58);
            list.Add(new PoisonedPassiveAbility());
            BattleEntity heroRight = new BattleEntity(Hero,new Guid("0e87b624-cc84-4223-8ca0-4ed404ddb746"), 5,3,7,2,0,3, list.ToImmutableList(), dict);
            BattleField heroField = new BattleField(Hero, leftEntity: heroLeft, rightEntity: heroRight);
            BattleField enemyField = new BattleField(Enemy, middleEntity: enemyMid, rightEntity: enemyRight);

            currentState = new BattleState(heroField, enemyField, stack);
            formValues = EntityValuesOnForm.LinkForm(this);

            ShowState();
        }

        private void ActionButton_Click(object sender, EventArgs e)
        {
            var turnEntity = currentState.GetTurnEntity();

            EffectStack newStack = currentState.Stack.Push(currentState, new EndTurnEffect());
            newStack = newStack.Push(currentState, new DelayEffect(turnEntity.Guid, turnEntity.Guid, 200));

            currentState = new(currentState, stack: newStack);
            while(!currentState.Stack.IsEmpty)
            {
                newStack = currentState.Stack.Pop(out IBattleEffect effect);
                currentState = new(currentState, stack: newStack);
                currentState = effect.TakeEffect(currentState);
            }

            ShowState();
        }

        private void ShowState()
        {
            middleEnemyTurnBox.Checked = false;
            leftEnemyTurnBox.Checked = false;
            rightEnemyTurnBox.Checked = false;
            middleHeroTurnBox.Checked = false;
            leftHeroTurnBox.Checked = false;
            rightHeroTurnBox.Checked = false;

            turnCount.Text = currentState.TurnCount.ToString();
            var bytes = currentState.ToHash();
            string hash = "[";
            for (int i = 0; i < bytes.Length; i++) hash += bytes[i].ToString(format:"x") + (i < bytes.Length-1 ? ":" : "");
            hash += "]";
            BattleHash.Text = hash;

            List<BattleEntity?> entities = new(currentState.Fields[0].Entities);
            entities.AddRange(currentState.Fields[1].Entities);

            for (int i = 0; i < 6; i++) formValues[i].SetValues(entities[i]);

            var turnEntity = currentState.GetTurnEntity();
            var pos = Position.Error;
            foreach (BattleField field in currentState.Fields)
            {
                if (turnEntity.Owner != field.Owner) continue;
                pos = field.GetEntityPosition(turnEntity.Guid);
            }

            switch(pos)
            {
            case Position.Left:
                leftEnemyTurnBox.Checked = turnEntity.Owner == Enemy;
                leftHeroTurnBox.Checked = turnEntity.Owner == Hero;
                break;
            case Position.Middle:
                middleEnemyTurnBox.Checked = turnEntity.Owner == Enemy;
                middleHeroTurnBox.Checked = turnEntity.Owner == Hero;
                break;
            case Position.Right:
                rightEnemyTurnBox.Checked = turnEntity.Owner == Enemy;
                rightHeroTurnBox.Checked = turnEntity.Owner == Hero;
                break;
            default:
                break;
            }
        }
    }
}
