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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ControlsStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ActionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddElementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdElementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DelElementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DocsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SimpleDocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TableDocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChartDocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelControl = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.документыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.простойДокументToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.документСТаблицейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.документСДиаграммойToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ControlsStripMenuItem,
            this.ActionsToolStripMenuItem,
            this.DocsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(914, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "Меню";
            // 
            // ControlsStripMenuItem
            // 
            this.ControlsStripMenuItem.Name = "ControlsStripMenuItem";
            this.ControlsStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.ControlsStripMenuItem.Text = "Справочники";
            // 
            // ActionsToolStripMenuItem
            // 
            this.ActionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddElementToolStripMenuItem,
            this.UpdElementToolStripMenuItem,
            this.DelElementToolStripMenuItem});
            this.ActionsToolStripMenuItem.Name = "ActionsToolStripMenuItem";
            this.ActionsToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.ActionsToolStripMenuItem.Text = "Действия";
            // 
            // AddElementToolStripMenuItem
            // 
            this.AddElementToolStripMenuItem.Name = "AddElementToolStripMenuItem";
            this.AddElementToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.AddElementToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.AddElementToolStripMenuItem.Text = "Добавить";
            this.AddElementToolStripMenuItem.Click += new System.EventHandler(this.AddElementToolStripMenuItem_Click);
            // 
            // UpdElementToolStripMenuItem
            // 
            this.UpdElementToolStripMenuItem.Name = "UpdElementToolStripMenuItem";
            this.UpdElementToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.UpdElementToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.UpdElementToolStripMenuItem.Text = "Изменить";
            this.UpdElementToolStripMenuItem.Click += new System.EventHandler(this.UpdElementToolStripMenuItem_Click);
            // 
            // DelElementToolStripMenuItem
            // 
            this.DelElementToolStripMenuItem.Name = "DelElementToolStripMenuItem";
            this.DelElementToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.DelElementToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.DelElementToolStripMenuItem.Text = "Удалить";
            this.DelElementToolStripMenuItem.Click += new System.EventHandler(this.DelElementToolStripMenuItem_Click);
            // 
            // DocsToolStripMenuItem
            // 
            this.DocsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SimpleDocToolStripMenuItem,
            this.TableDocToolStripMenuItem,
            this.ChartDocToolStripMenuItem});
            this.DocsToolStripMenuItem.Name = "DocsToolStripMenuItem";
            this.DocsToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.DocsToolStripMenuItem.Text = "Документы";
            // 
            // SimpleDocToolStripMenuItem
            // 
            this.SimpleDocToolStripMenuItem.Name = "SimpleDocToolStripMenuItem";
            this.SimpleDocToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SimpleDocToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.SimpleDocToolStripMenuItem.Text = "Простой документ";
            this.SimpleDocToolStripMenuItem.Click += new System.EventHandler(this.SimpleDocToolStripMenuItem_Click);
            // 
            // TableDocToolStripMenuItem
            // 
            this.TableDocToolStripMenuItem.Name = "TableDocToolStripMenuItem";
            this.TableDocToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.TableDocToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.TableDocToolStripMenuItem.Text = "Документ с таблицей";
            this.TableDocToolStripMenuItem.Click += new System.EventHandler(this.TableDocToolStripMenuItem_Click);
            // 
            // ChartDocToolStripMenuItem
            // 
            this.ChartDocToolStripMenuItem.Name = "ChartDocToolStripMenuItem";
            this.ChartDocToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.ChartDocToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.ChartDocToolStripMenuItem.Text = "Диаграмма";
            this.ChartDocToolStripMenuItem.Click += new System.EventHandler(this.ChartDocToolStripMenuItem_Click);
            // 
            // panelControl
            // 
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Location = new System.Drawing.Point(0, 28);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(914, 452);
            this.panelControl.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.действияToolStripMenuItem,
            this.документыToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(157, 52);
            this.contextMenuStrip1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseDown);
            // 
            // действияToolStripMenuItem
            // 
            this.действияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.действияToolStripMenuItem.Text = "Действия";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.AddElementToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.UpdElementToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.DelElementToolStripMenuItem_Click);
            // 
            // документыToolStripMenuItem
            // 
            this.документыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.простойДокументToolStripMenuItem,
            this.документСТаблицейToolStripMenuItem,
            this.документСДиаграммойToolStripMenuItem});
            this.документыToolStripMenuItem.Name = "документыToolStripMenuItem";
            this.документыToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.документыToolStripMenuItem.Text = "Документы";
            // 
            // простойДокументToolStripMenuItem
            // 
            this.простойДокументToolStripMenuItem.Name = "простойДокументToolStripMenuItem";
            this.простойДокументToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.простойДокументToolStripMenuItem.Text = "Простой документ";
            this.простойДокументToolStripMenuItem.Click += new System.EventHandler(this.SimpleDocToolStripMenuItem_Click);
            // 
            // документСТаблицейToolStripMenuItem
            // 
            this.документСТаблицейToolStripMenuItem.Name = "документСТаблицейToolStripMenuItem";
            this.документСТаблицейToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.документСТаблицейToolStripMenuItem.Text = "Документ с таблицей";
            this.документСТаблицейToolStripMenuItem.Click += new System.EventHandler(this.TableDocToolStripMenuItem_Click);
            // 
            // документСДиаграммойToolStripMenuItem
            // 
            this.документСДиаграммойToolStripMenuItem.Name = "документСДиаграммойToolStripMenuItem";
            this.документСДиаграммойToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.документСДиаграммойToolStripMenuItem.Text = "Документ с диаграммой";
            this.документСДиаграммойToolStripMenuItem.Click += new System.EventHandler(this.ChartDocToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 480);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная форма";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseDown);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem ControlsStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DocsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SimpleDocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TableDocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChartDocToolStripMenuItem;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.ToolStripMenuItem ActionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddElementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UpdElementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DelElementToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem действияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem документыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem простойДокументToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem документСТаблицейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem документСДиаграммойToolStripMenuItem;
    }
}