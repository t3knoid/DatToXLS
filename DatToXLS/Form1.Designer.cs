namespace DatToXLS
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
            this.tbConcordanceFilePath = new System.Windows.Forms.TextBox();
            this.btBrowse = new System.Windows.Forms.Button();
            this.btConvert = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btCancel = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tbConcordanceFilePath
            // 
            this.tbConcordanceFilePath.AllowDrop = true;
            this.tbConcordanceFilePath.Location = new System.Drawing.Point(13, 51);
            this.tbConcordanceFilePath.Name = "tbConcordanceFilePath";
            this.tbConcordanceFilePath.Size = new System.Drawing.Size(402, 20);
            this.tbConcordanceFilePath.TabIndex = 0;
            this.tbConcordanceFilePath.TextChanged += new System.EventHandler(this.tbConcordanceFilePath_TextChanged);
            this.tbConcordanceFilePath.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbConcordanceFilePath_DragDrop);
            this.tbConcordanceFilePath.DragEnter += new System.Windows.Forms.DragEventHandler(this.tbConcordanceFilePath_DragEnter);
            this.tbConcordanceFilePath.DragOver += new System.Windows.Forms.DragEventHandler(this.tbConcordanceFilePath_DragOver);
            // 
            // btBrowse
            // 
            this.btBrowse.Location = new System.Drawing.Point(421, 49);
            this.btBrowse.Name = "btBrowse";
            this.btBrowse.Size = new System.Drawing.Size(75, 23);
            this.btBrowse.TabIndex = 1;
            this.btBrowse.Text = "Browse...";
            this.btBrowse.UseVisualStyleBackColor = true;
            this.btBrowse.Click += new System.EventHandler(this.btBrowse_Click);
            // 
            // btConvert
            // 
            this.btConvert.Location = new System.Drawing.Point(158, 95);
            this.btConvert.Name = "btConvert";
            this.btConvert.Size = new System.Drawing.Size(75, 23);
            this.btConvert.TabIndex = 2;
            this.btConvert.Text = "Convert";
            this.btConvert.UseVisualStyleBackColor = true;
            this.btConvert.Click += new System.EventHandler(this.btConvert_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(262, 95);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 3;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(13, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(483, 33);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "Select a concordance file to convert into an Excel spreadsheet.";
            // 
            // Form1
            // 
            this.AcceptButton = this.btConvert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(508, 143);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btConvert);
            this.Controls.Add(this.btBrowse);
            this.Controls.Add(this.tbConcordanceFilePath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "DAT to XLSX Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbConcordanceFilePath;
        private System.Windows.Forms.Button btBrowse;
        private System.Windows.Forms.Button btConvert;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

