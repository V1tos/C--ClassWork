namespace Lesson_1___Checkboxes
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkAgree = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkBox1.Location = new System.Drawing.Point(52, 30);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(137, 74);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Maybe yes";
            this.checkBox1.ThreeState = true;
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkBox2.Location = new System.Drawing.Point(52, 119);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(137, 74);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Yes";
            this.checkBox2.ThreeState = true;
            this.checkBox2.UseVisualStyleBackColor = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkBox3.Location = new System.Drawing.Point(52, 208);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(137, 74);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "No";
            this.checkBox3.ThreeState = true;
            this.checkBox3.UseVisualStyleBackColor = false;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(52, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 49);
            this.button1.TabIndex = 3;
            this.button1.Text = "Click";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(290, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 107);
            this.label1.TabIndex = 4;
            // 
            // checkAgree
            // 
            this.checkAgree.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.checkAgree.Location = new System.Drawing.Point(327, 208);
            this.checkAgree.Name = "checkAgree";
            this.checkAgree.Size = new System.Drawing.Size(183, 63);
            this.checkAgree.TabIndex = 5;
            this.checkAgree.Text = "Check me";
            this.checkAgree.UseVisualStyleBackColor = false;
            this.checkAgree.CheckedChanged += new System.EventHandler(this.checkAgree_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkAgree);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkAgree;
    }
}

