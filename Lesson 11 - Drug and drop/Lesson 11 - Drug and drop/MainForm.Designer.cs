namespace Lesson_11___Drug_and_drop
{
    partial class MainForm
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
            this.lbRed = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.lbDestination = new System.Windows.Forms.ListBox();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbRed
            // 
            this.lbRed.AutoSize = true;
            this.lbRed.Location = new System.Drawing.Point(30, 39);
            this.lbRed.Name = "lbRed";
            this.lbRed.Size = new System.Drawing.Size(67, 13);
            this.lbRed.TabIndex = 0;
            this.lbRed.Text = "Text for drug";
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(388, 55);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(73, 13);
            this.lbResult.TabIndex = 1;
            this.lbResult.Text = "Result of drug";
            // 
            // lbDestination
            // 
            this.lbDestination.AllowDrop = true;
            this.lbDestination.FormattingEnabled = true;
            this.lbDestination.Location = new System.Drawing.Point(329, 128);
            this.lbDestination.Name = "lbDestination";
            this.lbDestination.Size = new System.Drawing.Size(187, 186);
            this.lbDestination.TabIndex = 2;
            this.lbDestination.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbDestination_DragDrop);
            this.lbDestination.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbDestination_DragEnter);
            this.lbDestination.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbDestination_MouseDown);
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(33, 128);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(209, 20);
            this.tbMessage.TabIndex = 3;
            this.tbMessage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbMessage_MouseDown);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Only",
            "Get",
            "Check"});
            this.comboBox1.Location = new System.Drawing.Point(33, 193);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(209, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 434);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.lbDestination);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.lbRed);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.MainForm_DragOver);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRed;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.ListBox lbDestination;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

