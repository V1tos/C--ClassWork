namespace Lesson_6___Combo_box
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
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.clbType = new System.Windows.Forms.CheckedListBox();
            this.lbManufacture = new System.Windows.Forms.ListBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cbColor
            // 
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Location = new System.Drawing.Point(37, 64);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(166, 21);
            this.cbColor.TabIndex = 0;
            this.toolTip1.SetToolTip(this.cbColor, "Enter color");
            this.cbColor.SelectedIndexChanged += new System.EventHandler(this.cbColor_SelectedIndexChanged);
            // 
            // lblColor
            // 
            this.lblColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblColor.Location = new System.Drawing.Point(37, 13);
            this.lblColor.Name = "lblColor";
            this.lblColor.Padding = new System.Windows.Forms.Padding(10);
            this.lblColor.Size = new System.Drawing.Size(166, 48);
            this.lblColor.TabIndex = 1;
            this.lblColor.Text = "label1";
            this.toolTip1.SetToolTip(this.lblColor, "Example of color");
            // 
            // clbType
            // 
            this.clbType.CheckOnClick = true;
            this.clbType.FormattingEnabled = true;
            this.clbType.Location = new System.Drawing.Point(37, 131);
            this.clbType.Name = "clbType";
            this.clbType.Size = new System.Drawing.Size(166, 109);
            this.clbType.TabIndex = 2;
            // 
            // lbManufacture
            // 
            this.lbManufacture.FormattingEnabled = true;
            this.lbManufacture.Location = new System.Drawing.Point(268, 13);
            this.lbManufacture.Name = "lbManufacture";
            this.lbManufacture.Size = new System.Drawing.Size(230, 108);
            this.lbManufacture.TabIndex = 3;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(59, 297);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(125, 23);
            this.btnEnter.TabIndex = 4;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(59, 346);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(125, 23);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // lbResult
            // 
            this.lbResult.FormattingEnabled = true;
            this.lbResult.Location = new System.Drawing.Point(268, 132);
            this.lbResult.Name = "lbResult";
            this.lbResult.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbResult.Size = new System.Drawing.Size(320, 264);
            this.lbResult.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 450);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lbManufacture);
            this.Controls.Add(this.clbType);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.cbColor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckedListBox clbType;
        private System.Windows.Forms.ListBox lbManufacture;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.ListBox lbResult;
    }
}

