namespace UpdateActiveDirectory
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblUpdateCnt = new System.Windows.Forms.Label();
            this.lblErrorCnt = new System.Windows.Forms.Label();
            this.txtTablename = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblUpdateCnt
            // 
            this.lblUpdateCnt.AutoSize = true;
            this.lblUpdateCnt.Location = new System.Drawing.Point(113, 92);
            this.lblUpdateCnt.Name = "lblUpdateCnt";
            this.lblUpdateCnt.Size = new System.Drawing.Size(13, 13);
            this.lblUpdateCnt.TabIndex = 4;
            this.lblUpdateCnt.Text = "0";
            // 
            // lblErrorCnt
            // 
            this.lblErrorCnt.AutoSize = true;
            this.lblErrorCnt.Location = new System.Drawing.Point(23, 92);
            this.lblErrorCnt.Name = "lblErrorCnt";
            this.lblErrorCnt.Size = new System.Drawing.Size(13, 13);
            this.lblErrorCnt.TabIndex = 5;
            this.lblErrorCnt.Text = "0";
            // 
            // txtTablename
            // 
            this.txtTablename.Location = new System.Drawing.Point(26, 15);
            this.txtTablename.Name = "txtTablename";
            this.txtTablename.Size = new System.Drawing.Size(100, 20);
            this.txtTablename.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(152, 122);
            this.Controls.Add(this.lblErrorCnt);
            this.Controls.Add(this.lblUpdateCnt);
            this.Controls.Add(this.txtTablename);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "AD Telephone Number Updater";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblUpdateCnt;
        private System.Windows.Forms.Label lblErrorCnt;
        private System.Windows.Forms.TextBox txtTablename;
    }
}

