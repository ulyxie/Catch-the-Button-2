﻿
namespace Catch_the_button {
    partial class Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.Menu = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Label();
            this.stats = new System.Windows.Forms.Panel();
            this.milestone = new System.Windows.Forms.Label();
            this.timeleft = new System.Windows.Forms.Label();
            this.hp = new System.Windows.Forms.Label();
            this.ptsCount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ldrboard = new System.Windows.Forms.RichTextBox();
            this.highscore = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.quit = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.Menu.SuspendLayout();
            this.stats.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Menu.Controls.Add(this.label11);
            this.Menu.Controls.Add(this.label10);
            this.Menu.Controls.Add(this.label8);
            this.Menu.Controls.Add(this.label9);
            this.Menu.Controls.Add(this.button);
            this.Menu.Controls.Add(this.stats);
            this.Menu.Controls.Add(this.label7);
            this.Menu.Controls.Add(this.label2);
            this.Menu.Controls.Add(this.groupBox1);
            this.Menu.Controls.Add(this.title);
            this.Menu.Controls.Add(this.label6);
            this.Menu.Controls.Add(this.label5);
            this.Menu.Controls.Add(this.label4);
            this.Menu.Controls.Add(this.quit);
            this.Menu.Controls.Add(this.start);
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Margin = new System.Windows.Forms.Padding(4);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(961, 521);
            this.Menu.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 393);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 23);
            this.label11.TabIndex = 1005;
            this.label11.Text = "Miss: -1pt";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 370);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(252, 23);
            this.label10.TabIndex = 1004;
            this.label10.Text = "Click after 500ms: 1pt";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(241, 23);
            this.label8.TabIndex = 1;
            this.label8.Text = "Click in <500ms: 2pts";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 23);
            this.label9.TabIndex = 1003;
            this.label9.Text = "Points:";
            // 
            // button
            // 
            this.button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button.BackColor = System.Drawing.Color.LightGray;
            this.button.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button.Enabled = false;
            this.button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button.Location = new System.Drawing.Point(443, 241);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(50, 50);
            this.button.TabIndex = 6;
            this.button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button.Visible = false;
            this.button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.button.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // stats
            // 
            this.stats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stats.Controls.Add(this.milestone);
            this.stats.Controls.Add(this.timeleft);
            this.stats.Controls.Add(this.hp);
            this.stats.Controls.Add(this.ptsCount);
            this.stats.Location = new System.Drawing.Point(3, 3);
            this.stats.Name = "stats";
            this.stats.Size = new System.Drawing.Size(955, 30);
            this.stats.TabIndex = 1002;
            // 
            // milestone
            // 
            this.milestone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.milestone.AutoSize = true;
            this.milestone.Location = new System.Drawing.Point(569, 6);
            this.milestone.Name = "milestone";
            this.milestone.Size = new System.Drawing.Size(252, 23);
            this.milestone.TabIndex = 1002;
            this.milestone.Text = "Next Milestone in: ...";
            // 
            // timeleft
            // 
            this.timeleft.AutoSize = true;
            this.timeleft.Location = new System.Drawing.Point(-1, 5);
            this.timeleft.Name = "timeleft";
            this.timeleft.Size = new System.Drawing.Size(230, 23);
            this.timeleft.TabIndex = 7;
            this.timeleft.Text = "New Position in: ...";
            // 
            // hp
            // 
            this.hp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hp.AutoSize = true;
            this.hp.Location = new System.Drawing.Point(783, 6);
            this.hp.Name = "hp";
            this.hp.Size = new System.Drawing.Size(65, 23);
            this.hp.TabIndex = 1001;
            this.hp.Text = "HP: 3";
            // 
            // ptsCount
            // 
            this.ptsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptsCount.AutoSize = true;
            this.ptsCount.Location = new System.Drawing.Point(843, 6);
            this.ptsCount.Name = "ptsCount";
            this.ptsCount.Size = new System.Drawing.Size(109, 23);
            this.ptsCount.TabIndex = 0;
            this.ptsCount.Text = "Points: 0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(538, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 23);
            this.label7.TabIndex = 16;
            this.label7.Text = "budget Osu!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Click the buttons";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.highscore);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(743, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 398);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.ldrboard);
            this.groupBox2.Location = new System.Drawing.Point(0, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 333);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Leaderboard";
            // 
            // ldrboard
            // 
            this.ldrboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ldrboard.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ldrboard.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.ldrboard.Location = new System.Drawing.Point(0, 21);
            this.ldrboard.Name = "ldrboard";
            this.ldrboard.ReadOnly = true;
            this.ldrboard.Size = new System.Drawing.Size(216, 310);
            this.ldrboard.TabIndex = 5;
            this.ldrboard.TabStop = false;
            this.ldrboard.Text = "...";
            // 
            // highscore
            // 
            this.highscore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.highscore.AutoSize = true;
            this.highscore.Location = new System.Drawing.Point(6, 22);
            this.highscore.Name = "highscore";
            this.highscore.Size = new System.Drawing.Size(98, 23);
            this.highscore.TabIndex = 8;
            this.highscore.Text = "No Entry";
            this.highscore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, -2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Highscore";
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Consolas", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(302, 98);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(440, 56);
            this.title.TabIndex = 0;
            this.title.Text = "Catch the Button";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 127.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(388, 16);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(223, 251);
            this.label6.TabIndex = 11;
            this.label6.Text = "2";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 477);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(263, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "ESC - quit to main menu";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 441);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Controls:";
            // 
            // quit
            // 
            this.quit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quit.Location = new System.Drawing.Point(378, 432);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(214, 41);
            this.quit.TabIndex = 4;
            this.quit.Text = "Quit";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // start
            // 
            this.start.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.start.Location = new System.Drawing.Point(338, 362);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(290, 64);
            this.start.TabIndex = 3;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 520);
            this.Controls.Add(this.Menu);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(981, 567);
            this.MinimumSize = new System.Drawing.Size(981, 567);
            this.Name = "Main";
            this.Text = "Catch the Button 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.stats.ResumeLayout(false);
            this.stats.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.Button start;
        internal System.Windows.Forms.Label hp;
        internal System.Windows.Forms.Label ptsCount;
        private System.Windows.Forms.Label button;
        private System.Windows.Forms.RichTextBox ldrboard;
        private System.Windows.Forms.Label timeleft;
        private System.Windows.Forms.Label highscore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel stats;
        internal System.Windows.Forms.Label milestone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

