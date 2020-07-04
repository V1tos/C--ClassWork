namespace Lesson_4___Checked_list_box
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelSelected = new System.Windows.Forms.Label();
            this.buttonDel = new System.Windows.Forms.Button();
            this.tbDelete = new System.Windows.Forms.TextBox();
            this.srBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "One",
            "Two",
            "Three",
            "Four",
            "Five"});
            this.checkedListBox1.Location = new System.Drawing.Point(105, 105);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(218, 169);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(429, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 127);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New element";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 20);
            this.textBox1.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(90, 76);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelSelected
            // 
            this.labelSelected.AutoSize = true;
            this.labelSelected.Location = new System.Drawing.Point(436, 313);
            this.labelSelected.Name = "labelSelected";
            this.labelSelected.Size = new System.Drawing.Size(35, 13);
            this.labelSelected.TabIndex = 2;
            this.labelSelected.Text = "label1";
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(105, 293);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 23);
            this.buttonDel.TabIndex = 2;
            this.buttonDel.Text = "Delete";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // tbDelete
            // 
            this.tbDelete.Location = new System.Drawing.Point(105, 390);
            this.tbDelete.Name = "tbDelete";
            this.tbDelete.Size = new System.Drawing.Size(185, 20);
            this.tbDelete.TabIndex = 3;
            this.tbDelete.Visible = false;
            this.tbDelete.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbDelete_KeyDown);
            // 
            // srBtn
            // 
            this.srBtn.Location = new System.Drawing.Point(105, 340);
            this.srBtn.Name = "srBtn";
            this.srBtn.Size = new System.Drawing.Size(152, 23);
            this.srBtn.TabIndex = 4;
            this.srBtn.Text = "Search and Remove";
            this.srBtn.UseVisualStyleBackColor = true;
            this.srBtn.Click += new System.EventHandler(this.srBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.srBtn);
            this.Controls.Add(this.tbDelete);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.labelSelected);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkedListBox1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelSelected;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.TextBox tbDelete;
        private System.Windows.Forms.Button srBtn;
    }
}

