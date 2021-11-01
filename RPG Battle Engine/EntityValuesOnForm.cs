using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG_Battle_Engine
{
    public struct EntityValuesOnForm
    {
        public Label HPLabel;
        public Label DamageLabel;
        public Label InitLabel;
        public Label TimingLabel;

        public void SetValues(BattleEntity? entity)
        {
            HPLabel.Text = entity.HasValue ? entity.Value.GetHP().ToString() : "";
            DamageLabel.Text = entity.HasValue ? (entity.Value.GetHP() - entity.Value.Damage).ToString() : "";
            InitLabel.Text = entity.HasValue ? entity.Value.GetInitiative().ToString() : "";
            TimingLabel.Text = entity.HasValue ? entity.Value.Timing.ToString() : "";
        }

        public static EntityValuesOnForm[] LinkForm(BattleViewForm form)
        {
            List<EntityValuesOnForm> list = new()
            {
                new EntityValuesOnForm { HPLabel = form.leftHeroHP, DamageLabel = form.leftHeroDamage, InitLabel = form.leftHeroInit, TimingLabel = form.leftHeroTiming },
                new EntityValuesOnForm { HPLabel = form.middleHeroHp, DamageLabel = form.middleHeroDamage, InitLabel = form.middleHeroInit, TimingLabel = form.middleHeroTiming },
                new EntityValuesOnForm { HPLabel = form.rightHeroHP, DamageLabel = form.rightHeroDamage, InitLabel = form.rightHeroInit, TimingLabel = form.rightHeroTiming },
                new EntityValuesOnForm { HPLabel = form.leftEnemyHP, DamageLabel = form.leftEnemyDamage, InitLabel = form.leftEnemyInit, TimingLabel = form.leftEnemyTiming },
                new EntityValuesOnForm { HPLabel = form.middleEnemyHP, DamageLabel = form.middleEnemyDamage, InitLabel = form.middleEnemyInit, TimingLabel = form.middleEnemyTiming },
                new EntityValuesOnForm { HPLabel = form.rightEnemyHP, DamageLabel = form.turnLabel, InitLabel = form.rightEnemyInit, TimingLabel = form.rightEnemyTiming }
            };
            return list.ToArray();
        }
    }
}
