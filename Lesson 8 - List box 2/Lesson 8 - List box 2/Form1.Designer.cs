namespace Lesson_8___List_box_2
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
            this.lbProgLan = new System.Windows.Forms.ListBox();
            this.gbLang = new System.Windows.Forms.GroupBox();
            this.gbTextValue = new System.Windows.Forms.GroupBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPopularity = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPopularity = new System.Windows.Forms.Label();
            this.tbText = new System.Windows.Forms.TextBox();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbLang.SuspendLayout();
            this.gbTextValue.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbProgLan
            // 
            this.lbProgLan.FormattingEnabled = true;
            this.lbProgLan.Location = new System.Drawing.Point(12, 12);
            this.lbProgLan.Name = "lbProgLan";
            this.lbProgLan.Size = new System.Drawing.Size(248, 381);
            this.lbProgLan.TabIndex = 0;
            this.lbProgLan.SelectedIndexChanged += new System.EventHandler(this.lbProgLan_SelectedIndexChanged);
            // 
            // gbLang
            // 
            this.gbLang.Controls.Add(this.lblPopularity);
            this.gbLang.Controls.Add(this.lblName);
            this.gbLang.Controls.Add(this.tbPopularity);
            this.gbLang.Controls.Add(this.tbName);
            this.gbLang.Location = new System.Drawing.Point(284, 13);
            this.gbLang.Name = "gbLang";
            this.gbLang.Size = new System.Drawing.Size(287, 162);
            this.gbLang.TabIndex = 1;
            this.gbLang.TabStop = false;
            this.gbLang.Text = "Language";
            // 
            // gbTextValue
            // 
            this.gbTextValue.Controls.Add(this.lblValue);
            this.gbTextValue.Controls.Add(this.lblText);
            this.gbTextValue.Controls.Add(this.tbValue);
            this.gbTextValue.Controls.Add(this.tbText);
            this.gbTextValue.Location = new System.Drawing.Point(284, 235);
            this.gbTextValue.Name = "gbTextValue";
            this.gbTextValue.Size = new System.Drawing.Size(287, 158);
            this.gbTextValue.TabIndex = 2;
            this.gbTextValue.TabStop = false;
            this.gbTextValue.Text = "Info";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(6, 36);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(274, 20);
            this.tbName.TabIndex = 0;
            // 
            // tbPopularity
            // 
            this.tbPopularity.Location = new System.Drawing.Point(7, 93);
            this.tbPopularity.Name = "tbPopularity";
            this.tbPopularity.Size = new System.Drawing.Size(274, 20);
            this.tbPopularity.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(7, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // lblPopularity
            // 
            this.lblPopularity.AutoSize = true;
            this.lblPopularity.Location = new System.Drawing.Point(6, 77);
            this.lblPopularity.Name = "lblPopularity";
            this.lblPopularity.Size = new System.Drawing.Size(53, 13);
            this.lblPopularity.TabIndex = 3;
            this.lblPopularity.Text = "Popularity";
            // 
            // tbText
            // 
            this.tbText.Enabled = false;
            this.tbText.Location = new System.Drawing.Point(10, 35);
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(270, 20);
            this.tbText.TabIndex = 0;
            // 
            // tbValue
            // 
            this.tbValue.Enabled = false;
            this.tbValue.Location = new System.Drawing.Point(9, 101);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(270, 20);
            this.tbValue.TabIndex = 1;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(10, 20);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(28, 13);
            this.lblText.TabIndex = 2;
            this.lblText.Text = "Text";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(10, 85);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(34, 13);
            this.lblValue.TabIndex = 3;
            this.lblValue.Text = "Value";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(375, 197);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbTextValue);
            this.Controls.Add(this.gbLang);
            this.Controls.Add(this.lbProgLan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbLang.ResumeLayout(false);
            this.gbLang.PerformLayout();
            this.gbTextValue.ResumeLayout(false);
            this.gbTextValue.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbProgLan;
        private System.Windows.Forms.GroupBox gbLang;
        private System.Windows.Forms.Label lblPopularity;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbPopularity;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.GroupBox gbTextValue;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.Button btnAdd;
    }
}

