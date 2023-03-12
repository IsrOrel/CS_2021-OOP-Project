
namespace GamesForms
{
    partial class FourInARowColumn
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._0 = new RoundedButton();
            this._1 = new RoundedButton();
            this._2 = new RoundedButton();
            this._3 = new RoundedButton();
            this._4 = new RoundedButton();
            this._5 = new RoundedButton();
            this.SuspendLayout();
            // 
            // _0
            // 
            this._0.Location = new System.Drawing.Point(2, 371);
            this._0.Name = "_0";
            this._0.Size = new System.Drawing.Size(68, 65);
            this._0.TabIndex = 12;
            this._0.Tag = "0";
            this._0.UseVisualStyleBackColor = true;
            this._0.Click += new System.EventHandler(this.Button_Click);
            // 
            // _1
            // 
            this._1.Location = new System.Drawing.Point(2, 300);
            this._1.Name = "_1";
            this._1.Size = new System.Drawing.Size(68, 65);
            this._1.TabIndex = 11;
            this._1.Tag = "1";
            this._1.UseVisualStyleBackColor = true;
            this._1.Click += new System.EventHandler(this.Button_Click);
            // 
            // _2
            // 
            this._2.Location = new System.Drawing.Point(2, 229);
            this._2.Name = "_2";
            this._2.Size = new System.Drawing.Size(68, 65);
            this._2.TabIndex = 10;
            this._2.Tag = "2";
            this._2.UseVisualStyleBackColor = true;
            this._2.Click += new System.EventHandler(this.Button_Click);
            // 
            // _3
            // 
            this._3.Location = new System.Drawing.Point(2, 158);
            this._3.Name = "_3";
            this._3.Size = new System.Drawing.Size(68, 65);
            this._3.TabIndex = 9;
            this._3.Tag = "3";
            this._3.UseVisualStyleBackColor = true;
            this._3.Click += new System.EventHandler(this.Button_Click);
            // 
            // _4
            // 
            this._4.Location = new System.Drawing.Point(2, 87);
            this._4.Name = "_4";
            this._4.Size = new System.Drawing.Size(68, 65);
            this._4.TabIndex = 8;
            this._4.Tag = "4";
            this._4.UseVisualStyleBackColor = true;
            this._4.Click += new System.EventHandler(this.Button_Click);
            // 
            // _5
            // 
            this._5.Location = new System.Drawing.Point(2, 16);
            this._5.Name = "_5";
            this._5.Size = new System.Drawing.Size(68, 65);
            this._5.TabIndex = 7;
            this._5.Tag = "5";
            this._5.UseVisualStyleBackColor = true;
            this._5.Click += new System.EventHandler(this.Button_Click);
            // 
            // FourInARowColumn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this._0);
            this.Controls.Add(this._1);
            this.Controls.Add(this._2);
            this.Controls.Add(this._3);
            this.Controls.Add(this._4);
            this.Controls.Add(this._5);
            this.Name = "FourInARowColumn";
            this.Size = new System.Drawing.Size(72, 446);
            this.Load += new System.EventHandler(this.FourInARowColumn_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private RoundedButton _0;
        private RoundedButton _1;
        private RoundedButton _2;
        private RoundedButton _3;
        private RoundedButton _4;
        private RoundedButton _5;
    }
}
