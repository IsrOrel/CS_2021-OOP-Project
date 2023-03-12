
namespace UserInterface
{
    partial class SinglePlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SinglePlayer));
            this.button1 = new System.Windows.Forms.Button();
            this.TicTacToe = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(94, 269);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.MaximumSize = new System.Drawing.Size(355, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(304, 114);
            this.button1.TabIndex = 3;
            this.button1.Text = "RockPaperScissors";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.RockPapperScissors_Click);
            // 
            // TicTacToe
            // 
            this.TicTacToe.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.TicTacToe.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicTacToe.Location = new System.Drawing.Point(94, 110);
            this.TicTacToe.Margin = new System.Windows.Forms.Padding(4);
            this.TicTacToe.MaximumSize = new System.Drawing.Size(355, 114);
            this.TicTacToe.Name = "TicTacToe";
            this.TicTacToe.Size = new System.Drawing.Size(304, 114);
            this.TicTacToe.TabIndex = 2;
            this.TicTacToe.Text = "GuessMyNumber";
            this.TicTacToe.UseVisualStyleBackColor = false;
            this.TicTacToe.Click += new System.EventHandler(this.TicTacToe_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UserInterface.Properties.Resources.giphy;
            this.pictureBox1.InitialImage = global::UserInterface.Properties.Resources.giphy;
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 498);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // SinglePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(501, 498);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TicTacToe);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SinglePlayer";
            this.Text = "SinglePlayer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button TicTacToe;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}