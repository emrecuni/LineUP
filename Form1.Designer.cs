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
            this.buttonCreateSquad = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderCheck = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPosition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxTeamB = new System.Windows.Forms.ListBox();
            this.listBoxTeamA = new System.Windows.Forms.ListBox();
            this.columnHeaderOverall = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.menuStrip1.Size = new System.Drawing.Size(846, 24);
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
            this.splitContainer1.Panel1.Controls.Add(this.buttonCreateSquad);
            this.splitContainer1.Panel1.Controls.Add(this.listView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.listBoxTeamB);
            this.splitContainer1.Panel2.Controls.Add(this.listBoxTeamA);
            this.splitContainer1.Size = new System.Drawing.Size(846, 512);
            this.splitContainer1.SplitterDistance = 379;
            this.splitContainer1.TabIndex = 1;
            // 
            // buttonCreateSquad
            // 
            this.buttonCreateSquad.BackColor = System.Drawing.Color.Aqua;
            this.buttonCreateSquad.Location = new System.Drawing.Point(125, 455);
            this.buttonCreateSquad.Name = "buttonCreateSquad";
            this.buttonCreateSquad.Size = new System.Drawing.Size(134, 45);
            this.buttonCreateSquad.TabIndex = 1;
            this.buttonCreateSquad.Text = "Kadro Oluştur";
            this.buttonCreateSquad.UseVisualStyleBackColor = false;
            this.buttonCreateSquad.Click += new System.EventHandler(this.buttonCreateSquad_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderCheck,
            this.columnHeaderName,
            this.columnHeaderPosition,
            this.columnHeaderOverall});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(364, 446);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderCheck
            // 
            this.columnHeaderCheck.Text = "Seç";
            this.columnHeaderCheck.Width = 40;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Oyuncu";
            this.columnHeaderName.Width = 140;
            // 
            // columnHeaderPosition
            // 
            this.columnHeaderPosition.Text = "Mevki";
            this.columnHeaderPosition.Width = 120;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "2. Takım:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 79);
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
            this.listBoxTeamB.Location = new System.Drawing.Point(282, 112);
            this.listBoxTeamB.Name = "listBoxTeamB";
            this.listBoxTeamB.Size = new System.Drawing.Size(165, 244);
            this.listBoxTeamB.TabIndex = 1;
            // 
            // listBoxTeamA
            // 
            this.listBoxTeamA.BackColor = System.Drawing.Color.LightSeaGreen;
            this.listBoxTeamA.FormattingEnabled = true;
            this.listBoxTeamA.ItemHeight = 20;
            this.listBoxTeamA.Location = new System.Drawing.Point(53, 112);
            this.listBoxTeamA.Name = "listBoxTeamA";
            this.listBoxTeamA.Size = new System.Drawing.Size(165, 244);
            this.listBoxTeamA.TabIndex = 0;
            // 
            // columnHeaderOverall
            // 
            this.columnHeaderOverall.Text = "Güç";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(846, 536);
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
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ToolStripMenuItem addPlayerToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeaderCheck;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderPosition;
        private System.Windows.Forms.ListBox listBoxTeamB;
        private System.Windows.Forms.ListBox listBoxTeamA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeaderOverall;
    }
}

