namespace File_Compression
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fileDialogue = new System.Windows.Forms.TextBox();
            this.btn_Compress = new System.Windows.Forms.Button();
            this.btn_Browser = new System.Windows.Forms.Button();
            this.btn_Decompress = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select a File";
            // 
            // fileDialogue
            // 
            this.fileDialogue.Location = new System.Drawing.Point(152, 90);
            this.fileDialogue.Name = "fileDialogue";
            this.fileDialogue.Size = new System.Drawing.Size(243, 20);
            this.fileDialogue.TabIndex = 2;
            // 
            // btn_Compress
            // 
            this.btn_Compress.Location = new System.Drawing.Point(206, 169);
            this.btn_Compress.Name = "btn_Compress";
            this.btn_Compress.Size = new System.Drawing.Size(75, 23);
            this.btn_Compress.TabIndex = 3;
            this.btn_Compress.Text = "Compress";
            this.btn_Compress.UseVisualStyleBackColor = true;
            this.btn_Compress.Click += new System.EventHandler(this.btn_Compress_Click);
            // 
            // btn_Browser
            // 
            this.btn_Browser.Location = new System.Drawing.Point(440, 88);
            this.btn_Browser.Name = "btn_Browser";
            this.btn_Browser.Size = new System.Drawing.Size(75, 23);
            this.btn_Browser.TabIndex = 4;
            this.btn_Browser.Text = "Browser";
            this.btn_Browser.UseVisualStyleBackColor = true;
            this.btn_Browser.Click += new System.EventHandler(this.btn_Browser_Click);
            // 
            // btn_Decompress
            // 
            this.btn_Decompress.Location = new System.Drawing.Point(345, 169);
            this.btn_Decompress.Name = "btn_Decompress";
            this.btn_Decompress.Size = new System.Drawing.Size(75, 23);
            this.btn_Decompress.TabIndex = 5;
            this.btn_Decompress.Text = "Decompress";
            this.btn_Decompress.UseVisualStyleBackColor = true;
            this.btn_Decompress.Click += new System.EventHandler(this.btn_Decompress_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 332);
            this.Controls.Add(this.btn_Decompress);
            this.Controls.Add(this.btn_Browser);
            this.Controls.Add(this.btn_Compress);
            this.Controls.Add(this.fileDialogue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fileDialogue;
        private System.Windows.Forms.Button btn_Compress;
        private System.Windows.Forms.Button btn_Browser;
        private System.Windows.Forms.Button btn_Decompress;
    }
}

