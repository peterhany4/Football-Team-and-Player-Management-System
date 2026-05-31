namespace App
{
    partial class mainForm
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
            this.mainHeadline = new System.Windows.Forms.Label();
            this.add_edit_teamBtn = new System.Windows.Forms.Button();
            this.viewTeamsBtn = new System.Windows.Forms.Button();
            this.filterBtn = new System.Windows.Forms.Button();
            this.add_edit_playerBtn = new System.Windows.Forms.Button();
            this.sortPlayersBtn = new System.Windows.Forms.Button();
            this.sortTeamsbtn = new System.Windows.Forms.Button();
            this.helpForm = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainHeadline
            // 
            this.mainHeadline.AutoSize = true;
            this.mainHeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainHeadline.Location = new System.Drawing.Point(68, 50);
            this.mainHeadline.Name = "mainHeadline";
            this.mainHeadline.Size = new System.Drawing.Size(655, 32);
            this.mainHeadline.TabIndex = 0;
            this.mainHeadline.Text = "Football Team and Player Management System";
            // 
            // add_edit_teamBtn
            // 
            this.add_edit_teamBtn.AutoSize = true;
            this.add_edit_teamBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_edit_teamBtn.Location = new System.Drawing.Point(88, 161);
            this.add_edit_teamBtn.Name = "add_edit_teamBtn";
            this.add_edit_teamBtn.Size = new System.Drawing.Size(193, 44);
            this.add_edit_teamBtn.TabIndex = 1;
            this.add_edit_teamBtn.Text = "Add / Edit Team";
            this.add_edit_teamBtn.UseVisualStyleBackColor = true;
            this.add_edit_teamBtn.Click += new System.EventHandler(this.add_edit_teamBtn_Click);
            // 
            // viewTeamsBtn
            // 
            this.viewTeamsBtn.AutoSize = true;
            this.viewTeamsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewTeamsBtn.Location = new System.Drawing.Point(540, 161);
            this.viewTeamsBtn.Name = "viewTeamsBtn";
            this.viewTeamsBtn.Size = new System.Drawing.Size(155, 44);
            this.viewTeamsBtn.TabIndex = 2;
            this.viewTeamsBtn.Text = "View Teams";
            this.viewTeamsBtn.UseVisualStyleBackColor = true;
            this.viewTeamsBtn.Click += new System.EventHandler(this.viewTeamsForm_Click);
            // 
            // filterBtn
            // 
            this.filterBtn.AutoSize = true;
            this.filterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterBtn.Location = new System.Drawing.Point(540, 247);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(163, 44);
            this.filterBtn.TabIndex = 4;
            this.filterBtn.Text = "Filter Players";
            this.filterBtn.UseVisualStyleBackColor = true;
            this.filterBtn.Click += new System.EventHandler(this.filterBtn_Click);
            // 
            // add_edit_playerBtn
            // 
            this.add_edit_playerBtn.AutoSize = true;
            this.add_edit_playerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_edit_playerBtn.Location = new System.Drawing.Point(88, 247);
            this.add_edit_playerBtn.Name = "add_edit_playerBtn";
            this.add_edit_playerBtn.Size = new System.Drawing.Size(202, 44);
            this.add_edit_playerBtn.TabIndex = 3;
            this.add_edit_playerBtn.Text = "Add / Edit Player";
            this.add_edit_playerBtn.UseVisualStyleBackColor = true;
            this.add_edit_playerBtn.Click += new System.EventHandler(this.add_edit_playerBtn_Click);
            // 
            // sortPlayersBtn
            // 
            this.sortPlayersBtn.AutoSize = true;
            this.sortPlayersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortPlayersBtn.Location = new System.Drawing.Point(332, 247);
            this.sortPlayersBtn.Name = "sortPlayersBtn";
            this.sortPlayersBtn.Size = new System.Drawing.Size(155, 44);
            this.sortPlayersBtn.TabIndex = 6;
            this.sortPlayersBtn.Text = "Sort Players";
            this.sortPlayersBtn.UseVisualStyleBackColor = true;
            this.sortPlayersBtn.Click += new System.EventHandler(this.sortPlayersBtn_Click);
            // 
            // sortTeamsbtn
            // 
            this.sortTeamsbtn.AutoSize = true;
            this.sortTeamsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortTeamsbtn.Location = new System.Drawing.Point(332, 161);
            this.sortTeamsbtn.Name = "sortTeamsbtn";
            this.sortTeamsbtn.Size = new System.Drawing.Size(155, 44);
            this.sortTeamsbtn.TabIndex = 5;
            this.sortTeamsbtn.Text = "Sort Teams";
            this.sortTeamsbtn.UseVisualStyleBackColor = true;
            this.sortTeamsbtn.Click += new System.EventHandler(this.sortTeamsForm_Click);
            // 
            // helpForm
            // 
            this.helpForm.AutoSize = true;
            this.helpForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpForm.Location = new System.Drawing.Point(232, 330);
            this.helpForm.Name = "helpForm";
            this.helpForm.Size = new System.Drawing.Size(155, 44);
            this.helpForm.TabIndex = 7;
            this.helpForm.Text = "Help?";
            this.helpForm.UseVisualStyleBackColor = true;
            this.helpForm.Click += new System.EventHandler(this.helpForm_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.AutoSize = true;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(442, 330);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(155, 44);
            this.exitBtn.TabIndex = 8;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.helpForm);
            this.Controls.Add(this.sortPlayersBtn);
            this.Controls.Add(this.sortTeamsbtn);
            this.Controls.Add(this.filterBtn);
            this.Controls.Add(this.add_edit_playerBtn);
            this.Controls.Add(this.viewTeamsBtn);
            this.Controls.Add(this.add_edit_teamBtn);
            this.Controls.Add(this.mainHeadline);
            this.Name = "mainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainHeadline;
        private System.Windows.Forms.Button add_edit_teamBtn;
        private System.Windows.Forms.Button viewTeamsBtn;
        private System.Windows.Forms.Button filterBtn;
        private System.Windows.Forms.Button add_edit_playerBtn;
        private System.Windows.Forms.Button sortPlayersBtn;
        private System.Windows.Forms.Button sortTeamsbtn;
        private System.Windows.Forms.Button helpForm;
        private System.Windows.Forms.Button exitBtn;
    }
}

