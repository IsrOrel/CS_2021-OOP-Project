
namespace UserInterface
{
    partial class MultiPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultiPlayer));
            this.TicTacToe = new System.Windows.Forms.Button();
            this.FourInARow = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TicTacToe
            // 
            this.TicTacToe.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.TicTacToe.Font = new System.Drawing.Font("Yu Gothic UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicTacToe.Location = new System.Drawing.Point(99, 94);
            this.TicTacToe.Margin = new System.Windows.Forms.Padding(4);
            this.TicTacToe.MaximumSize = new System.Drawing.Size(355, 114);
            this.TicTacToe.Name = "TicTacToe";
            this.TicTacToe.Size = new System.Drawing.Size(304, 114);
            this.TicTacToe.TabIndex = 0;
            this.TicTacToe.Text = "TicTacToe";
            this.TicTacToe.UseVisualStyleBackColor = false;
            this.TicTacToe.Click += new System.EventHandler(this.TicTacToe_Click);
            // 
            // FourInARow
            // 
            this.FourInARow.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.FourInARow.Font = new System.Drawing.Font("Yu Gothic UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FourInARow.Location = new System.Drawing.Point(99, 253);
            this.FourInARow.Margin = new System.Windows.Forms.Padding(4);
            this.FourInARow.MaximumSize = new System.Drawing.Size(355, 114);
            this.FourInARow.Name = "FourInARow";
            this.FourInARow.Size = new System.Drawing.Size(304, 114);
            this.FourInARow.TabIndex = 1;
            this.FourInARow.Text = "FourInArow";
            this.FourInARow.UseVisualStyleBackColor = false;
            this.FourInARow.Click += new System.EventHandler(this.FourInARow_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UserInterface.Properties.Resources.giphy;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(494, 498);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MultiPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(492, 492);
            this.Controls.Add(this.FourInARow);
            this.Controls.Add(this.TicTacToe);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MultiPlayer";
            this.Text = "MultiPlayer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TicTacToe;
        private System.Windows.Forms.Button FourInARow;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}