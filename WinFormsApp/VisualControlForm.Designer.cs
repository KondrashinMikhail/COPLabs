namespace WinFormsApp
{
    partial class VisualControlForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelChoiselistControl = new System.Windows.Forms.Label();
            this.labelDataTimePickerControl = new System.Windows.Forms.Label();
            this.labelTreeViewControl = new System.Windows.Forms.Label();
            this.buttonGetItem = new System.Windows.Forms.Button();
            this.textBoxSelectedItem = new System.Windows.Forms.TextBox();
            this.buttonClearList = new System.Windows.Forms.Button();
            this.buttonFillList = new System.Windows.Forms.Button();
            this.textBoxNewItem = new System.Windows.Forms.TextBox();
            this.buttonSetItem = new System.Windows.Forms.Button();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.buttonGetDate = new System.Windows.Forms.Button();
            this.textBoxObject = new System.Windows.Forms.TextBox();
            this.buttonObject = new System.Windows.Forms.Button();
            this.textBoxGetIndex = new System.Windows.Forms.TextBox();
            this.buttonGetIndex = new System.Windows.Forms.Button();
            this.textBoxSetIndex = new System.Windows.Forms.TextBox();
            this.buttonSetIndex = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelChoiselistControl
            // 
            this.labelChoiselistControl.AutoSize = true;
            this.labelChoiselistControl.Location = new System.Drawing.Point(25, 15);
            this.labelChoiselistControl.Name = "labelChoiselistControl";
            this.labelChoiselistControl.Size = new System.Drawing.Size(123, 20);
            this.labelChoiselistControl.TabIndex = 0;
            this.labelChoiselistControl.Text = "Choiselist control";
            // 
            // labelDataTimePickerControl
            // 
            this.labelDataTimePickerControl.AutoSize = true;
            this.labelDataTimePickerControl.Location = new System.Drawing.Point(250, 15);
            this.labelDataTimePickerControl.Name = "labelDataTimePickerControl";
            this.labelDataTimePickerControl.Size = new System.Drawing.Size(164, 20);
            this.labelDataTimePickerControl.TabIndex = 1;
            this.labelDataTimePickerControl.Text = "DataTimePicker control";
            // 
            // labelTreeViewControl
            // 
            this.labelTreeViewControl.AutoSize = true;
            this.labelTreeViewControl.Location = new System.Drawing.Point(475, 15);
            this.labelTreeViewControl.Name = "labelTreeViewControl";
            this.labelTreeViewControl.Size = new System.Drawing.Size(120, 20);
            this.labelTreeViewControl.TabIndex = 2;
            this.labelTreeViewControl.Text = "TreeView control";
            // 
            // buttonGetItem
            // 
            this.buttonGetItem.Location = new System.Drawing.Point(25, 411);
            this.buttonGetItem.Name = "buttonGetItem";
            this.buttonGetItem.Size = new System.Drawing.Size(75, 27);
            this.buttonGetItem.TabIndex = 3;
            this.buttonGetItem.Text = "Get item";
            this.buttonGetItem.UseMnemonic = false;
            this.buttonGetItem.UseVisualStyleBackColor = true;
            this.buttonGetItem.Click += new System.EventHandler(this.ButtonGetItem_Click);
            // 
            // textBoxSelectedItem
            // 
            this.textBoxSelectedItem.Location = new System.Drawing.Point(106, 411);
            this.textBoxSelectedItem.Name = "textBoxSelectedItem";
            this.textBoxSelectedItem.Size = new System.Drawing.Size(119, 27);
            this.textBoxSelectedItem.TabIndex = 4;
            // 
            // buttonClearList
            // 
            this.buttonClearList.Location = new System.Drawing.Point(25, 375);
            this.buttonClearList.Name = "buttonClearList";
            this.buttonClearList.Size = new System.Drawing.Size(200, 30);
            this.buttonClearList.TabIndex = 5;
            this.buttonClearList.Text = "Clear list";
            this.buttonClearList.UseVisualStyleBackColor = true;
            this.buttonClearList.Click += new System.EventHandler(this.ButtonClearList_Click);
            // 
            // buttonFillList
            // 
            this.buttonFillList.Location = new System.Drawing.Point(25, 340);
            this.buttonFillList.Name = "buttonFillList";
            this.buttonFillList.Size = new System.Drawing.Size(200, 30);
            this.buttonFillList.TabIndex = 6;
            this.buttonFillList.Text = "Fill list";
            this.buttonFillList.UseVisualStyleBackColor = true;
            this.buttonFillList.Click += new System.EventHandler(this.ButtonFillList_Click);
            // 
            // textBoxNewItem
            // 
            this.textBoxNewItem.Location = new System.Drawing.Point(106, 444);
            this.textBoxNewItem.Name = "textBoxNewItem";
            this.textBoxNewItem.Size = new System.Drawing.Size(119, 27);
            this.textBoxNewItem.TabIndex = 8;
            // 
            // buttonSetItem
            // 
            this.buttonSetItem.Location = new System.Drawing.Point(25, 444);
            this.buttonSetItem.Name = "buttonSetItem";
            this.buttonSetItem.Size = new System.Drawing.Size(75, 27);
            this.buttonSetItem.TabIndex = 7;
            this.buttonSetItem.Text = "Set item";
            this.buttonSetItem.UseMnemonic = false;
            this.buttonSetItem.UseVisualStyleBackColor = true;
            this.buttonSetItem.Click += new System.EventHandler(this.ButtonSetItem_Click);
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(331, 340);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(119, 27);
            this.textBoxDate.TabIndex = 10;
            // 
            // buttonGetDate
            // 
            this.buttonGetDate.Location = new System.Drawing.Point(250, 340);
            this.buttonGetDate.Name = "buttonGetDate";
            this.buttonGetDate.Size = new System.Drawing.Size(75, 27);
            this.buttonGetDate.TabIndex = 9;
            this.buttonGetDate.Text = "Get date";
            this.buttonGetDate.UseMnemonic = false;
            this.buttonGetDate.UseVisualStyleBackColor = true;
            this.buttonGetDate.Click += new System.EventHandler(this.ButtonGetDate_Click);
            // 
            // textBoxObject
            // 
            this.textBoxObject.Location = new System.Drawing.Point(475, 375);
            this.textBoxObject.Name = "textBoxObject";
            this.textBoxObject.Size = new System.Drawing.Size(200, 27);
            this.textBoxObject.TabIndex = 12;
            // 
            // buttonObject
            // 
            this.buttonObject.Location = new System.Drawing.Point(475, 342);
            this.buttonObject.Name = "buttonObject";
            this.buttonObject.Size = new System.Drawing.Size(200, 30);
            this.buttonObject.TabIndex = 11;
            this.buttonObject.Text = "Get object";
            this.buttonObject.UseMnemonic = false;
            this.buttonObject.UseVisualStyleBackColor = true;
            this.buttonObject.Click += new System.EventHandler(this.ButtonObject_Click);
            // 
            // textBoxGetIndex
            // 
            this.textBoxGetIndex.Location = new System.Drawing.Point(567, 408);
            this.textBoxGetIndex.Name = "textBoxGetIndex";
            this.textBoxGetIndex.Size = new System.Drawing.Size(108, 27);
            this.textBoxGetIndex.TabIndex = 14;
            // 
            // buttonGetIndex
            // 
            this.buttonGetIndex.Location = new System.Drawing.Point(475, 408);
            this.buttonGetIndex.Name = "buttonGetIndex";
            this.buttonGetIndex.Size = new System.Drawing.Size(86, 27);
            this.buttonGetIndex.TabIndex = 13;
            this.buttonGetIndex.Text = "Get index";
            this.buttonGetIndex.UseMnemonic = false;
            this.buttonGetIndex.UseVisualStyleBackColor = true;
            this.buttonGetIndex.Click += new System.EventHandler(this.ButtonGetIndex_Click);
            // 
            // textBoxSetIndex
            // 
            this.textBoxSetIndex.Location = new System.Drawing.Point(567, 441);
            this.textBoxSetIndex.Name = "textBoxSetIndex";
            this.textBoxSetIndex.Size = new System.Drawing.Size(108, 27);
            this.textBoxSetIndex.TabIndex = 16;
            // 
            // buttonSetIndex
            // 
            this.buttonSetIndex.Location = new System.Drawing.Point(475, 441);
            this.buttonSetIndex.Name = "buttonSetIndex";
            this.buttonSetIndex.Size = new System.Drawing.Size(86, 27);
            this.buttonSetIndex.TabIndex = 15;
            this.buttonSetIndex.Text = "Set index";
            this.buttonSetIndex.UseMnemonic = false;
            this.buttonSetIndex.UseVisualStyleBackColor = true;
            this.buttonSetIndex.Click += new System.EventHandler(this.ButtonSetIndex_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 483);
            this.Controls.Add(this.textBoxSetIndex);
            this.Controls.Add(this.buttonSetIndex);
            this.Controls.Add(this.textBoxGetIndex);
            this.Controls.Add(this.buttonGetIndex);
            this.Controls.Add(this.textBoxObject);
            this.Controls.Add(this.buttonObject);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.buttonGetDate);
            this.Controls.Add(this.textBoxNewItem);
            this.Controls.Add(this.buttonSetItem);
            this.Controls.Add(this.buttonFillList);
            this.Controls.Add(this.buttonClearList);
            this.Controls.Add(this.textBoxSelectedItem);
            this.Controls.Add(this.buttonGetItem);
            this.Controls.Add(this.labelTreeViewControl);
            this.Controls.Add(this.labelDataTimePickerControl);
            this.Controls.Add(this.labelChoiselistControl);
            this.Name = "MainForm";
            this.Text = "м";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelChoiselistControl;
        private Label labelDataTimePickerControl;
        private Label labelTreeViewControl;
        private Button buttonGetItem;
        private TextBox textBoxSelectedItem;
        private Button buttonClearList;
        private Button buttonFillList;
        private TextBox textBoxNewItem;
        private Button buttonSetItem;
        private TextBox textBoxDate;
        private Button buttonGetDate;
        private TextBox textBoxObject;
        private Button buttonObject;
        private TextBox textBoxGetIndex;
        private Button buttonGetIndex;
        private TextBox textBoxSetIndex;
        private Button buttonSetIndex;
    }
}