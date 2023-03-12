
using System.Windows.Forms;

namespace GamesForms
{
    partial class RockPaperScissorsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RockPaperScissorsForm));
            this.weaponchoose = new System.Windows.Forms.Label();
            this.computerChooseLabel = new System.Windows.Forms.Label();
            this.computerChoose = new System.Windows.Forms.PictureBox();
            this.Scissors = new System.Windows.Forms.PictureBox();
            this.Paper = new System.Windows.Forms.PictureBox();
            this.Rock = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.computerChoose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // weaponchoose
            // 
            this.weaponchoose.AutoSize = true;
            this.weaponchoose.BackColor = System.Drawing.Color.Black;
            this.weaponchoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weaponchoose.ForeColor = System.Drawing.SystemColors.Window;
            this.weaponchoose.Location = new System.Drawing.Point(12, 9);
            this.weaponchoose.Name = "weaponchoose";
            this.weaponchoose.Size = new System.Drawing.Size(410, 46);
            this.weaponchoose.TabIndex = 0;
            this.weaponchoose.Text = "Choose your weapon:";
            // 
            // computerChooseLabel
            // 
            this.computerChooseLabel.AutoSize = true;
            this.computerChooseLabel.BackColor = System.Drawing.Color.White;
            this.computerChooseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerChooseLabel.Location = new System.Drawing.Point(12, 267);
            this.computerChooseLabel.Name = "computerChooseLabel";
            this.computerChooseLabel.Size = new System.Drawing.Size(348, 46);
            this.computerChooseLabel.TabIndex = 5;
            this.computerChooseLabel.Text = "Computer choose:";
            // 
            // computerChoose
            // 
            this.computerChoose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.computerChoose.Image = global::GamesForms.Properties.Resources.rockPapperScissorsGif;
            this.computerChoose.Location = new System.Drawing.Point(245, 355);
            this.computerChoose.Name = "computerChoose";
            this.computerChoose.Size = new System.Drawing.Size(170, 170);
            this.computerChoose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.computerChoose.TabIndex = 6;
            this.computerChoose.TabStop = false;
            // 
            // Scissors
            // 
            this.Scissors.BackgroundImage = global::GamesForms.Properties.Resources.download__3_;
            this.Scissors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Scissors.Location = new System.Drawing.Point(471, 81);
            this.Scissors.Name = "Scissors";
            this.Scissors.Size = new System.Drawing.Size(170, 170);
            this.Scissors.TabIndex = 4;
            this.Scissors.TabStop = false;
            this.Scissors.Click += new System.EventHandler(this.Scissors_Click);
            // 
            // Paper
            // 
            this.Paper.BackgroundImage = global::GamesForms.Properties.Resources.download__2_;
            this.Paper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Paper.Location = new System.Drawing.Point(245, 81);
            this.Paper.Name = "Paper";
            this.Paper.Size = new System.Drawing.Size(170, 170);
            this.Paper.TabIndex = 3;
            this.Paper.TabStop = false;
            this.Paper.Click += new System.EventHandler(this.Paper_Click);
            // 
            // Rock
            // 
            this.Rock.BackgroundImage = global::GamesForms.Properties.Resources.download;
            this.Rock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Rock.InitialImage = null;
            this.Rock.Location = new System.Drawing.Point(20, 81);
            this.Rock.Name = "Rock";
            this.Rock.Size = new System.Drawing.Size(170, 170);
            this.Rock.TabIndex = 2;
            this.Rock.TabStop = false;
            this.Rock.Click += new System.EventHandler(this.Rock_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GamesForms.Properties.Resources.giphy;
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(663, 564);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // RockPaperScissorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(662, 558);
            this.Controls.Add(this.computerChoose);
            this.Controls.Add(this.computerChooseLabel);
            this.Controls.Add(this.Scissors);
            this.Controls.Add(this.Paper);
            this.Controls.Add(this.Rock);
            this.Controls.Add(this.weaponchoose);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RockPaperScissorsForm";
            this.Text = "RockPaperScissorsForm";
            this.Load += new System.EventHandler(this.RockPaperScissorsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.computerChoose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label weaponchoose;
        private PictureBox Rock;
        private PictureBox Paper;
        private PictureBox Scissors;
        private Label computerChooseLabel;
        private PictureBox computerChoose;
        private PictureBox pictureBox1;
    }
}