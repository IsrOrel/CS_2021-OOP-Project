
namespace GamesForms
{
    partial class WelcomeRockPaperScissorsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.HowToPlay = new System.Windows.Forms.Button();
            this.StartNewGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(640, 38);
            this.label1.TabIndex = 14;
            this.label1.Text = "Welcome to the RockPaperScissors game:";
            // 
            // HowToPlay
            // 
            this.HowToPlay.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.HowToPlay.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.HowToPlay.FlatAppearance.BorderSize = 0;
            this.HowToPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HowToPlay.Font = new System.Drawing.Font("Yu Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HowToPlay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HowToPlay.Location = new System.Drawing.Point(182, 310);
            this.HowToPlay.Name = "HowToPlay";
            this.HowToPlay.Size = new System.Drawing.Size(284, 83);
            this.HowToPlay.TabIndex = 13;
            this.HowToPlay.Text = "How to play";
            this.HowToPlay.UseVisualStyleBackColor = false;
            this.HowToPlay.Click += new System.EventHandler(this.HowToPlay_Click);
            // 
            // StartNewGame
            // 
            this.StartNewGame.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.StartNewGame.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.StartNewGame.FlatAppearance.BorderSize = 0;
            this.StartNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartNewGame.Font = new System.Drawing.Font("Yu Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartNewGame.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StartNewGame.Location = new System.Drawing.Point(182, 170);
            this.StartNewGame.Name = "StartNewGame";
            this.StartNewGame.Size = new System.Drawing.Size(284, 83);
            this.StartNewGame.TabIndex = 12;
            this.StartNewGame.Text = "Start new game";
            this.StartNewGame.UseVisualStyleBackColor = false;
            // 
            // WelcomeRockPaperScissorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(655, 476);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HowToPlay);
            this.Controls.Add(this.StartNewGame);
            this.Name = "WelcomeRockPaperScissorsForm";
            this.Text = "WelcomeRockPaperScissorsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button HowToPlay;
        private System.Windows.Forms.Button StartNewGame;
    }
}