namespace OME_File_Reader
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.abtLabel1 = new System.Windows.Forms.Label();
            this.abtOkBtn = new System.Windows.Forms.Button();
            this.abtLabel2 = new System.Windows.Forms.Label();
            this.abtLabel3 = new System.Windows.Forms.Label();
            this.abtLabel4 = new System.Windows.Forms.Label();
            this.abtLabel5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // abtLabel1
            // 
            this.abtLabel1.AutoSize = true;
            this.abtLabel1.Location = new System.Drawing.Point(101, 18);
            this.abtLabel1.Name = "abtLabel1";
            this.abtLabel1.Size = new System.Drawing.Size(72, 16);
            this.abtLabel1.TabIndex = 0;
            this.abtLabel1.Text = "Company";
            // 
            // abtOkBtn
            // 
            this.abtOkBtn.Location = new System.Drawing.Point(166, 188);
            this.abtOkBtn.Name = "abtOkBtn";
            this.abtOkBtn.Size = new System.Drawing.Size(75, 35);
            this.abtOkBtn.TabIndex = 1;
            this.abtOkBtn.Text = "&OK";
            this.abtOkBtn.UseVisualStyleBackColor = true;
            this.abtOkBtn.Click += new System.EventHandler(this.abtOkBtn_Click);
            // 
            // abtLabel2
            // 
            this.abtLabel2.AutoSize = true;
            this.abtLabel2.Location = new System.Drawing.Point(81, 49);
            this.abtLabel2.Name = "abtLabel2";
            this.abtLabel2.Size = new System.Drawing.Size(57, 16);
            this.abtLabel2.TabIndex = 2;
            this.abtLabel2.Text = "Product";
            // 
            // abtLabel3
            // 
            this.abtLabel3.AutoSize = true;
            this.abtLabel3.Location = new System.Drawing.Point(137, 83);
            this.abtLabel3.Name = "abtLabel3";
            this.abtLabel3.Size = new System.Drawing.Size(57, 16);
            this.abtLabel3.TabIndex = 3;
            this.abtLabel3.Text = "Authors";
            // 
            // abtLabel4
            // 
            this.abtLabel4.AutoSize = true;
            this.abtLabel4.Location = new System.Drawing.Point(152, 117);
            this.abtLabel4.Name = "abtLabel4";
            this.abtLabel4.Size = new System.Drawing.Size(56, 16);
            this.abtLabel4.TabIndex = 4;
            this.abtLabel4.Text = "Version";
            // 
            // abtLabel5
            // 
            this.abtLabel5.AutoSize = true;
            this.abtLabel5.Location = new System.Drawing.Point(144, 147);
            this.abtLabel5.Name = "abtLabel5";
            this.abtLabel5.Size = new System.Drawing.Size(73, 16);
            this.abtLabel5.TabIndex = 5;
            this.abtLabel5.Text = "Copyright";
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 235);
            this.Controls.Add(this.abtLabel5);
            this.Controls.Add(this.abtLabel4);
            this.Controls.Add(this.abtLabel3);
            this.Controls.Add(this.abtLabel2);
            this.Controls.Add(this.abtOkBtn);
            this.Controls.Add(this.abtLabel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.Load += new System.EventHandler(this.FormAbout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label abtLabel1;
        private System.Windows.Forms.Button abtOkBtn;
        private System.Windows.Forms.Label abtLabel2;
        private System.Windows.Forms.Label abtLabel3;
        private System.Windows.Forms.Label abtLabel4;
        private System.Windows.Forms.Label abtLabel5;
    }
}