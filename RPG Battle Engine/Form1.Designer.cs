
namespace RPG_Battle_Engine
{
    partial class BattleViewForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.middleEnemyTurnBox = new System.Windows.Forms.CheckBox();
            this.middleHeroTurnBox = new System.Windows.Forms.CheckBox();
            this.actionButton = new System.Windows.Forms.Button();
            this.leftEnemyTurnBox = new System.Windows.Forms.CheckBox();
            this.leftHeroTurnBox = new System.Windows.Forms.CheckBox();
            this.rightEnemyTurnBox = new System.Windows.Forms.CheckBox();
            this.rightHeroTurnBox = new System.Windows.Forms.CheckBox();
            this.leftHeroHP = new System.Windows.Forms.Label();
            this.middleHeroHp = new System.Windows.Forms.Label();
            this.rightHeroHP = new System.Windows.Forms.Label();
            this.leftEnemyHP = new System.Windows.Forms.Label();
            this.middleEnemyHP = new System.Windows.Forms.Label();
            this.rightEnemyHP = new System.Windows.Forms.Label();
            this.leftHeroDamage = new System.Windows.Forms.Label();
            this.middleHeroDamage = new System.Windows.Forms.Label();
            this.rightHeroDamage = new System.Windows.Forms.Label();
            this.leftEnemyDamage = new System.Windows.Forms.Label();
            this.middleEnemyDamage = new System.Windows.Forms.Label();
            this.turnLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.leftHeroTiming = new System.Windows.Forms.Label();
            this.leftHeroInit = new System.Windows.Forms.Label();
            this.middleHeroInit = new System.Windows.Forms.Label();
            this.middleHeroTiming = new System.Windows.Forms.Label();
            this.rightHeroInit = new System.Windows.Forms.Label();
            this.rightHeroTiming = new System.Windows.Forms.Label();
            this.leftEnemyInit = new System.Windows.Forms.Label();
            this.leftEnemyTiming = new System.Windows.Forms.Label();
            this.middleEnemyInit = new System.Windows.Forms.Label();
            this.middleEnemyTiming = new System.Windows.Forms.Label();
            this.rightEnemyInit = new System.Windows.Forms.Label();
            this.rightEnemyTiming = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.turnCount = new System.Windows.Forms.Label();
            this.BattleHash = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-7, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1316, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "█████████████████████████████████████████████████████████████████████████████████" +
    "██████████████████████████████████████";
            // 
            // middleEnemyTurnBox
            // 
            this.middleEnemyTurnBox.AutoSize = true;
            this.middleEnemyTurnBox.Enabled = false;
            this.middleEnemyTurnBox.Location = new System.Drawing.Point(571, 302);
            this.middleEnemyTurnBox.Name = "middleEnemyTurnBox";
            this.middleEnemyTurnBox.Size = new System.Drawing.Size(102, 19);
            this.middleEnemyTurnBox.TabIndex = 1;
            this.middleEnemyTurnBox.Text = "Middle Enemy";
            this.middleEnemyTurnBox.UseVisualStyleBackColor = true;
            // 
            // middleHeroTurnBox
            // 
            this.middleHeroTurnBox.AutoSize = true;
            this.middleHeroTurnBox.Enabled = false;
            this.middleHeroTurnBox.Location = new System.Drawing.Point(571, 342);
            this.middleHeroTurnBox.Name = "middleHeroTurnBox";
            this.middleHeroTurnBox.Size = new System.Drawing.Size(92, 19);
            this.middleHeroTurnBox.TabIndex = 2;
            this.middleHeroTurnBox.Text = "Middle Hero";
            this.middleHeroTurnBox.UseVisualStyleBackColor = true;
            // 
            // actionButton
            // 
            this.actionButton.Location = new System.Drawing.Point(588, 320);
            this.actionButton.Name = "actionButton";
            this.actionButton.Size = new System.Drawing.Size(75, 23);
            this.actionButton.TabIndex = 3;
            this.actionButton.Text = "Action";
            this.actionButton.UseVisualStyleBackColor = true;
            this.actionButton.Click += new System.EventHandler(this.ActionButton_Click);
            // 
            // leftEnemyTurnBox
            // 
            this.leftEnemyTurnBox.AutoSize = true;
            this.leftEnemyTurnBox.Enabled = false;
            this.leftEnemyTurnBox.Location = new System.Drawing.Point(12, 302);
            this.leftEnemyTurnBox.Name = "leftEnemyTurnBox";
            this.leftEnemyTurnBox.Size = new System.Drawing.Size(85, 19);
            this.leftEnemyTurnBox.TabIndex = 4;
            this.leftEnemyTurnBox.Text = "Left Enemy";
            this.leftEnemyTurnBox.UseVisualStyleBackColor = true;
            // 
            // leftHeroTurnBox
            // 
            this.leftHeroTurnBox.AutoSize = true;
            this.leftHeroTurnBox.Enabled = false;
            this.leftHeroTurnBox.Location = new System.Drawing.Point(12, 341);
            this.leftHeroTurnBox.Name = "leftHeroTurnBox";
            this.leftHeroTurnBox.Size = new System.Drawing.Size(75, 19);
            this.leftHeroTurnBox.TabIndex = 5;
            this.leftHeroTurnBox.Text = "Left Hero";
            this.leftHeroTurnBox.UseVisualStyleBackColor = true;
            // 
            // rightEnemyTurnBox
            // 
            this.rightEnemyTurnBox.AutoSize = true;
            this.rightEnemyTurnBox.Enabled = false;
            this.rightEnemyTurnBox.Location = new System.Drawing.Point(1157, 302);
            this.rightEnemyTurnBox.Name = "rightEnemyTurnBox";
            this.rightEnemyTurnBox.Size = new System.Drawing.Size(93, 19);
            this.rightEnemyTurnBox.TabIndex = 6;
            this.rightEnemyTurnBox.Text = "Right Enemy";
            this.rightEnemyTurnBox.UseVisualStyleBackColor = true;
            // 
            // rightHeroTurnBox
            // 
            this.rightHeroTurnBox.AutoSize = true;
            this.rightHeroTurnBox.Enabled = false;
            this.rightHeroTurnBox.Location = new System.Drawing.Point(1157, 341);
            this.rightHeroTurnBox.Name = "rightHeroTurnBox";
            this.rightHeroTurnBox.Size = new System.Drawing.Size(83, 19);
            this.rightHeroTurnBox.TabIndex = 7;
            this.rightHeroTurnBox.Text = "Right Hero";
            this.rightHeroTurnBox.UseVisualStyleBackColor = true;
            // 
            // leftHeroHP
            // 
            this.leftHeroHP.AutoSize = true;
            this.leftHeroHP.Location = new System.Drawing.Point(95, 365);
            this.leftHeroHP.Name = "leftHeroHP";
            this.leftHeroHP.Size = new System.Drawing.Size(60, 15);
            this.leftHeroHP.TabIndex = 8;
            this.leftHeroHP.Text = "HP VALUE";
            // 
            // middleHeroHp
            // 
            this.middleHeroHp.AutoSize = true;
            this.middleHeroHp.Location = new System.Drawing.Point(654, 364);
            this.middleHeroHp.Name = "middleHeroHp";
            this.middleHeroHp.Size = new System.Drawing.Size(60, 15);
            this.middleHeroHp.TabIndex = 9;
            this.middleHeroHp.Text = "HP VALUE";
            // 
            // rightHeroHP
            // 
            this.rightHeroHP.AutoSize = true;
            this.rightHeroHP.Location = new System.Drawing.Point(1180, 365);
            this.rightHeroHP.Name = "rightHeroHP";
            this.rightHeroHP.Size = new System.Drawing.Size(60, 15);
            this.rightHeroHP.TabIndex = 10;
            this.rightHeroHP.Text = "HP VALUE";
            // 
            // leftEnemyHP
            // 
            this.leftEnemyHP.AutoSize = true;
            this.leftEnemyHP.Location = new System.Drawing.Point(95, 9);
            this.leftEnemyHP.Name = "leftEnemyHP";
            this.leftEnemyHP.Size = new System.Drawing.Size(60, 15);
            this.leftEnemyHP.TabIndex = 11;
            this.leftEnemyHP.Text = "HP VALUE";
            // 
            // middleEnemyHP
            // 
            this.middleEnemyHP.AutoSize = true;
            this.middleEnemyHP.Location = new System.Drawing.Point(654, 9);
            this.middleEnemyHP.Name = "middleEnemyHP";
            this.middleEnemyHP.Size = new System.Drawing.Size(60, 15);
            this.middleEnemyHP.TabIndex = 12;
            this.middleEnemyHP.Text = "HP VALUE";
            // 
            // rightEnemyHP
            // 
            this.rightEnemyHP.AutoSize = true;
            this.rightEnemyHP.Location = new System.Drawing.Point(1180, 9);
            this.rightEnemyHP.Name = "rightEnemyHP";
            this.rightEnemyHP.Size = new System.Drawing.Size(60, 15);
            this.rightEnemyHP.TabIndex = 13;
            this.rightEnemyHP.Text = "HP VALUE";
            // 
            // leftHeroDamage
            // 
            this.leftHeroDamage.AutoSize = true;
            this.leftHeroDamage.Location = new System.Drawing.Point(12, 365);
            this.leftHeroDamage.Name = "leftHeroDamage";
            this.leftHeroDamage.Size = new System.Drawing.Size(56, 15);
            this.leftHeroDamage.TabIndex = 14;
            this.leftHeroDamage.Text = "DAMAGE";
            // 
            // middleHeroDamage
            // 
            this.middleHeroDamage.AutoSize = true;
            this.middleHeroDamage.Location = new System.Drawing.Point(571, 365);
            this.middleHeroDamage.Name = "middleHeroDamage";
            this.middleHeroDamage.Size = new System.Drawing.Size(56, 15);
            this.middleHeroDamage.TabIndex = 15;
            this.middleHeroDamage.Text = "DAMAGE";
            // 
            // rightHeroDamage
            // 
            this.rightHeroDamage.AutoSize = true;
            this.rightHeroDamage.Location = new System.Drawing.Point(1099, 365);
            this.rightHeroDamage.Name = "rightHeroDamage";
            this.rightHeroDamage.Size = new System.Drawing.Size(56, 15);
            this.rightHeroDamage.TabIndex = 16;
            this.rightHeroDamage.Text = "DAMAGE";
            // 
            // leftEnemyDamage
            // 
            this.leftEnemyDamage.AutoSize = true;
            this.leftEnemyDamage.Location = new System.Drawing.Point(12, 9);
            this.leftEnemyDamage.Name = "leftEnemyDamage";
            this.leftEnemyDamage.Size = new System.Drawing.Size(56, 15);
            this.leftEnemyDamage.TabIndex = 17;
            this.leftEnemyDamage.Text = "DAMAGE";
            // 
            // middleEnemyDamage
            // 
            this.middleEnemyDamage.AutoSize = true;
            this.middleEnemyDamage.Location = new System.Drawing.Point(571, 9);
            this.middleEnemyDamage.Name = "middleEnemyDamage";
            this.middleEnemyDamage.Size = new System.Drawing.Size(56, 15);
            this.middleEnemyDamage.TabIndex = 18;
            this.middleEnemyDamage.Text = "DAMAGE";
            // 
            // turnLabel
            // 
            this.turnLabel.AutoSize = true;
            this.turnLabel.Location = new System.Drawing.Point(1099, 9);
            this.turnLabel.Name = "turnLabel";
            this.turnLabel.Size = new System.Drawing.Size(56, 15);
            this.turnLabel.TabIndex = 19;
            this.turnLabel.Text = "DAMAGE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "/";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(636, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "/";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1162, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "/";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "/";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(636, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 15);
            this.label6.TabIndex = 24;
            this.label6.Text = "/";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1162, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 15);
            this.label7.TabIndex = 25;
            this.label7.Text = "/";
            // 
            // leftHeroTiming
            // 
            this.leftHeroTiming.AutoSize = true;
            this.leftHeroTiming.Location = new System.Drawing.Point(95, 380);
            this.leftHeroTiming.Name = "leftHeroTiming";
            this.leftHeroTiming.Size = new System.Drawing.Size(47, 15);
            this.leftHeroTiming.TabIndex = 26;
            this.leftHeroTiming.Text = "TIMING";
            // 
            // leftHeroInit
            // 
            this.leftHeroInit.AutoSize = true;
            this.leftHeroInit.Location = new System.Drawing.Point(12, 380);
            this.leftHeroInit.Name = "leftHeroInit";
            this.leftHeroInit.Size = new System.Drawing.Size(28, 15);
            this.leftHeroInit.TabIndex = 27;
            this.leftHeroInit.Text = "INIT";
            // 
            // middleHeroInit
            // 
            this.middleHeroInit.AutoSize = true;
            this.middleHeroInit.Location = new System.Drawing.Point(571, 380);
            this.middleHeroInit.Name = "middleHeroInit";
            this.middleHeroInit.Size = new System.Drawing.Size(28, 15);
            this.middleHeroInit.TabIndex = 29;
            this.middleHeroInit.Text = "INIT";
            // 
            // middleHeroTiming
            // 
            this.middleHeroTiming.AutoSize = true;
            this.middleHeroTiming.Location = new System.Drawing.Point(654, 380);
            this.middleHeroTiming.Name = "middleHeroTiming";
            this.middleHeroTiming.Size = new System.Drawing.Size(47, 15);
            this.middleHeroTiming.TabIndex = 28;
            this.middleHeroTiming.Text = "TIMING";
            // 
            // rightHeroInit
            // 
            this.rightHeroInit.AutoSize = true;
            this.rightHeroInit.Location = new System.Drawing.Point(1099, 380);
            this.rightHeroInit.Name = "rightHeroInit";
            this.rightHeroInit.Size = new System.Drawing.Size(28, 15);
            this.rightHeroInit.TabIndex = 31;
            this.rightHeroInit.Text = "INIT";
            // 
            // rightHeroTiming
            // 
            this.rightHeroTiming.AutoSize = true;
            this.rightHeroTiming.Location = new System.Drawing.Point(1182, 380);
            this.rightHeroTiming.Name = "rightHeroTiming";
            this.rightHeroTiming.Size = new System.Drawing.Size(47, 15);
            this.rightHeroTiming.TabIndex = 30;
            this.rightHeroTiming.Text = "TIMING";
            // 
            // leftEnemyInit
            // 
            this.leftEnemyInit.AutoSize = true;
            this.leftEnemyInit.Location = new System.Drawing.Point(12, 24);
            this.leftEnemyInit.Name = "leftEnemyInit";
            this.leftEnemyInit.Size = new System.Drawing.Size(28, 15);
            this.leftEnemyInit.TabIndex = 33;
            this.leftEnemyInit.Text = "INIT";
            // 
            // leftEnemyTiming
            // 
            this.leftEnemyTiming.AutoSize = true;
            this.leftEnemyTiming.Location = new System.Drawing.Point(95, 24);
            this.leftEnemyTiming.Name = "leftEnemyTiming";
            this.leftEnemyTiming.Size = new System.Drawing.Size(47, 15);
            this.leftEnemyTiming.TabIndex = 32;
            this.leftEnemyTiming.Text = "TIMING";
            // 
            // middleEnemyInit
            // 
            this.middleEnemyInit.AutoSize = true;
            this.middleEnemyInit.Location = new System.Drawing.Point(571, 24);
            this.middleEnemyInit.Name = "middleEnemyInit";
            this.middleEnemyInit.Size = new System.Drawing.Size(28, 15);
            this.middleEnemyInit.TabIndex = 35;
            this.middleEnemyInit.Text = "INIT";
            // 
            // middleEnemyTiming
            // 
            this.middleEnemyTiming.AutoSize = true;
            this.middleEnemyTiming.Location = new System.Drawing.Point(654, 24);
            this.middleEnemyTiming.Name = "middleEnemyTiming";
            this.middleEnemyTiming.Size = new System.Drawing.Size(47, 15);
            this.middleEnemyTiming.TabIndex = 34;
            this.middleEnemyTiming.Text = "TIMING";
            // 
            // rightEnemyInit
            // 
            this.rightEnemyInit.AutoSize = true;
            this.rightEnemyInit.Location = new System.Drawing.Point(1099, 24);
            this.rightEnemyInit.Name = "rightEnemyInit";
            this.rightEnemyInit.Size = new System.Drawing.Size(28, 15);
            this.rightEnemyInit.TabIndex = 37;
            this.rightEnemyInit.Text = "INIT";
            // 
            // rightEnemyTiming
            // 
            this.rightEnemyTiming.AutoSize = true;
            this.rightEnemyTiming.Location = new System.Drawing.Point(1182, 24);
            this.rightEnemyTiming.Name = "rightEnemyTiming";
            this.rightEnemyTiming.Size = new System.Drawing.Size(47, 15);
            this.rightEnemyTiming.TabIndex = 36;
            this.rightEnemyTiming.Text = "TIMING";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(77, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 15);
            this.label8.TabIndex = 38;
            this.label8.Text = "|";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(77, 380);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 15);
            this.label9.TabIndex = 39;
            this.label9.Text = "|";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(636, 380);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(10, 15);
            this.label10.TabIndex = 40;
            this.label10.Text = "|";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(636, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 15);
            this.label11.TabIndex = 41;
            this.label11.Text = "|";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1164, 380);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(10, 15);
            this.label12.TabIndex = 42;
            this.label12.Text = "|";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1164, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(10, 15);
            this.label13.TabIndex = 43;
            this.label13.Text = "|";
            // 
            // turnCount
            // 
            this.turnCount.AutoSize = true;
            this.turnCount.Location = new System.Drawing.Point(1157, 324);
            this.turnCount.Name = "turnCount";
            this.turnCount.Size = new System.Drawing.Size(13, 15);
            this.turnCount.TabIndex = 44;
            this.turnCount.Text = "0";
            // 
            // BattleHash
            // 
            this.BattleHash.AutoSize = true;
            this.BattleHash.Location = new System.Drawing.Point(12, 324);
            this.BattleHash.Name = "BattleHash";
            this.BattleHash.Size = new System.Drawing.Size(13, 15);
            this.BattleHash.TabIndex = 45;
            this.BattleHash.Text = "0";
            // 
            // battleViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.BattleHash);
            this.Controls.Add(this.turnCount);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rightEnemyInit);
            this.Controls.Add(this.rightEnemyTiming);
            this.Controls.Add(this.middleEnemyInit);
            this.Controls.Add(this.middleEnemyTiming);
            this.Controls.Add(this.leftEnemyInit);
            this.Controls.Add(this.leftEnemyTiming);
            this.Controls.Add(this.rightHeroInit);
            this.Controls.Add(this.rightHeroTiming);
            this.Controls.Add(this.middleHeroInit);
            this.Controls.Add(this.middleHeroTiming);
            this.Controls.Add(this.leftHeroInit);
            this.Controls.Add(this.leftHeroTiming);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.turnLabel);
            this.Controls.Add(this.middleEnemyDamage);
            this.Controls.Add(this.leftEnemyDamage);
            this.Controls.Add(this.rightHeroDamage);
            this.Controls.Add(this.middleHeroDamage);
            this.Controls.Add(this.leftHeroDamage);
            this.Controls.Add(this.rightEnemyHP);
            this.Controls.Add(this.middleEnemyHP);
            this.Controls.Add(this.leftEnemyHP);
            this.Controls.Add(this.rightHeroHP);
            this.Controls.Add(this.middleHeroHp);
            this.Controls.Add(this.leftHeroHP);
            this.Controls.Add(this.rightHeroTurnBox);
            this.Controls.Add(this.rightEnemyTurnBox);
            this.Controls.Add(this.leftHeroTurnBox);
            this.Controls.Add(this.leftEnemyTurnBox);
            this.Controls.Add(this.actionButton);
            this.Controls.Add(this.middleHeroTurnBox);
            this.Controls.Add(this.middleEnemyTurnBox);
            this.Controls.Add(this.label1);
            this.Name = "battleViewForm";
            this.Text = "battleViewForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox middleEnemyTurnBox;
        private System.Windows.Forms.CheckBox middleHeroTurnBox;
        private System.Windows.Forms.Button actionButton;
        private System.Windows.Forms.CheckBox leftEnemyTurnBox;
        private System.Windows.Forms.CheckBox leftHeroTurnBox;
        private System.Windows.Forms.CheckBox rightEnemyTurnBox;
        private System.Windows.Forms.CheckBox rightHeroTurnBox;
        public System.Windows.Forms.Label leftHeroHP;
        public System.Windows.Forms.Label middleHeroHp;
        public System.Windows.Forms.Label rightHeroHP;
        public System.Windows.Forms.Label leftEnemyHP;
        public System.Windows.Forms.Label middleEnemyHP;
        public System.Windows.Forms.Label rightEnemyHP;
        public System.Windows.Forms.Label leftHeroDamage;
        public System.Windows.Forms.Label middleHeroDamage;
        public System.Windows.Forms.Label rightHeroDamage;
        public System.Windows.Forms.Label leftEnemyDamage;
        public System.Windows.Forms.Label middleEnemyDamage;
        public System.Windows.Forms.Label turnLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label leftHeroTiming;
        public System.Windows.Forms.Label leftHeroInit;
        public System.Windows.Forms.Label middleHeroInit;
        public System.Windows.Forms.Label middleHeroTiming;
        public System.Windows.Forms.Label rightHeroInit;
        public System.Windows.Forms.Label rightHeroTiming;
        public System.Windows.Forms.Label leftEnemyInit;
        public System.Windows.Forms.Label leftEnemyTiming;
        public System.Windows.Forms.Label middleEnemyInit;
        public System.Windows.Forms.Label middleEnemyTiming;
        public System.Windows.Forms.Label rightEnemyInit;
        public System.Windows.Forms.Label rightEnemyTiming;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label turnCount;
        private System.Windows.Forms.Label BattleHash;
    }
}

