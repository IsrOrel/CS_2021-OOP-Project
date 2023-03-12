
namespace GamesForms
{
    partial class WelcomeTicTacToeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeTicTacToeForm));
            this.Singleplayer = new System.Windows.Forms.Button();
            this.Multiplayer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Singleplayer
            // 
            this.Singleplayer.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Singleplayer.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Singleplayer.FlatAppearance.BorderSize = 0;
            this.Singleplayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Singleplayer.Font = new System.Drawing.Font("Yu Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Singleplayer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Singleplayer.Location = new System.Drawing.Point(116, 270);
            this.Singleplayer.Name = "Singleplayer";
            this.Singleplayer.Size = new System.Drawing.Size(284, 82);
            this.Singleplayer.TabIndex = 4;
            this.Singleplayer.Text = "How to play";
            this.Singleplayer.UseVisualStyleBackColor = false;
            this.Singleplayer.Click += new System.EventHandler(this.Singleplayer_Click);
            // 
            // Multiplayer
            // 
            this.Multiplayer.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Multiplayer.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Multiplayer.FlatAppearance.BorderSize = 0;
            this.Multiplayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Multiplayer.Font = new System.Drawing.Font("Yu Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiplayer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Multiplayer.Location = new System.Drawing.Point(116, 130);
            this.Multiplayer.Name = "Multiplayer";
            this.Multiplayer.Size = new System.Drawing.Size(284, 83);
            this.Multiplayer.TabIndex = 3;
            this.Multiplayer.Text = "Start new game";
            this.Multiplayer.UseVisualStyleBackColor = false;
            this.Multiplayer.Click += new System.EventHandler(this.Multiplayer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(506, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome to the TicTacToe game:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GamesForms.Properties.Resources.giphy;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(542, 422);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // WelcomeTicTacToeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(540, 422);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Singleplayer);
            this.Controls.Add(this.Multiplayer);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WelcomeTicTacToeForm";
            this.Text = "WelcomeTicTacToe";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Singleplayer;
        private System.Windows.Forms.Button Multiplayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}