namespace Gym_App
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.label1 = new System.Windows.Forms.Label();
            this.find = new System.Windows.Forms.LinkLabel();
            this.bck = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(768, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // find
            // 
            this.find.AutoSize = true;
            this.find.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.find.Location = new System.Drawing.Point(15, 569);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(173, 24);
            this.find.TabIndex = 1;
            this.find.TabStop = true;
            this.find.Text = "Find us on the map";
            this.find.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.find_LinkClicked);
            // 
            // bck
            // 
            this.bck.AutoSize = false;
            this.bck.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bck.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bck.Depth = 0;
            this.bck.HighEmphasis = true;
            this.bck.Icon = null;
            this.bck.Location = new System.Drawing.Point(863, 557);
            this.bck.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bck.MouseState = MaterialSkin.MouseState.HOVER;
            this.bck.Name = "bck";
            this.bck.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bck.Size = new System.Drawing.Size(177, 36);
            this.bck.TabIndex = 3;
            this.bck.Text = "BACK";
            this.bck.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bck.UseAccentColor = false;
            this.bck.UseVisualStyleBackColor = true;
            this.bck.Click += new System.EventHandler(this.bck_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 234);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(575, 298);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(631, 234);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(409, 298);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 629);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bck);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.find);
            this.Controls.Add(this.label1);
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel find;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialButton bck;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}