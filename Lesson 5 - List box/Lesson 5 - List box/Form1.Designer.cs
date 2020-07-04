namespace Lesson_5___List_box
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
            this.lbElements = new System.Windows.Forms.ListBox();
            this.tbNew = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.lblSelected = new System.Windows.Forms.Label();
            this.radioOne = new System.Windows.Forms.RadioButton();
            this.radioSimple = new System.Windows.Forms.RadioButton();
            this.radioExtended = new System.Windows.Forms.RadioButton();
            this.stateBox = new System.Windows.Forms.GroupBox();
            this.manyColBox = new System.Windows.Forms.CheckBox();
            this.stateBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbElements
            // 
            this.lbElements.FormattingEnabled = true;
            this.lbElements.Location = new System.Drawing.Point(48, 58);
            this.lbElements.Name = "lbElements";
            this.lbElements.Size = new System.Drawing.Size(169, 173);
            this.lbElements.TabIndex = 0;
            this.lbElements.SelectedIndexChanged += new System.EventHandler(this.lbElements_SelectedIndexChanged);
            // 
            // tbNew
            // 
            this.tbNew.Location = new System.Drawing.Point(347, 81);
            this.tbNew.Name = "tbNew";
            this.tbNew.Size = new System.Drawing.Size(229, 20);
            this.tbNew.TabIndex = 1;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(406, 157);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(120, 23);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(406, 301);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(120, 23);
            this.delBtn.TabIndex = 3;
            this.delBtn.Text = "Delete";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.Location = new System.Drawing.Point(347, 217);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(35, 13);
            this.lblSelected.TabIndex = 4;
            this.lblSelected.Text = "label1";
            // 
            // radioOne
            // 
            this.radioOne.AutoSize = true;
            this.radioOne.Checked = true;
            this.radioOne.Location = new System.Drawing.Point(0, 23);
            this.radioOne.Name = "radioOne";
            this.radioOne.Size = new System.Drawing.Size(45, 17);
            this.radioOne.TabIndex = 5;
            this.radioOne.TabStop = true;
            this.radioOne.Text = "One";
            this.radioOne.UseVisualStyleBackColor = true;
            this.radioOne.CheckedChanged += new System.EventHandler(this.radioOne_CheckedChanged);
            // 
            // radioSimple
            // 
            this.radioSimple.AutoSize = true;
            this.radioSimple.Location = new System.Drawing.Point(0, 46);
            this.radioSimple.Name = "radioSimple";
            this.radioSimple.Size = new System.Drawing.Size(56, 17);
            this.radioSimple.TabIndex = 6;
            this.radioSimple.TabStop = true;
            this.radioSimple.Text = "Simple";
            this.radioSimple.UseVisualStyleBackColor = true;
            this.radioSimple.CheckedChanged += new System.EventHandler(this.radioOne_CheckedChanged);
            // 
            // radioExtended
            // 
            this.radioExtended.AutoSize = true;
            this.radioExtended.Location = new System.Drawing.Point(0, 69);
            this.radioExtended.Name = "radioExtended";
            this.radioExtended.Size = new System.Drawing.Size(70, 17);
            this.radioExtended.TabIndex = 7;
            this.radioExtended.TabStop = true;
            this.radioExtended.Text = "Extended";
            this.radioExtended.UseVisualStyleBackColor = true;
            this.radioExtended.CheckedChanged += new System.EventHandler(this.radioOne_CheckedChanged);
            // 
            // stateBox
            // 
            this.stateBox.Controls.Add(this.radioSimple);
            this.stateBox.Controls.Add(this.radioExtended);
            this.stateBox.Controls.Add(this.radioOne);
            this.stateBox.Location = new System.Drawing.Point(48, 288);
            this.stateBox.Name = "stateBox";
            this.stateBox.Size = new System.Drawing.Size(200, 100);
            this.stateBox.TabIndex = 8;
            this.stateBox.TabStop = false;
            this.stateBox.Text = "State";
            // 
            // manyColBox
            // 
            this.manyColBox.AutoSize = true;
            this.manyColBox.Location = new System.Drawing.Point(48, 410);
            this.manyColBox.Name = "manyColBox";
            this.manyColBox.Size = new System.Drawing.Size(94, 17);
            this.manyColBox.TabIndex = 9;
            this.manyColBox.Text = "Many columns";
            this.manyColBox.UseVisualStyleBackColor = true;
            this.manyColBox.CheckedChanged += new System.EventHandler(this.manyColBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.manyColBox);
            this.Controls.Add(this.stateBox);
            this.Controls.Add(this.lblSelected);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.tbNew);
            this.Controls.Add(this.lbElements);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.stateBox.ResumeLayout(false);
            this.stateBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbElements;
        private System.Windows.Forms.TextBox tbNew;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.RadioButton radioOne;
        private System.Windows.Forms.RadioButton radioSimple;
        private System.Windows.Forms.RadioButton radioExtended;
        private System.Windows.Forms.GroupBox stateBox;
        private System.Windows.Forms.CheckBox manyColBox;
    }
}

