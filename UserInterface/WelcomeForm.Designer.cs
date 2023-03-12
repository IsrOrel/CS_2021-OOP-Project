
namespace UserInterface
{
    partial class WelcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            this.Title = new System.Windows.Forms.Label();
            this.HowTo = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Black;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Title.Location = new System.Drawing.Point(0, 41);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(805, 54);
            this.Title.TabIndex = 8;
            this.Title.Text = "Welcome to the ________ game:";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HowTo
            // 
            this.HowTo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.HowTo.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.HowTo.FlatAppearance.BorderSize = 0;
            this.HowTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HowTo.Font = new System.Drawing.Font("Yu Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HowTo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HowTo.Location = new System.Drawing.Point(249, 300);
            this.HowTo.Name = "HowTo";
            this.HowTo.Size = new System.Drawing.Size(284, 83);
            this.HowTo.TabIndex = 7;
            this.HowTo.Text = "How to play";
            this.HowTo.UseVisualStyleBackColor = false;
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Start.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Start.FlatAppearance.BorderSize = 0;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start.Font = new System.Drawing.Font("Yu Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Start.Location = new System.Drawing.Point(249, 160);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(284, 83);
            this.Start.TabIndex = 6;
            this.Start.Text = "Start new game";
            this.Start.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UserInterface.Properties.Resources.giphy;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(802, 451);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.HowTo);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WelcomeForm";
            this.Text = "WelcomeForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button HowTo;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}