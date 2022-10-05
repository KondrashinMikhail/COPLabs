namespace WinForms
{
    partial class SecondLabForm
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
            this.buttonDocumentWithImages = new System.Windows.Forms.Button();
            this.buttonDocumentWithDiagrams = new System.Windows.Forms.Button();
            this.buttonDocumentWithTable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDocumentWithImages
            // 
            this.buttonDocumentWithImages.Location = new System.Drawing.Point(12, 12);
            this.buttonDocumentWithImages.Name = "buttonDocumentWithImages";
            this.buttonDocumentWithImages.Size = new System.Drawing.Size(170, 50);
            this.buttonDocumentWithImages.TabIndex = 0;
            this.buttonDocumentWithImages.Text = "Document with images";
            this.buttonDocumentWithImages.UseVisualStyleBackColor = true;
            this.buttonDocumentWithImages.Click += new System.EventHandler(this.ButtonDocumentWithImages_Click);
            // 
            // buttonDocumentWithDiagrams
            // 
            this.buttonDocumentWithDiagrams.Location = new System.Drawing.Point(364, 12);
            this.buttonDocumentWithDiagrams.Name = "buttonDocumentWithDiagrams";
            this.buttonDocumentWithDiagrams.Size = new System.Drawing.Size(170, 50);
            this.buttonDocumentWithDiagrams.TabIndex = 3;
            this.buttonDocumentWithDiagrams.Text = "Document with diagrams";
            this.buttonDocumentWithDiagrams.UseVisualStyleBackColor = true;
            this.buttonDocumentWithDiagrams.Click += new System.EventHandler(this.ButtonDocumentWithDiagrams_Click);
            // 
            // buttonDocumentWithTable
            // 
            this.buttonDocumentWithTable.Location = new System.Drawing.Point(188, 12);
            this.buttonDocumentWithTable.Name = "buttonDocumentWithTable";
            this.buttonDocumentWithTable.Size = new System.Drawing.Size(170, 50);
            this.buttonDocumentWithTable.TabIndex = 4;
            this.buttonDocumentWithTable.Text = "Document with table";
            this.buttonDocumentWithTable.UseVisualStyleBackColor = true;
            this.buttonDocumentWithTable.Click += new System.EventHandler(this.ButtonDocumentWithTable_Click);
            // 
            // SecondLabForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 75);
            this.Controls.Add(this.buttonDocumentWithTable);
            this.Controls.Add(this.buttonDocumentWithDiagrams);
            this.Controls.Add(this.buttonDocumentWithImages);
            this.Name = "SecondLabForm";
            this.Text = "SecondLabForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonDocumentWithImages;
        private Button buttonDocumentWithDiagrams;
        private Button buttonDocumentWithTable;
    }
}