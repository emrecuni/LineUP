namespace LineUp
{
    partial class FormSelectGoalkeeper
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelGoalkeeper2 = new System.Windows.Forms.Label();
            this.labelGoalkeeper1 = new System.Windows.Forms.Label();
            this.comboBoxGoalkeeper2 = new System.Windows.Forms.ComboBox();
            this.comboBoxGoalkeeper1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonSave.Location = new System.Drawing.Point(101, 122);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(121, 30);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Seçimi Kaydet";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelGoalkeeper2
            // 
            this.labelGoalkeeper2.AutoSize = true;
            this.labelGoalkeeper2.Location = new System.Drawing.Point(10, 78);
            this.labelGoalkeeper2.Name = "labelGoalkeeper2";
            this.labelGoalkeeper2.Size = new System.Drawing.Size(69, 20);
            this.labelGoalkeeper2.TabIndex = 3;
            this.labelGoalkeeper2.Text = "2. Kaleci:";
            // 
            // labelGoalkeeper1
            // 
            this.labelGoalkeeper1.AutoSize = true;
            this.labelGoalkeeper1.Location = new System.Drawing.Point(12, 19);
            this.labelGoalkeeper1.Name = "labelGoalkeeper1";
            this.labelGoalkeeper1.Size = new System.Drawing.Size(67, 20);
            this.labelGoalkeeper1.TabIndex = 2;
            this.labelGoalkeeper1.Text = "1. Kaleci:";
            // 
            // comboBoxGoalkeeper2
            // 
            this.comboBoxGoalkeeper2.BackColor = System.Drawing.Color.DarkCyan;
            this.comboBoxGoalkeeper2.FormattingEnabled = true;
            this.comboBoxGoalkeeper2.Location = new System.Drawing.Point(101, 75);
            this.comboBoxGoalkeeper2.Name = "comboBoxGoalkeeper2";
            this.comboBoxGoalkeeper2.Size = new System.Drawing.Size(121, 28);
            this.comboBoxGoalkeeper2.TabIndex = 1;
            this.comboBoxGoalkeeper2.SelectedIndexChanged += new System.EventHandler(this.comboBoxGoalkeepers_SelectedIndexChanged);
            this.comboBoxGoalkeeper2.Enter += new System.EventHandler(this.comboBoxGoalkeepers_Enter);
            // 
            // comboBoxGoalkeeper1
            // 
            this.comboBoxGoalkeeper1.BackColor = System.Drawing.Color.DarkCyan;
            this.comboBoxGoalkeeper1.FormattingEnabled = true;
            this.comboBoxGoalkeeper1.Location = new System.Drawing.Point(101, 16);
            this.comboBoxGoalkeeper1.Name = "comboBoxGoalkeeper1";
            this.comboBoxGoalkeeper1.Size = new System.Drawing.Size(121, 28);
            this.comboBoxGoalkeeper1.TabIndex = 0;
            this.comboBoxGoalkeeper1.SelectedIndexChanged += new System.EventHandler(this.comboBoxGoalkeepers_SelectedIndexChanged);
            this.comboBoxGoalkeeper1.Enter += new System.EventHandler(this.comboBoxGoalkeepers_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(9, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "(Çıkmak İçin Çift Tıklayınız)";
            // 
            // FormSelectGoalkeeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(238, 202);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.comboBoxGoalkeeper1);
            this.Controls.Add(this.labelGoalkeeper2);
            this.Controls.Add(this.comboBoxGoalkeeper2);
            this.Controls.Add(this.labelGoalkeeper1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSelectGoalkeeper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormSelectGoalkeeper";
            this.Load += new System.EventHandler(this.FormSelectGoalkeeper_Load);
            this.DoubleClick += new System.EventHandler(this.FormSelectGoalkeeper_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelGoalkeeper2;
        private System.Windows.Forms.Label labelGoalkeeper1;
        private System.Windows.Forms.ComboBox comboBoxGoalkeeper2;
        private System.Windows.Forms.ComboBox comboBoxGoalkeeper1;
        private System.Windows.Forms.Label label1;
    }
}