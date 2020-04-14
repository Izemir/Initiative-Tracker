namespace Initiative_Tracker
{
    partial class Tracker
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreatureTable = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPlayersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creaturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creatureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Add = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreatureTable
            // 
            this.CreatureTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreatureTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.CreatureTable.FullRowSelect = true;
            this.CreatureTable.GridLines = true;
            this.CreatureTable.HideSelection = false;
            this.CreatureTable.Location = new System.Drawing.Point(16, 33);
            this.CreatureTable.Margin = new System.Windows.Forms.Padding(4);
            this.CreatureTable.MaximumSize = new System.Drawing.Size(481, 270);
            this.CreatureTable.MinimumSize = new System.Drawing.Size(481, 270);
            this.CreatureTable.Name = "CreatureTable";
            this.CreatureTable.Size = new System.Drawing.Size(481, 270);
            this.CreatureTable.TabIndex = 0;
            this.CreatureTable.UseCompatibleStateImageBehavior = false;
            this.CreatureTable.View = System.Windows.Forms.View.Details;
            this.CreatureTable.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.CreatureTable_ColumnClick);
            this.CreatureTable.SelectedIndexChanged += new System.EventHandler(this.CreatureTable_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Creature";
            this.columnHeader1.Width = 237;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Initiative";
            this.columnHeader2.Width = 171;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(813, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openPlayersToolStripMenuItem,
            this.addPlayerToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openPlayersToolStripMenuItem
            // 
            this.openPlayersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playersToolStripMenuItem,
            this.creaturesToolStripMenuItem});
            this.openPlayersToolStripMenuItem.Name = "openPlayersToolStripMenuItem";
            this.openPlayersToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.openPlayersToolStripMenuItem.Text = "Open";
            // 
            // playersToolStripMenuItem
            // 
            this.playersToolStripMenuItem.Name = "playersToolStripMenuItem";
            this.playersToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.playersToolStripMenuItem.Text = "Players";
            this.playersToolStripMenuItem.Click += new System.EventHandler(this.playersToolStripMenuItem_Click);
            // 
            // creaturesToolStripMenuItem
            // 
            this.creaturesToolStripMenuItem.Name = "creaturesToolStripMenuItem";
            this.creaturesToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.creaturesToolStripMenuItem.Text = "Creatures";
            this.creaturesToolStripMenuItem.Click += new System.EventHandler(this.creaturesToolStripMenuItem_Click);
            // 
            // addPlayerToolStripMenuItem
            // 
            this.addPlayerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerToolStripMenuItem,
            this.creatureToolStripMenuItem});
            this.addPlayerToolStripMenuItem.Name = "addPlayerToolStripMenuItem";
            this.addPlayerToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.addPlayerToolStripMenuItem.Text = "Save";
            this.addPlayerToolStripMenuItem.Click += new System.EventHandler(this.addPlayerToolStripMenuItem_Click);
            // 
            // playerToolStripMenuItem
            // 
            this.playerToolStripMenuItem.Name = "playerToolStripMenuItem";
            this.playerToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.playerToolStripMenuItem.Text = "Player";
            this.playerToolStripMenuItem.Click += new System.EventHandler(this.playerToolStripMenuItem_Click);
            // 
            // creatureToolStripMenuItem
            // 
            this.creatureToolStripMenuItem.Name = "creatureToolStripMenuItem";
            this.creatureToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.creatureToolStripMenuItem.Text = "Creature";
            this.creatureToolStripMenuItem.Click += new System.EventHandler(this.creatureToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Add
            // 
            this.Add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Add.Location = new System.Drawing.Point(537, 47);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 2;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(659, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(537, 96);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Reroll monsters";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(537, 139);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(154, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Reroll chosen";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(537, 189);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(154, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Reroll all";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(537, 234);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(154, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "Set chosen";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Tracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 319);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.CreatureTable);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(831, 366);
            this.MinimumSize = new System.Drawing.Size(831, 366);
            this.Name = "Tracker";
            this.Text = "Initiative Tracker";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView CreatureTable;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openPlayersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPlayerToolStripMenuItem;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ToolStripMenuItem playersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creaturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creatureToolStripMenuItem;
    }
}

