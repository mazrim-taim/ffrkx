﻿namespace FFRKInspector.UI
{
    partial class FFRKViewInventory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgcItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcRarity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcSynergy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcATK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcMAG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcDEF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcRES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxUpgradeMode = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listViewEx1 = new FFRKInspector.UI.ListViewEx();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSynergy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxViewMode = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(213)))), ((int)(((byte)(180)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcItem,
            this.dgcCategory,
            this.dgcType,
            this.dgcRarity,
            this.dgcSynergy,
            this.dgcLevel,
            this.dgcATK,
            this.dgcMAG,
            this.dgcMND,
            this.dgcDEF,
            this.dgcRES,
            this.dgcScore});
            this.dataGridView1.Location = new System.Drawing.Point(13, 66);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(210)))), ((int)(((byte)(228)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(707, 499);
            this.dataGridView1.TabIndex = 0;
            // 
            // dgcItem
            // 
            this.dgcItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgcItem.HeaderText = "Item";
            this.dgcItem.Name = "dgcItem";
            this.dgcItem.ReadOnly = true;
            this.dgcItem.Width = 52;
            // 
            // dgcCategory
            // 
            this.dgcCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgcCategory.HeaderText = "Category";
            this.dgcCategory.Name = "dgcCategory";
            this.dgcCategory.ReadOnly = true;
            this.dgcCategory.Width = 74;
            // 
            // dgcType
            // 
            this.dgcType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgcType.HeaderText = "Type";
            this.dgcType.Name = "dgcType";
            this.dgcType.ReadOnly = true;
            this.dgcType.Width = 56;
            // 
            // dgcRarity
            // 
            this.dgcRarity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgcRarity.HeaderText = "Rarity";
            this.dgcRarity.Name = "dgcRarity";
            this.dgcRarity.ReadOnly = true;
            // 
            // dgcSynergy
            // 
            this.dgcSynergy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgcSynergy.HeaderText = "Synergy";
            this.dgcSynergy.Name = "dgcSynergy";
            this.dgcSynergy.ReadOnly = true;
            // 
            // dgcLevel
            // 
            this.dgcLevel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgcLevel.HeaderText = "Level";
            this.dgcLevel.Name = "dgcLevel";
            this.dgcLevel.ReadOnly = true;
            // 
            // dgcATK
            // 
            this.dgcATK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgcATK.HeaderText = "ATK";
            this.dgcATK.Name = "dgcATK";
            this.dgcATK.ReadOnly = true;
            // 
            // dgcMAG
            // 
            this.dgcMAG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgcMAG.HeaderText = "MAG";
            this.dgcMAG.Name = "dgcMAG";
            this.dgcMAG.ReadOnly = true;
            // 
            // dgcMND
            // 
            this.dgcMND.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgcMND.HeaderText = "MND";
            this.dgcMND.Name = "dgcMND";
            this.dgcMND.ReadOnly = true;
            // 
            // dgcDEF
            // 
            this.dgcDEF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgcDEF.HeaderText = "DEF";
            this.dgcDEF.Name = "dgcDEF";
            this.dgcDEF.ReadOnly = true;
            // 
            // dgcRES
            // 
            this.dgcRES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgcRES.HeaderText = "RES";
            this.dgcRES.Name = "dgcRES";
            this.dgcRES.ReadOnly = true;
            // 
            // dgcScore
            // 
            this.dgcScore.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgcScore.HeaderText = "Score";
            this.dgcScore.Name = "dgcScore";
            this.dgcScore.ReadOnly = true;
            // 
            // comboBoxUpgradeMode
            // 
            this.comboBoxUpgradeMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUpgradeMode.FormattingEnabled = true;
            this.comboBoxUpgradeMode.Items.AddRange(new object[] {
            "at the items\' current rarity and level.",
            "at the items\' current rarity and maximum level.",
            "at the items\' maximum rarity and level."});
            this.comboBoxUpgradeMode.Location = new System.Drawing.Point(260, 40);
            this.comboBoxUpgradeMode.Name = "comboBoxUpgradeMode";
            this.comboBoxUpgradeMode.Size = new System.Drawing.Size(255, 21);
            this.comboBoxUpgradeMode.TabIndex = 1;
            this.comboBoxUpgradeMode.SelectedIndexChanged += new System.EventHandler(this.comboBoxUpgradeMode_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.listViewEx1);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(336, 568);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Available characters";
            // 
            // listViewEx1
            // 
            this.listViewEx1.DataBinding = null;
            this.listViewEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewEx1.Location = new System.Drawing.Point(3, 16);
            this.listViewEx1.Name = "listViewEx1";
            this.listViewEx1.SettingsKey = "FFRKViewInventory_PartyList";
            this.listViewEx1.Size = new System.Drawing.Size(330, 549);
            this.listViewEx1.TabIndex = 5;
            this.listViewEx1.UseCompatibleStateImageBehavior = false;
            this.listViewEx1.View = System.Windows.Forms.View.Details;
            this.listViewEx1.VirtualMode = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.comboBoxSynergy);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.comboBoxViewMode);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.comboBoxUpgradeMode);
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(345, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(726, 568);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Equipment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(712, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Don\'t see anything here?  The game only sends this information the first time you" +
    " view your party screen.  You may need to close and re-open the app.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(638, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "record synergy.";
            // 
            // comboBoxSynergy
            // 
            this.comboBoxSynergy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSynergy.FormattingEnabled = true;
            this.comboBoxSynergy.Location = new System.Drawing.Point(553, 40);
            this.comboBoxSynergy.Name = "comboBoxSynergy";
            this.comboBoxSynergy.Size = new System.Drawing.Size(79, 21);
            this.comboBoxSynergy.TabIndex = 4;
            this.comboBoxSynergy.SelectedIndexChanged += new System.EventHandler(this.comboBoxSynergy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(521, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "with";
            // 
            // comboBoxViewMode
            // 
            this.comboBoxViewMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxViewMode.FormattingEnabled = true;
            this.comboBoxViewMode.Items.AddRange(new object[] {
            "Available equipment and their stats",
            "Characters\' best items"});
            this.comboBoxViewMode.Location = new System.Drawing.Point(46, 40);
            this.comboBoxViewMode.Name = "comboBoxViewMode";
            this.comboBoxViewMode.Size = new System.Drawing.Size(208, 21);
            this.comboBoxViewMode.TabIndex = 2;
            this.comboBoxViewMode.SelectedIndexChanged += new System.EventHandler(this.comboBoxViewMode_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "View";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Item";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 52;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Category";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 74;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Type";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 56;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Rarity";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 59;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Synergy";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 70;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Level";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 58;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "ATK";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 53;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "MAG";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 56;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn9.HeaderText = "MND";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn10.HeaderText = "DEF";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn11.HeaderText = "RES";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn12.HeaderText = "Score";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // FFRKViewInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Name = "FFRKViewInventory";
            this.Size = new System.Drawing.Size(1083, 593);
            this.Load += new System.EventHandler(this.FFRKViewInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ListViewEx listViewEx1;
        private System.Windows.Forms.ComboBox comboBoxUpgradeMode;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboBoxViewMode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSynergy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRarity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcSynergy;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcATK;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcMAG;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDEF;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRES;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    }
}