namespace Lesson_13___Data_grid_view
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Availiable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.cbAvailiable = new System.Windows.Forms.CheckBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbBrend = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tbCapacity = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Author,
            this.Title,
            this.Availiable});
            this.dataGridView1.Location = new System.Drawing.Point(13, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(341, 165);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Author
            // 
            this.Author.HeaderText = "Author";
            this.Author.Name = "Author";
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            // 
            // Availiable
            // 
            this.Availiable.HeaderText = "Availiable";
            this.Availiable.Name = "Availiable";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 492);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(750, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // tbAuthor
            // 
            this.tbAuthor.Location = new System.Drawing.Point(18, 194);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.Size = new System.Drawing.Size(177, 20);
            this.tbAuthor.TabIndex = 2;
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(201, 194);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(177, 20);
            this.tbTitle.TabIndex = 3;
            // 
            // cbAvailiable
            // 
            this.cbAvailiable.AutoSize = true;
            this.cbAvailiable.Location = new System.Drawing.Point(403, 195);
            this.cbAvailiable.Name = "cbAvailiable";
            this.cbAvailiable.Size = new System.Drawing.Size(80, 17);
            this.cbAvailiable.TabIndex = 4;
            this.cbAvailiable.Text = "checkBox1";
            this.cbAvailiable.UseVisualStyleBackColor = true;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(191, 446);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(177, 20);
            this.tbModel.TabIndex = 6;
            // 
            // tbBrend
            // 
            this.tbBrend.Location = new System.Drawing.Point(8, 446);
            this.tbBrend.Name = "tbBrend";
            this.tbBrend.Size = new System.Drawing.Size(177, 20);
            this.tbBrend.TabIndex = 5;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(13, 233);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(355, 207);
            this.dataGridView2.TabIndex = 8;
            // 
            // tbCapacity
            // 
            this.tbCapacity.Location = new System.Drawing.Point(374, 446);
            this.tbCapacity.Name = "tbCapacity";
            this.tbCapacity.Size = new System.Drawing.Size(177, 20);
            this.tbCapacity.TabIndex = 9;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(491, 33);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(240, 150);
            this.dataGridView3.TabIndex = 10;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(489, 195);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(62, 20);
            this.tbID.TabIndex = 11;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(557, 195);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(106, 20);
            this.tbName.TabIndex = 12;
            // 
            // tbSalary
            // 
            this.tbSalary.Location = new System.Drawing.Point(669, 195);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(62, 20);
            this.tbSalary.TabIndex = 13;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(541, 221);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(122, 23);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add employee";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 514);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbSalary);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.tbCapacity);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.tbBrend);
            this.Controls.Add(this.cbAvailiable);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.tbAuthor);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Availiable;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.TextBox tbAuthor;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.CheckBox cbAvailiable;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.TextBox tbBrend;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox tbCapacity;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSalary;
        private System.Windows.Forms.Button btnAdd;
    }
}

