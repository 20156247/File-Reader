namespace OME_File_Reader
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
            this.heading = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.selectBtn = new System.Windows.Forms.Button();
            this.readBtn = new System.Windows.Forms.Button();
            this.displayBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // heading
            // 
            this.heading.AutoSize = true;
            this.heading.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading.Location = new System.Drawing.Point(247, 20);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(284, 56);
            this.heading.TabIndex = 0;
            this.heading.Text = "File Reader";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(175, 96);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(417, 200);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "Checking if my own branch changes works";
            // 
            // selectBtn
            // 
            this.selectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectBtn.Location = new System.Drawing.Point(175, 338);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(114, 43);
            this.selectBtn.TabIndex = 2;
            this.selectBtn.Text = "Select File";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // readBtn
            // 
            this.readBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readBtn.Location = new System.Drawing.Point(325, 338);
            this.readBtn.Name = "readBtn";
            this.readBtn.Size = new System.Drawing.Size(114, 43);
            this.readBtn.TabIndex = 3;
            this.readBtn.Text = "Read";
            this.readBtn.UseVisualStyleBackColor = true;
            // 
            // displayBtn
            // 
            this.displayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayBtn.Location = new System.Drawing.Point(478, 338);
            this.displayBtn.Name = "displayBtn";
            this.displayBtn.Size = new System.Drawing.Size(114, 43);
            this.displayBtn.TabIndex = 4;
            this.displayBtn.Text = "Display";
            this.displayBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.displayBtn);
            this.Controls.Add(this.readBtn);
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.heading);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label heading;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.Button readBtn;
        private System.Windows.Forms.Button displayBtn;
    }
}

