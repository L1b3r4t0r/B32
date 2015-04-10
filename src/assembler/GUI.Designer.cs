namespace B32.src.assembler
{
    partial class GUI
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSourceFileName = new System.Windows.Forms.TextBox();
            this.txtOutputFileName = new System.Windows.Forms.TextBox();
            this.txtOrigin = new System.Windows.Forms.TextBox();
            this.btnOutputBrowse = new System.Windows.Forms.Button();
            this.btnSourceBrowse = new System.Windows.Forms.Button();
            this.btnAssemble = new System.Windows.Forms.Button();
            this.fdDestinationFile = new System.Windows.Forms.OpenFileDialog();
            this.fdSourceFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source file: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Output file: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Origin: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "$";
            // 
            // txtSourceFileName
            // 
            this.txtSourceFileName.Location = new System.Drawing.Point(81, 6);
            this.txtSourceFileName.Name = "txtSourceFileName";
            this.txtSourceFileName.Size = new System.Drawing.Size(110, 20);
            this.txtSourceFileName.TabIndex = 4;
            // 
            // txtOutputFileName
            // 
            this.txtOutputFileName.Location = new System.Drawing.Point(81, 32);
            this.txtOutputFileName.Name = "txtOutputFileName";
            this.txtOutputFileName.Size = new System.Drawing.Size(110, 20);
            this.txtOutputFileName.TabIndex = 5;
            // 
            // txtOrigin
            // 
            this.txtOrigin.Location = new System.Drawing.Point(81, 60);
            this.txtOrigin.Name = "txtOrigin";
            this.txtOrigin.Size = new System.Drawing.Size(110, 20);
            this.txtOrigin.TabIndex = 6;
            // 
            // btnOutputBrowse
            // 
            this.btnOutputBrowse.Location = new System.Drawing.Point(197, 30);
            this.btnOutputBrowse.Name = "btnOutputBrowse";
            this.btnOutputBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnOutputBrowse.TabIndex = 7;
            this.btnOutputBrowse.Text = "Browse...";
            this.btnOutputBrowse.UseVisualStyleBackColor = true;
            this.btnOutputBrowse.Click += new System.EventHandler(this.btnOutputBrowse_Click);
            // 
            // btnSourceBrowse
            // 
            this.btnSourceBrowse.Location = new System.Drawing.Point(197, 4);
            this.btnSourceBrowse.Name = "btnSourceBrowse";
            this.btnSourceBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnSourceBrowse.TabIndex = 8;
            this.btnSourceBrowse.Text = "Browse...";
            this.btnSourceBrowse.UseVisualStyleBackColor = true;
            this.btnSourceBrowse.Click += new System.EventHandler(this.btnSourceBrowse_Click);
            // 
            // btnAssemble
            // 
            this.btnAssemble.Location = new System.Drawing.Point(12, 104);
            this.btnAssemble.Name = "btnAssemble";
            this.btnAssemble.Size = new System.Drawing.Size(75, 23);
            this.btnAssemble.TabIndex = 9;
            this.btnAssemble.Text = "GO!";
            this.btnAssemble.UseVisualStyleBackColor = true;
            this.btnAssemble.Click += new System.EventHandler(this.btnAssemble_Click);
            // 
            // fdDestinationFile
            // 
            this.fdDestinationFile.DefaultExt = "B32";
            this.fdDestinationFile.Filter = "B32 Files|*.B32";
            // 
            // fdSourceFile
            // 
            this.fdSourceFile.DefaultExt = "asm";
            this.fdSourceFile.Filter = "B32 Assembly files|*.asm";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnAssemble);
            this.Controls.Add(this.btnSourceBrowse);
            this.Controls.Add(this.btnOutputBrowse);
            this.Controls.Add(this.txtOrigin);
            this.Controls.Add(this.txtOutputFileName);
            this.Controls.Add(this.txtSourceFileName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GUI";
            this.Text = "ASSEMBLER GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSourceFileName;
        private System.Windows.Forms.TextBox txtOutputFileName;
        private System.Windows.Forms.TextBox txtOrigin;
        private System.Windows.Forms.Button btnOutputBrowse;
        private System.Windows.Forms.Button btnSourceBrowse;
        private System.Windows.Forms.Button btnAssemble;
        private System.Windows.Forms.OpenFileDialog fdDestinationFile;
        private System.Windows.Forms.OpenFileDialog fdSourceFile;
    }
}