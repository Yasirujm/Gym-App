namespace Gym_App
{
    partial class Payment_Portal
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
            this.cno = new System.Windows.Forms.TextBox();
            this.cvv = new System.Windows.Forms.TextBox();
            this.exp = new System.Windows.Forms.TextBox();
            this.chname = new System.Windows.Forms.TextBox();
            this.lblCardNumberError = new System.Windows.Forms.Label();
            this.lblCVVError = new System.Windows.Forms.Label();
            this.lblExpDateError = new System.Windows.Forms.Label();
            this.lblCardHolderNameError = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.paynw = new System.Windows.Forms.Button();
            this.clss = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cno
            // 
            this.cno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cno.Location = new System.Drawing.Point(396, 151);
            this.cno.Name = "cno";
            this.cno.Size = new System.Drawing.Size(395, 23);
            this.cno.TabIndex = 0;
            // 
            // cvv
            // 
            this.cvv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cvv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cvv.Location = new System.Drawing.Point(396, 211);
            this.cvv.Name = "cvv";
            this.cvv.Size = new System.Drawing.Size(82, 23);
            this.cvv.TabIndex = 1;
            // 
            // exp
            // 
            this.exp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.exp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.exp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.exp.Location = new System.Drawing.Point(396, 277);
            this.exp.Name = "exp";
            this.exp.Size = new System.Drawing.Size(82, 23);
            this.exp.TabIndex = 2;
            // 
            // chname
            // 
            this.chname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.chname.Location = new System.Drawing.Point(396, 346);
            this.chname.Name = "chname";
            this.chname.Size = new System.Drawing.Size(395, 23);
            this.chname.TabIndex = 4;
            // 
            // lblCardNumberError
            // 
            this.lblCardNumberError.AutoSize = true;
            this.lblCardNumberError.Location = new System.Drawing.Point(223, 158);
            this.lblCardNumberError.Name = "lblCardNumberError";
            this.lblCardNumberError.Size = new System.Drawing.Size(93, 16);
            this.lblCardNumberError.TabIndex = 5;
            this.lblCardNumberError.Text = "Card Number :";
            // 
            // lblCVVError
            // 
            this.lblCVVError.AutoSize = true;
            this.lblCVVError.Location = new System.Drawing.Point(223, 218);
            this.lblCVVError.Name = "lblCVVError";
            this.lblCVVError.Size = new System.Drawing.Size(58, 16);
            this.lblCVVError.TabIndex = 6;
            this.lblCVVError.Text = "CVV No.";
            // 
            // lblExpDateError
            // 
            this.lblExpDateError.AutoSize = true;
            this.lblExpDateError.Location = new System.Drawing.Point(223, 284);
            this.lblExpDateError.Name = "lblExpDateError";
            this.lblExpDateError.Size = new System.Drawing.Size(102, 16);
            this.lblExpDateError.TabIndex = 7;
            this.lblExpDateError.Text = "Exp Month/Date";
            // 
            // lblCardHolderNameError
            // 
            this.lblCardHolderNameError.AutoSize = true;
            this.lblCardHolderNameError.Location = new System.Drawing.Point(223, 353);
            this.lblCardHolderNameError.Name = "lblCardHolderNameError";
            this.lblCardHolderNameError.Size = new System.Drawing.Size(120, 16);
            this.lblCardHolderNameError.TabIndex = 8;
            this.lblCardHolderNameError.Text = "Card Holder Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(355, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(269, 39);
            this.label5.TabIndex = 9;
            this.label5.Text = "Payment Portal";
            // 
            // paynw
            // 
            this.paynw.Location = new System.Drawing.Point(543, 436);
            this.paynw.Name = "paynw";
            this.paynw.Size = new System.Drawing.Size(108, 39);
            this.paynw.TabIndex = 10;
            this.paynw.Text = "Pay";
            this.paynw.UseVisualStyleBackColor = true;
            this.paynw.Click += new System.EventHandler(this.paynw_Click);
            // 
            // clss
            // 
            this.clss.Location = new System.Drawing.Point(396, 436);
            this.clss.Name = "clss";
            this.clss.Size = new System.Drawing.Size(108, 39);
            this.clss.TabIndex = 11;
            this.clss.Text = "Close";
            this.clss.UseVisualStyleBackColor = true;
            this.clss.Click += new System.EventHandler(this.clss_Click);
            // 
            // Payment_Portal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 556);
            this.Controls.Add(this.clss);
            this.Controls.Add(this.paynw);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCardHolderNameError);
            this.Controls.Add(this.lblExpDateError);
            this.Controls.Add(this.lblCVVError);
            this.Controls.Add(this.lblCardNumberError);
            this.Controls.Add(this.chname);
            this.Controls.Add(this.exp);
            this.Controls.Add(this.cvv);
            this.Controls.Add(this.cno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Payment_Portal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment_Portal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cno;
        private System.Windows.Forms.TextBox cvv;
        private System.Windows.Forms.TextBox exp;
        private System.Windows.Forms.TextBox chname;
        private System.Windows.Forms.Label lblCardNumberError;
        private System.Windows.Forms.Label lblCVVError;
        private System.Windows.Forms.Label lblExpDateError;
        private System.Windows.Forms.Label lblCardHolderNameError;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button paynw;
        private System.Windows.Forms.Button clss;
    }
}