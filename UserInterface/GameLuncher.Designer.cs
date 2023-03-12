
namespace UserInterface
{
    partial class GameLuncher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameLuncher));
            this.welcomegameluncher = new System.Windows.Forms.Label();
            this.singleplayer = new System.Windows.Forms.Button();
            this.multiplayer = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomegameluncher
            // 
            this.welcomegameluncher.BackColor = System.Drawing.Color.Black;
            this.welcomegameluncher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.welcomegameluncher.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomegameluncher.ForeColor = System.Drawing.Color.White;
            this.welcomegameluncher.Location = new System.Drawing.Point(0, 33);
            this.welcomegameluncher.Name = "welcomegameluncher";
            this.welcomegameluncher.Size = new System.Drawing.Size(656, 46);
            this.welcomegameluncher.TabIndex = 0;
            this.welcomegameluncher.Text = "Welcome to the game luncher:";
            this.welcomegameluncher.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // singleplayer
            // 
            this.singleplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singleplayer.Location = new System.Drawing.Point(176, 123);
            this.singleplayer.Name = "singleplayer";
            this.singleplayer.Size = new System.Drawing.Size(291, 80);
            this.singleplayer.TabIndex = 1;
            this.singleplayer.Text = "Single player";
            this.singleplayer.UseVisualStyleBackColor = true;
            this.singleplayer.Click += new System.EventHandler(this.singleplayer_Click);
            // 
            // multiplayer
            // 
            this.multiplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplayer.Location = new System.Drawing.Point(176, 247);
            this.multiplayer.Name = "multiplayer";
            this.multiplayer.Size = new System.Drawing.Size(291, 80);
            this.multiplayer.TabIndex = 2;
            this.multiplayer.Text = "Multi player";
            this.multiplayer.UseVisualStyleBackColor = true;
            this.multiplayer.Click += new System.EventHandler(this.multiplayer_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UserInterface.Properties.Resources.giphy;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(659, 407);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // GameLuncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(655, 405);
            this.Controls.Add(this.multiplayer);
            this.Controls.Add(this.singleplayer);
            this.Controls.Add(this.welcomegameluncher);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameLuncher";
            this.Text = "GameLuncher";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label welcomegameluncher;
        private System.Windows.Forms.Button singleplayer;
        private System.Windows.Forms.Button multiplayer;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}