namespace Lesson_7___Event_planner
{
    partial class EventPlanner
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPlace = new System.Windows.Forms.TextBox();
            this.cbPriority = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPlace = new System.Windows.Forms.Label();
            this.lblPriority = new System.Windows.Forms.Label();
            this.dtpEvent = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.TaskList = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblToolTip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(77, 90);
            this.tbName.Margin = new System.Windows.Forms.Padding(0);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(340, 27);
            this.tbName.TabIndex = 0;
            this.tbName.Text = "Name";
            this.tbName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbName_MouseClick);
            // 
            // tbPlace
            // 
            this.tbPlace.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPlace.Location = new System.Drawing.Point(77, 154);
            this.tbPlace.Margin = new System.Windows.Forms.Padding(0);
            this.tbPlace.Multiline = true;
            this.tbPlace.Name = "tbPlace";
            this.tbPlace.Size = new System.Drawing.Size(340, 27);
            this.tbPlace.TabIndex = 1;
            this.tbPlace.Text = "Place";
            this.tbPlace.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbPlace_MouseClick);
            // 
            // cbPriority
            // 
            this.cbPriority.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPriority.FormattingEnabled = true;
            this.cbPriority.Items.AddRange(new object[] {
            "High",
            "Middle",
            "Low"});
            this.cbPriority.Location = new System.Drawing.Point(77, 214);
            this.cbPriority.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(340, 25);
            this.cbPriority.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(72, 64);
            this.lblName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(105, 17);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Enter name";
            // 
            // lblPlace
            // 
            this.lblPlace.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.lblPlace.AutoSize = true;
            this.lblPlace.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlace.Location = new System.Drawing.Point(72, 128);
            this.lblPlace.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(111, 17);
            this.lblPlace.TabIndex = 4;
            this.lblPlace.Text = "Enter place";
            // 
            // lblPriority
            // 
            this.lblPriority.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.lblPriority.AutoSize = true;
            this.lblPriority.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriority.Location = new System.Drawing.Point(72, 194);
            this.lblPriority.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(144, 17);
            this.lblPriority.TabIndex = 5;
            this.lblPriority.Text = "Choose priority";
            // 
            // dtpEvent
            // 
            this.dtpEvent.CalendarFont = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpEvent.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEvent.Location = new System.Drawing.Point(77, 269);
            this.dtpEvent.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.dtpEvent.MinDate = new System.DateTime(2020, 4, 26, 0, 0, 0, 0);
            this.dtpEvent.Name = "dtpEvent";
            this.dtpEvent.Size = new System.Drawing.Size(340, 24);
            this.dtpEvent.TabIndex = 6;
            // 
            // lblDate
            // 
            this.lblDate.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(74, 249);
            this.lblDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(117, 17);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Choose date";
            // 
            // TaskList
            // 
            this.TaskList.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskList.FormattingEnabled = true;
            this.TaskList.ItemHeight = 17;
            this.TaskList.Location = new System.Drawing.Point(517, 91);
            this.TaskList.Name = "TaskList";
            this.TaskList.Size = new System.Drawing.Size(301, 191);
            this.TaskList.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(104, 317);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 31);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(693, 317);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 31);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(268, 317);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(125, 31);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(517, 317);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(125, 31);
            this.btnLoad.TabIndex = 12;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // lblToolTip
            // 
            this.lblToolTip.AutoSize = true;
            this.lblToolTip.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToolTip.Location = new System.Drawing.Point(715, 297);
            this.lblToolTip.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblToolTip.Name = "lblToolTip";
            this.lblToolTip.Size = new System.Drawing.Size(81, 17);
            this.lblToolTip.TabIndex = 13;
            this.lblToolTip.Text = "(To XML)";
            // 
            // EventPlanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 399);
            this.Controls.Add(this.lblToolTip);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.TaskList);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpEvent);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.lblPlace);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cbPriority);
            this.Controls.Add(this.tbPlace);
            this.Controls.Add(this.tbName);
            this.Font = new System.Drawing.Font("BankGothic Lt BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "EventPlanner";
            this.Text = "Event planner";
            this.Load += new System.EventHandler(this.EventPlanner_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPlace;
        private System.Windows.Forms.ComboBox cbPriority;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPlace;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.DateTimePicker dtpEvent;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ListBox TaskList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblToolTip;
    }
}

