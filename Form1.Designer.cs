namespace LineUp
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.checkBoxAllSelect = new System.Windows.Forms.CheckBox();
            this.buttonCreateSquad = new System.Windows.Forms.Button();
            this.listViewAllPlayers = new System.Windows.Forms.ListView();
            this.columnHeaderCheck = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderOverall = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxTeamB = new System.Windows.Forms.ListBox();
            this.listBoxTeamA = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPlayerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(718, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addPlayerToolStripMenuItem
            // 
            this.addPlayerToolStripMenuItem.Name = "addPlayerToolStripMenuItem";
            this.addPlayerToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.addPlayerToolStripMenuItem.Text = "Oyuncu Ekle";
            this.addPlayerToolStripMenuItem.Click += new System.EventHandler(this.addPlayerToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.checkBoxAllSelect);
            this.splitContainer1.Panel1.Controls.Add(this.buttonCreateSquad);
            this.splitContainer1.Panel1.Controls.Add(this.listViewAllPlayers);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.listBoxTeamB);
            this.splitContainer1.Panel2.Controls.Add(this.listBoxTeamA);
            this.splitContainer1.Size = new System.Drawing.Size(718, 537);
            this.splitContainer1.SplitterDistance = 273;
            this.splitContainer1.TabIndex = 1;
            // 
            // checkBoxAllSelect
            // 
            this.checkBoxAllSelect.AutoSize = true;
            this.checkBoxAllSelect.Location = new System.Drawing.Point(12, 7);
            this.checkBoxAllSelect.Name = "checkBoxAllSelect";
            this.checkBoxAllSelect.Size = new System.Drawing.Size(111, 24);
            this.checkBoxAllSelect.TabIndex = 2;
            this.checkBoxAllSelect.Text = "Tümünü Seç";
            this.checkBoxAllSelect.UseVisualStyleBackColor = true;
            this.checkBoxAllSelect.CheckedChanged += new System.EventHandler(this.checkBoxAllSelect_CheckedChanged);
            // 
            // buttonCreateSquad
            // 
            this.buttonCreateSquad.BackColor = System.Drawing.Color.Aqua;
            this.buttonCreateSquad.Location = new System.Drawing.Point(63, 489);
            this.buttonCreateSquad.Name = "buttonCreateSquad";
            this.buttonCreateSquad.Size = new System.Drawing.Size(134, 45);
            this.buttonCreateSquad.TabIndex = 1;
            this.buttonCreateSquad.Text = "Kadro Oluştur";
            this.buttonCreateSquad.UseVisualStyleBackColor = false;
            this.buttonCreateSquad.Click += new System.EventHandler(this.buttonCreateSquad_Click);
            // 
            // listViewAllPlayers
            // 
            this.listViewAllPlayers.BackColor = System.Drawing.Color.LightSeaGreen;
            this.listViewAllPlayers.CheckBoxes = true;
            this.listViewAllPlayers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderCheck,
            this.columnHeaderName,
            this.columnHeaderOverall});
            this.listViewAllPlayers.FullRowSelect = true;
            this.listViewAllPlayers.HideSelection = false;
            this.listViewAllPlayers.Location = new System.Drawing.Point(12, 37);
            this.listViewAllPlayers.Name = "listViewAllPlayers";
            this.listViewAllPlayers.Size = new System.Drawing.Size(247, 446);
            this.listViewAllPlayers.TabIndex = 0;
            this.listViewAllPlayers.UseCompatibleStateImageBehavior = false;
            this.listViewAllPlayers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderCheck
            // 
            this.columnHeaderCheck.Text = "Seç";
            this.columnHeaderCheck.Width = 50;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Oyuncu";
            this.columnHeaderName.Width = 190;
            // 
            // columnHeaderOverall
            // 
            this.columnHeaderOverall.Text = "Güç";
            this.columnHeaderOverall.Width = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "2. Takım:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "1. Takım:";
            // 
            // listBoxTeamB
            // 
            this.listBoxTeamB.BackColor = System.Drawing.Color.LightSeaGreen;
            this.listBoxTeamB.FormattingEnabled = true;
            this.listBoxTeamB.ItemHeight = 20;
            this.listBoxTeamB.Location = new System.Drawing.Point(250, 112);
            this.listBoxTeamB.Name = "listBoxTeamB";
            this.listBoxTeamB.Size = new System.Drawing.Size(165, 244);
            this.listBoxTeamB.TabIndex = 1;
            // 
            // listBoxTeamA
            // 
            this.listBoxTeamA.BackColor = System.Drawing.Color.LightSeaGreen;
            this.listBoxTeamA.FormattingEnabled = true;
            this.listBoxTeamA.ItemHeight = 20;
            this.listBoxTeamA.Location = new System.Drawing.Point(21, 112);
            this.listBoxTeamA.Name = "listBoxTeamA";
            this.listBoxTeamA.Size = new System.Drawing.Size(165, 244);
            this.listBoxTeamA.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(718, 561);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonCreateSquad;
        private System.Windows.Forms.ListView listViewAllPlayers;
        private System.Windows.Forms.ToolStripMenuItem addPlayerToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeaderCheck;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeaderOverall;
        private System.Windows.Forms.CheckBox checkBoxAllSelect;
        public System.Windows.Forms.ListBox listBoxTeamB;
        public System.Windows.Forms.ListBox listBoxTeamA;
    }
}

