namespace Tic_tac_toe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.playerVsPlayerButton = new System.Windows.Forms.Button();
            this.playerVsCpuButton = new System.Windows.Forms.Button();
            this.groupBoxGame = new System.Windows.Forms.GroupBox();
            this.p8 = new System.Windows.Forms.PictureBox();
            this.p7 = new System.Windows.Forms.PictureBox();
            this.p6 = new System.Windows.Forms.PictureBox();
            this.p5 = new System.Windows.Forms.PictureBox();
            this.p4 = new System.Windows.Forms.PictureBox();
            this.p3 = new System.Windows.Forms.PictureBox();
            this.p2 = new System.Windows.Forms.PictureBox();
            this.p1 = new System.Windows.Forms.PictureBox();
            this.p0 = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            this.groupBoxMenu = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.playerVsCpuHard = new System.Windows.Forms.Button();
            this.groupBoxGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p0)).BeginInit();
            this.groupBoxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // playerVsPlayerButton
            // 
            this.playerVsPlayerButton.BackColor = System.Drawing.Color.Orange;
            this.playerVsPlayerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.playerVsPlayerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerVsPlayerButton.Location = new System.Drawing.Point(85, 84);
            this.playerVsPlayerButton.Name = "playerVsPlayerButton";
            this.playerVsPlayerButton.Size = new System.Drawing.Size(240, 76);
            this.playerVsPlayerButton.TabIndex = 0;
            this.playerVsPlayerButton.Text = "Player vs Player";
            this.playerVsPlayerButton.UseVisualStyleBackColor = false;
            this.playerVsPlayerButton.Click += new System.EventHandler(this.playerVsPlayerButton_Click);
            // 
            // playerVsCpuButton
            // 
            this.playerVsCpuButton.BackColor = System.Drawing.Color.Orange;
            this.playerVsCpuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.playerVsCpuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerVsCpuButton.Location = new System.Drawing.Point(85, 178);
            this.playerVsCpuButton.Name = "playerVsCpuButton";
            this.playerVsCpuButton.Size = new System.Drawing.Size(240, 75);
            this.playerVsCpuButton.TabIndex = 1;
            this.playerVsCpuButton.Text = "Player vs Cpu Easy";
            this.playerVsCpuButton.UseVisualStyleBackColor = false;
            this.playerVsCpuButton.Click += new System.EventHandler(this.playerVsCpuButton_Click);
            // 
            // groupBoxGame
            // 
            this.groupBoxGame.Controls.Add(this.p8);
            this.groupBoxGame.Controls.Add(this.p7);
            this.groupBoxGame.Controls.Add(this.p6);
            this.groupBoxGame.Controls.Add(this.p5);
            this.groupBoxGame.Controls.Add(this.p4);
            this.groupBoxGame.Controls.Add(this.p3);
            this.groupBoxGame.Controls.Add(this.p2);
            this.groupBoxGame.Controls.Add(this.p1);
            this.groupBoxGame.Controls.Add(this.p0);
            this.groupBoxGame.Controls.Add(this.backButton);
            this.groupBoxGame.Controls.Add(this.restartButton);
            this.groupBoxGame.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBoxGame.Location = new System.Drawing.Point(12, 12);
            this.groupBoxGame.Name = "groupBoxGame";
            this.groupBoxGame.Size = new System.Drawing.Size(451, 372);
            this.groupBoxGame.TabIndex = 2;
            this.groupBoxGame.TabStop = false;
            this.groupBoxGame.Visible = false;
            // 
            // p8
            // 
            this.p8.Image = global::Tic_tac_toe.Properties.Resources.nic;
            this.p8.Location = new System.Drawing.Point(284, 230);
            this.p8.Name = "p8";
            this.p8.Size = new System.Drawing.Size(100, 100);
            this.p8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.p8.TabIndex = 10;
            this.p8.TabStop = false;
            this.p8.Click += new System.EventHandler(this.p8_Click);
            // 
            // p7
            // 
            this.p7.Image = global::Tic_tac_toe.Properties.Resources.nic;
            this.p7.Location = new System.Drawing.Point(178, 230);
            this.p7.Name = "p7";
            this.p7.Size = new System.Drawing.Size(100, 100);
            this.p7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.p7.TabIndex = 9;
            this.p7.TabStop = false;
            this.p7.Click += new System.EventHandler(this.p7_Click);
            // 
            // p6
            // 
            this.p6.Image = global::Tic_tac_toe.Properties.Resources.nic;
            this.p6.Location = new System.Drawing.Point(72, 230);
            this.p6.Name = "p6";
            this.p6.Size = new System.Drawing.Size(100, 100);
            this.p6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.p6.TabIndex = 8;
            this.p6.TabStop = false;
            this.p6.Click += new System.EventHandler(this.p6_Click);
            // 
            // p5
            // 
            this.p5.Image = global::Tic_tac_toe.Properties.Resources.nic;
            this.p5.Location = new System.Drawing.Point(284, 124);
            this.p5.Name = "p5";
            this.p5.Size = new System.Drawing.Size(100, 100);
            this.p5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.p5.TabIndex = 7;
            this.p5.TabStop = false;
            this.p5.Click += new System.EventHandler(this.p5_Click);
            // 
            // p4
            // 
            this.p4.Image = global::Tic_tac_toe.Properties.Resources.nic;
            this.p4.Location = new System.Drawing.Point(178, 124);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(100, 100);
            this.p4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.p4.TabIndex = 6;
            this.p4.TabStop = false;
            this.p4.Click += new System.EventHandler(this.p4_Click);
            // 
            // p3
            // 
            this.p3.Image = global::Tic_tac_toe.Properties.Resources.nic;
            this.p3.Location = new System.Drawing.Point(72, 124);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(100, 100);
            this.p3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.p3.TabIndex = 5;
            this.p3.TabStop = false;
            this.p3.Click += new System.EventHandler(this.p3_Click);
            // 
            // p2
            // 
            this.p2.Image = global::Tic_tac_toe.Properties.Resources.nic;
            this.p2.Location = new System.Drawing.Point(284, 18);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(100, 100);
            this.p2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.p2.TabIndex = 4;
            this.p2.TabStop = false;
            this.p2.Click += new System.EventHandler(this.p2_Click);
            // 
            // p1
            // 
            this.p1.Image = global::Tic_tac_toe.Properties.Resources.nic;
            this.p1.Location = new System.Drawing.Point(178, 18);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(100, 100);
            this.p1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.p1.TabIndex = 3;
            this.p1.TabStop = false;
            this.p1.Click += new System.EventHandler(this.p1_Click);
            // 
            // p0
            // 
            this.p0.Image = global::Tic_tac_toe.Properties.Resources.nic;
            this.p0.Location = new System.Drawing.Point(72, 18);
            this.p0.Name = "p0";
            this.p0.Size = new System.Drawing.Size(100, 100);
            this.p0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.p0.TabIndex = 2;
            this.p0.TabStop = false;
            this.p0.Click += new System.EventHandler(this.p0_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Orange;
            this.backButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(229, 342);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(155, 23);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // restartButton
            // 
            this.restartButton.BackColor = System.Drawing.Color.Orange;
            this.restartButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartButton.Location = new System.Drawing.Point(72, 342);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(151, 23);
            this.restartButton.TabIndex = 0;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = false;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // groupBoxMenu
            // 
            this.groupBoxMenu.Controls.Add(this.label1);
            this.groupBoxMenu.Controls.Add(this.playerVsCpuHard);
            this.groupBoxMenu.Controls.Add(this.playerVsCpuButton);
            this.groupBoxMenu.Controls.Add(this.playerVsPlayerButton);
            this.groupBoxMenu.Location = new System.Drawing.Point(12, 12);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Size = new System.Drawing.Size(451, 372);
            this.groupBoxMenu.TabIndex = 0;
            this.groupBoxMenu.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 65);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tic tac toe";
            // 
            // playerVsCpuHard
            // 
            this.playerVsCpuHard.BackColor = System.Drawing.Color.Orange;
            this.playerVsCpuHard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.playerVsCpuHard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerVsCpuHard.Location = new System.Drawing.Point(85, 269);
            this.playerVsCpuHard.Name = "playerVsCpuHard";
            this.playerVsCpuHard.Size = new System.Drawing.Size(240, 77);
            this.playerVsCpuHard.TabIndex = 3;
            this.playerVsCpuHard.Text = "Player vs Cpu Hard";
            this.playerVsCpuHard.UseVisualStyleBackColor = false;
            this.playerVsCpuHard.Click += new System.EventHandler(this.playerVsCpuHard_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(475, 396);
            this.Controls.Add(this.groupBoxMenu);
            this.Controls.Add(this.groupBoxGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Tic tac toe";
            this.groupBoxGame.ResumeLayout(false);
            this.groupBoxGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p0)).EndInit();
            this.groupBoxMenu.ResumeLayout(false);
            this.groupBoxMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button playerVsPlayerButton;
        private System.Windows.Forms.Button playerVsCpuButton;
        private System.Windows.Forms.GroupBox groupBoxGame;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.GroupBox groupBoxMenu;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.PictureBox p8;
        private System.Windows.Forms.PictureBox p7;
        private System.Windows.Forms.PictureBox p6;
        private System.Windows.Forms.PictureBox p5;
        private System.Windows.Forms.PictureBox p4;
        private System.Windows.Forms.PictureBox p3;
        private System.Windows.Forms.PictureBox p2;
        private System.Windows.Forms.PictureBox p1;
        private System.Windows.Forms.PictureBox p0;
        private System.Windows.Forms.Button playerVsCpuHard;
        private System.Windows.Forms.Label label1;
    }
}

