﻿namespace FamilySprout.Features.Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnFamilies = new System.Windows.Forms.Button();
            this.btnTrash = new System.Windows.Forms.Button();
            this.btnNewFamily = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panelNavigation.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNavigation
            // 
            this.panelNavigation.BackColor = System.Drawing.Color.White;
            this.panelNavigation.Controls.Add(this.btnUsers);
            this.panelNavigation.Controls.Add(this.btnFamilies);
            this.panelNavigation.Controls.Add(this.btnTrash);
            this.panelNavigation.Controls.Add(this.btnNewFamily);
            this.panelNavigation.Controls.Add(this.btnDashboard);
            this.panelNavigation.Controls.Add(this.btnLogout);
            this.panelNavigation.Controls.Add(this.panelLogo);
            this.panelNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNavigation.Location = new System.Drawing.Point(0, 0);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(217, 648);
            this.panelNavigation.TabIndex = 6;
            // 
            // btnUsers
            // 
            this.btnUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUsers.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.Purple;
            this.btnUsers.Location = new System.Drawing.Point(9, 301);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(0);
            this.btnUsers.MaximumSize = new System.Drawing.Size(200, 68);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(200, 60);
            this.btnUsers.TabIndex = 4;
            this.btnUsers.Text = "USERS";
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnFamilies
            // 
            this.btnFamilies.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFamilies.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnFamilies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFamilies.FlatAppearance.BorderSize = 0;
            this.btnFamilies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFamilies.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFamilies.ForeColor = System.Drawing.Color.Purple;
            this.btnFamilies.Location = new System.Drawing.Point(9, 150);
            this.btnFamilies.Margin = new System.Windows.Forms.Padding(0);
            this.btnFamilies.MaximumSize = new System.Drawing.Size(200, 68);
            this.btnFamilies.Name = "btnFamilies";
            this.btnFamilies.Size = new System.Drawing.Size(200, 60);
            this.btnFamilies.TabIndex = 2;
            this.btnFamilies.Text = "FAMILIES";
            this.btnFamilies.UseVisualStyleBackColor = false;
            this.btnFamilies.Click += new System.EventHandler(this.btnFamilies_Click);
            // 
            // btnTrash
            // 
            this.btnTrash.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTrash.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTrash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrash.FlatAppearance.BorderSize = 0;
            this.btnTrash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrash.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrash.ForeColor = System.Drawing.Color.Purple;
            this.btnTrash.Location = new System.Drawing.Point(9, 376);
            this.btnTrash.Margin = new System.Windows.Forms.Padding(0);
            this.btnTrash.MaximumSize = new System.Drawing.Size(200, 68);
            this.btnTrash.Name = "btnTrash";
            this.btnTrash.Size = new System.Drawing.Size(200, 60);
            this.btnTrash.TabIndex = 5;
            this.btnTrash.Text = "TRASH";
            this.btnTrash.UseVisualStyleBackColor = false;
            this.btnTrash.Click += new System.EventHandler(this.btnTrash_Click);
            // 
            // btnNewFamily
            // 
            this.btnNewFamily.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewFamily.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNewFamily.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewFamily.FlatAppearance.BorderSize = 0;
            this.btnNewFamily.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewFamily.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewFamily.ForeColor = System.Drawing.Color.Purple;
            this.btnNewFamily.Location = new System.Drawing.Point(9, 224);
            this.btnNewFamily.Margin = new System.Windows.Forms.Padding(0);
            this.btnNewFamily.MaximumSize = new System.Drawing.Size(200, 68);
            this.btnNewFamily.Name = "btnNewFamily";
            this.btnNewFamily.Size = new System.Drawing.Size(200, 60);
            this.btnNewFamily.TabIndex = 3;
            this.btnNewFamily.Text = "NEW FAMILY";
            this.btnNewFamily.UseVisualStyleBackColor = false;
            this.btnNewFamily.Click += new System.EventHandler(this.btnNewFamily_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDashboard.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.Purple;
            this.btnDashboard.Location = new System.Drawing.Point(9, 80);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.btnDashboard.MaximumSize = new System.Drawing.Size(200, 68);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(200, 60);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "DASHBOARD";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Purple;
            this.btnLogout.Location = new System.Drawing.Point(9, 579);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogout.MaximumSize = new System.Drawing.Size(200, 68);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 60);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(54)))), ((int)(((byte)(220)))));
            this.panelLogo.Controls.Add(this.lblLogo);
            this.panelLogo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(217, 68);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLogo_MouseDown);
            this.panelLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelLogo_MouseMove);
            this.panelLogo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelLogo_MouseUp);
            // 
            // lblLogo
            // 
            this.lblLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblLogo.Location = new System.Drawing.Point(32, 21);
            this.lblLogo.Margin = new System.Windows.Forms.Padding(0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(194, 27);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "FAMILY-SPROUT";
            this.lblLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblLogo_MouseDown);
            this.lblLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblLogo_MouseMove);
            this.lblLogo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblLogo_MouseUp);
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(217, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(905, 648);
            this.mainPanel.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 648);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panelNavigation);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Purple;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Family Sprout";
            this.panelNavigation.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnFamilies;
        private System.Windows.Forms.Button btnTrash;
        private System.Windows.Forms.Button btnNewFamily;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Panel mainPanel;
    }
}