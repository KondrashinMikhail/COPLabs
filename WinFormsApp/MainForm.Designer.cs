namespace WinForms
{
    partial class MainForm
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
            this.buttonFirstLab = new System.Windows.Forms.Button();
            this.buttonSecondLab = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonFirstLab
            // 
            this.buttonFirstLab.Location = new System.Drawing.Point(12, 12);
            this.buttonFirstLab.Name = "buttonFirstLab";
            this.buttonFirstLab.Size = new System.Drawing.Size(248, 56);
            this.buttonFirstLab.TabIndex = 0;
            this.buttonFirstLab.Text = "First lab";
            this.buttonFirstLab.UseVisualStyleBackColor = true;
            this.buttonFirstLab.Click += new System.EventHandler(this.ButtonFirstLab_Click);
            // 
            // buttonSecondLab
            // 
            this.buttonSecondLab.Location = new System.Drawing.Point(12, 74);
            this.buttonSecondLab.Name = "buttonSecondLab";
            this.buttonSecondLab.Size = new System.Drawing.Size(248, 56);
            this.buttonSecondLab.TabIndex = 1;
            this.buttonSecondLab.Text = "Second lab";
            this.buttonSecondLab.UseVisualStyleBackColor = true;
            this.buttonSecondLab.Click += new System.EventHandler(this.ButtonSecondLab_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 142);
            this.Controls.Add(this.buttonSecondLab);
            this.Controls.Add(this.buttonFirstLab);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonFirstLab;
        private Button buttonSecondLab;
    }
}