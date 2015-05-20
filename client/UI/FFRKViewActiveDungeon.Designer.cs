﻿namespace FFRKInspector.UI
{
    partial class FFRKViewActiveDungeon
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBoxParty = new System.Windows.Forms.GroupBox();
            this.groupBoxDungeon = new System.Windows.Forms.GroupBox();
            this.listViewActiveDungeon = new System.Windows.Forms.ListView();
            this.columnHeaderBattleBoss = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBattleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBattleRounds = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStamina = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewAllDrops = new FFRKInspector.UI.ListViewEx();
            this.columnHeaderAllName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAllBattle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAllTimes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAllTotalDrops = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAllDropsPerRun = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAllStam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAllReachStamina = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAllRepeatable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelItemsDropped = new System.Windows.Forms.Label();
            this.labelCurrentDrops = new System.Windows.Forms.Label();
            this.listViewActiveBattle = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelActiveBattleNotice = new System.Windows.Forms.Label();
            this.labelNoDrops = new System.Windows.Forms.Label();
            this.groupBoxDungeon.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxParty
            // 
            this.groupBoxParty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxParty.Location = new System.Drawing.Point(3, 222);
            this.groupBoxParty.Name = "groupBoxParty";
            this.groupBoxParty.Size = new System.Drawing.Size(427, 196);
            this.groupBoxParty.TabIndex = 2;
            this.groupBoxParty.TabStop = false;
            this.groupBoxParty.Text = "Status";
            // 
            // groupBoxDungeon
            // 
            this.groupBoxDungeon.Controls.Add(this.listViewActiveDungeon);
            this.groupBoxDungeon.Location = new System.Drawing.Point(3, 3);
            this.groupBoxDungeon.Name = "groupBoxDungeon";
            this.groupBoxDungeon.Size = new System.Drawing.Size(427, 213);
            this.groupBoxDungeon.TabIndex = 1;
            this.groupBoxDungeon.TabStop = false;
            this.groupBoxDungeon.Text = "(No Active Dungeon)";
            // 
            // listViewActiveDungeon
            // 
            this.listViewActiveDungeon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewActiveDungeon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderBattleBoss,
            this.columnHeaderBattleName,
            this.columnHeaderBattleRounds,
            this.columnHeaderStamina});
            this.listViewActiveDungeon.FullRowSelect = true;
            this.listViewActiveDungeon.Location = new System.Drawing.Point(6, 19);
            this.listViewActiveDungeon.Name = "listViewActiveDungeon";
            this.listViewActiveDungeon.Size = new System.Drawing.Size(412, 188);
            this.listViewActiveDungeon.TabIndex = 0;
            this.listViewActiveDungeon.UseCompatibleStateImageBehavior = false;
            this.listViewActiveDungeon.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderBattleBoss
            // 
            this.columnHeaderBattleBoss.Text = "BOSS";
            this.columnHeaderBattleBoss.Width = 57;
            // 
            // columnHeaderBattleName
            // 
            this.columnHeaderBattleName.Text = "Name";
            this.columnHeaderBattleName.Width = 190;
            // 
            // columnHeaderBattleRounds
            // 
            this.columnHeaderBattleRounds.Text = "Rounds";
            // 
            // columnHeaderStamina
            // 
            this.columnHeaderStamina.Text = "Stamina";
            // 
            // listViewAllDrops
            // 
            this.listViewAllDrops.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewAllDrops.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderAllName,
            this.columnHeaderAllBattle,
            this.columnHeaderAllTimes,
            this.columnHeaderAllTotalDrops,
            this.columnHeaderAllDropsPerRun,
            this.columnHeaderAllStam,
            this.columnHeaderAllReachStamina,
            this.columnHeaderAllRepeatable});
            this.listViewAllDrops.FullRowSelect = true;
            this.listViewAllDrops.Location = new System.Drawing.Point(439, 198);
            this.listViewAllDrops.Name = "listViewAllDrops";
            this.listViewAllDrops.Size = new System.Drawing.Size(586, 220);
            this.listViewAllDrops.TabIndex = 3;
            this.listViewAllDrops.UseCompatibleStateImageBehavior = false;
            this.listViewAllDrops.View = System.Windows.Forms.View.Details;
            this.listViewAllDrops.VirtualMode = true;
            this.listViewAllDrops.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewAllDrops_ColumnClick);
            this.listViewAllDrops.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.listViewAllDrops_RetrieveVirtualItem);
            // 
            // columnHeaderAllName
            // 
            this.columnHeaderAllName.Text = "Name";
            this.columnHeaderAllName.Width = 126;
            // 
            // columnHeaderAllBattle
            // 
            this.columnHeaderAllBattle.Text = "Battle";
            this.columnHeaderAllBattle.Width = 134;
            // 
            // columnHeaderAllTimes
            // 
            this.columnHeaderAllTimes.Text = "Times Run";
            this.columnHeaderAllTimes.Width = 71;
            // 
            // columnHeaderAllTotalDrops
            // 
            this.columnHeaderAllTotalDrops.Text = "Total Drops";
            this.columnHeaderAllTotalDrops.Width = 80;
            // 
            // columnHeaderAllDropsPerRun
            // 
            this.columnHeaderAllDropsPerRun.Text = "Drops/Run";
            this.columnHeaderAllDropsPerRun.Width = 74;
            // 
            // columnHeaderAllStam
            // 
            this.columnHeaderAllStam.Text = "Stamina / Drop";
            this.columnHeaderAllStam.Width = 105;
            // 
            // columnHeaderAllReachStamina
            // 
            this.columnHeaderAllReachStamina.Text = "Stam. to Reach";
            this.columnHeaderAllReachStamina.Width = 86;
            // 
            // columnHeaderAllRepeatable
            // 
            this.columnHeaderAllRepeatable.Text = "Repeatable";
            this.columnHeaderAllRepeatable.Width = 67;
            // 
            // labelItemsDropped
            // 
            this.labelItemsDropped.AutoSize = true;
            this.labelItemsDropped.Location = new System.Drawing.Point(436, 177);
            this.labelItemsDropped.Name = "labelItemsDropped";
            this.labelItemsDropped.Size = new System.Drawing.Size(162, 13);
            this.labelItemsDropped.TabIndex = 4;
            this.labelItemsDropped.Text = "All items dropped in this dungeon";
            // 
            // labelCurrentDrops
            // 
            this.labelCurrentDrops.AutoSize = true;
            this.labelCurrentDrops.Location = new System.Drawing.Point(436, 3);
            this.labelCurrentDrops.Name = "labelCurrentDrops";
            this.labelCurrentDrops.Size = new System.Drawing.Size(152, 13);
            this.labelCurrentDrops.TabIndex = 6;
            this.labelCurrentDrops.Text = "Current round drop anticipation";
            // 
            // listViewActiveBattle
            // 
            this.listViewActiveBattle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewActiveBattle.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewActiveBattle.FullRowSelect = true;
            this.listViewActiveBattle.Location = new System.Drawing.Point(439, 22);
            this.listViewActiveBattle.Name = "listViewActiveBattle";
            this.listViewActiveBattle.Size = new System.Drawing.Size(586, 146);
            this.listViewActiveBattle.TabIndex = 7;
            this.listViewActiveBattle.UseCompatibleStateImageBehavior = false;
            this.listViewActiveBattle.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item";
            this.columnHeader1.Width = 72;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Rarity";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Round";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Enemy";
            this.columnHeader4.Width = 104;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Drop Rate";
            this.columnHeader5.Width = 74;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Stamina/Drop";
            this.columnHeader6.Width = 126;
            // 
            // labelActiveBattleNotice
            // 
            this.labelActiveBattleNotice.AutoSize = true;
            this.labelActiveBattleNotice.Location = new System.Drawing.Point(518, 91);
            this.labelActiveBattleNotice.Name = "labelActiveBattleNotice";
            this.labelActiveBattleNotice.Size = new System.Drawing.Size(297, 13);
            this.labelActiveBattleNotice.TabIndex = 8;
            this.labelActiveBattleNotice.Text = "Enter a battle to populate this list with the drops for that battle.";
            // 
            // labelNoDrops
            // 
            this.labelNoDrops.AutoSize = true;
            this.labelNoDrops.Location = new System.Drawing.Point(518, 114);
            this.labelNoDrops.Name = "labelNoDrops";
            this.labelNoDrops.Size = new System.Drawing.Size(100, 13);
            this.labelNoDrops.TabIndex = 9;
            this.labelNoDrops.Text = "There are no drops!";
            // 
            // FFRKViewActiveDungeon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelNoDrops);
            this.Controls.Add(this.labelActiveBattleNotice);
            this.Controls.Add(this.listViewActiveBattle);
            this.Controls.Add(this.labelCurrentDrops);
            this.Controls.Add(this.labelItemsDropped);
            this.Controls.Add(this.listViewAllDrops);
            this.Controls.Add(this.groupBoxParty);
            this.Controls.Add(this.groupBoxDungeon);
            this.Name = "FFRKViewActiveDungeon";
            this.Size = new System.Drawing.Size(1038, 441);
            this.Load += new System.EventHandler(this.FFRKViewCurrentBattle_Load);
            this.SizeChanged += new System.EventHandler(this.FFRKViewCurrentBattle_SizeChanged);
            this.groupBoxDungeon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxParty;
        private System.Windows.Forms.GroupBox groupBoxDungeon;
        private ListViewEx listViewAllDrops;
        private System.Windows.Forms.ColumnHeader columnHeaderAllName;
        private System.Windows.Forms.ColumnHeader columnHeaderAllBattle;
        private System.Windows.Forms.ColumnHeader columnHeaderAllDropsPerRun;
        private System.Windows.Forms.ColumnHeader columnHeaderAllStam;
        private System.Windows.Forms.Label labelItemsDropped;
        private System.Windows.Forms.Label labelCurrentDrops;
        private System.Windows.Forms.ListView listViewActiveDungeon;
        private System.Windows.Forms.ColumnHeader columnHeaderBattleName;
        private System.Windows.Forms.ColumnHeader columnHeaderBattleRounds;
        private System.Windows.Forms.ColumnHeader columnHeaderBattleBoss;
        private System.Windows.Forms.ColumnHeader columnHeaderStamina;
        private System.Windows.Forms.ListView listViewActiveBattle;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label labelActiveBattleNotice;
        private System.Windows.Forms.Label labelNoDrops;
        private System.Windows.Forms.ColumnHeader columnHeaderAllTimes;
        private System.Windows.Forms.ColumnHeader columnHeaderAllTotalDrops;
        private System.Windows.Forms.ColumnHeader columnHeaderAllRepeatable;
        private System.Windows.Forms.ColumnHeader columnHeaderAllReachStamina;
    }
}