namespace HT___TeamsView
{
    partial class Teams
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
            this.lbTeam1 = new System.Windows.Forms.ListBox();
            this.lbDraft = new System.Windows.Forms.ListBox();
            this.lbTeam2 = new System.Windows.Forms.ListBox();
            this.lbTeamView = new System.Windows.Forms.ListBox();
            this.btnAddFirst = new System.Windows.Forms.Button();
            this.btnAddSecond = new System.Windows.Forms.Button();
            this.btnFirstSave = new System.Windows.Forms.Button();
            this.btnSecondSave = new System.Windows.Forms.Button();
            this.dupPlayerCount = new System.Windows.Forms.DomainUpDown();
            this.dupTeamView = new System.Windows.Forms.DomainUpDown();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblTeamView = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTeam1
            // 
            this.lbTeam1.FormattingEnabled = true;
            this.lbTeam1.Location = new System.Drawing.Point(33, 52);
            this.lbTeam1.Name = "lbTeam1";
            this.lbTeam1.Size = new System.Drawing.Size(181, 173);
            this.lbTeam1.TabIndex = 0;
            // 
            // lbDraft
            // 
            this.lbDraft.FormattingEnabled = true;
            this.lbDraft.Location = new System.Drawing.Point(321, 52);
            this.lbDraft.Name = "lbDraft";
            this.lbDraft.Size = new System.Drawing.Size(181, 173);
            this.lbDraft.TabIndex = 1;
            // 
            // lbTeam2
            // 
            this.lbTeam2.FormattingEnabled = true;
            this.lbTeam2.Location = new System.Drawing.Point(607, 52);
            this.lbTeam2.Name = "lbTeam2";
            this.lbTeam2.Size = new System.Drawing.Size(181, 173);
            this.lbTeam2.TabIndex = 2;
            // 
            // lbTeamView
            // 
            this.lbTeamView.FormattingEnabled = true;
            this.lbTeamView.Location = new System.Drawing.Point(33, 281);
            this.lbTeamView.Name = "lbTeamView";
            this.lbTeamView.Size = new System.Drawing.Size(181, 121);
            this.lbTeamView.TabIndex = 3;
            // 
            // btnAddFirst
            // 
            this.btnAddFirst.Location = new System.Drawing.Point(229, 133);
            this.btnAddFirst.Name = "btnAddFirst";
            this.btnAddFirst.Size = new System.Drawing.Size(75, 50);
            this.btnAddFirst.TabIndex = 4;
            this.btnAddFirst.Text = "Add to first team";
            this.btnAddFirst.UseVisualStyleBackColor = true;
            this.btnAddFirst.Click += new System.EventHandler(this.btnAddFirst_Click);
            // 
            // btnAddSecond
            // 
            this.btnAddSecond.Location = new System.Drawing.Point(517, 133);
            this.btnAddSecond.Name = "btnAddSecond";
            this.btnAddSecond.Size = new System.Drawing.Size(75, 50);
            this.btnAddSecond.TabIndex = 5;
            this.btnAddSecond.Text = "Add to second team";
            this.btnAddSecond.UseVisualStyleBackColor = true;
            this.btnAddSecond.Click += new System.EventHandler(this.btnAddSecond_Click);
            // 
            // btnFirstSave
            // 
            this.btnFirstSave.Location = new System.Drawing.Point(33, 242);
            this.btnFirstSave.Name = "btnFirstSave";
            this.btnFirstSave.Size = new System.Drawing.Size(181, 23);
            this.btnFirstSave.TabIndex = 6;
            this.btnFirstSave.Text = "Save team to file";
            this.btnFirstSave.UseVisualStyleBackColor = true;
            this.btnFirstSave.Click += new System.EventHandler(this.btnFirstSave_Click);
            // 
            // btnSecondSave
            // 
            this.btnSecondSave.Location = new System.Drawing.Point(607, 242);
            this.btnSecondSave.Name = "btnSecondSave";
            this.btnSecondSave.Size = new System.Drawing.Size(181, 23);
            this.btnSecondSave.TabIndex = 7;
            this.btnSecondSave.Text = "Save team to file";
            this.btnSecondSave.UseVisualStyleBackColor = true;
            this.btnSecondSave.Click += new System.EventHandler(this.btnSecondSave_Click);
            // 
            // dupPlayerCount
            // 
            this.dupPlayerCount.Items.Add("1");
            this.dupPlayerCount.Items.Add("2");
            this.dupPlayerCount.Items.Add("3");
            this.dupPlayerCount.Items.Add("4");
            this.dupPlayerCount.Items.Add("5");
            this.dupPlayerCount.Location = new System.Drawing.Point(321, 244);
            this.dupPlayerCount.Name = "dupPlayerCount";
            this.dupPlayerCount.Size = new System.Drawing.Size(181, 20);
            this.dupPlayerCount.TabIndex = 8;
            this.dupPlayerCount.Text = "0";
            this.dupPlayerCount.SelectedItemChanged += new System.EventHandler(this.dupPlayerCount_SelectedItemChanged);
            // 
            // dupTeamView
            // 
            this.dupTeamView.Items.Add("1");
            this.dupTeamView.Items.Add("2");
            this.dupTeamView.Location = new System.Drawing.Point(321, 330);
            this.dupTeamView.Name = "dupTeamView";
            this.dupTeamView.Size = new System.Drawing.Size(181, 20);
            this.dupTeamView.TabIndex = 9;
            this.dupTeamView.Text = "Team";
            this.dupTeamView.SelectedItemChanged += new System.EventHandler(this.dupTeamView_SelectedItemChanged);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(321, 271);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(120, 13);
            this.lblCount.TabIndex = 10;
            this.lblCount.Text = "Count of players in team";
            // 
            // lblTeamView
            // 
            this.lblTeamView.AutoSize = true;
            this.lblTeamView.Location = new System.Drawing.Point(321, 353);
            this.lblTeamView.Name = "lblTeamView";
            this.lblTeamView.Size = new System.Drawing.Size(71, 13);
            this.lblTeamView.TabIndex = 11;
            this.lblTeamView.Text = "Index of team";
            // 
            // Teams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTeamView);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.dupTeamView);
            this.Controls.Add(this.dupPlayerCount);
            this.Controls.Add(this.btnSecondSave);
            this.Controls.Add(this.btnFirstSave);
            this.Controls.Add(this.btnAddSecond);
            this.Controls.Add(this.btnAddFirst);
            this.Controls.Add(this.lbTeamView);
            this.Controls.Add(this.lbTeam2);
            this.Controls.Add(this.lbDraft);
            this.Controls.Add(this.lbTeam1);
            this.Name = "Teams";
            this.Text = "Teams";
            this.Load += new System.EventHandler(this.Teams_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbTeam1;
        private System.Windows.Forms.ListBox lbDraft;
        private System.Windows.Forms.ListBox lbTeam2;
        private System.Windows.Forms.ListBox lbTeamView;
        private System.Windows.Forms.Button btnAddFirst;
        private System.Windows.Forms.Button btnAddSecond;
        private System.Windows.Forms.Button btnFirstSave;
        private System.Windows.Forms.Button btnSecondSave;
        private System.Windows.Forms.DomainUpDown dupPlayerCount;
        private System.Windows.Forms.DomainUpDown dupTeamView;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblTeamView;
    }
}

