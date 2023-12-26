namespace Containers
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileTool = new System.Windows.Forms.ToolStripMenuItem();
            this.EditTool = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewTool = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateTool = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenTool = new System.Windows.Forms.ToolStripMenuItem();
            this.CloneTool = new System.Windows.Forms.ToolStripMenuItem();
            this.DebugBox = new System.Windows.Forms.ToolStripComboBox();
            this.проектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.репозиторийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.файлToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorPanel = new System.Windows.Forms.ToolStripMenuItem();
            this.ByRed = new System.Windows.Forms.ToolStripMenuItem();
            this.ByGreen = new System.Windows.Forms.ToolStripMenuItem();
            this.ByBlue = new System.Windows.Forms.ToolStripMenuItem();
            this.GoTool = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Box1 = new System.Windows.Forms.GroupBox();
            this.Box2 = new System.Windows.Forms.GroupBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.Box1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileTool,
            this.EditTool,
            this.ViewTool,
            this.DebugBox});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(763, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileTool
            // 
            this.FileTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateTool,
            this.OpenTool,
            this.CloneTool});
            this.FileTool.Name = "FileTool";
            this.FileTool.Size = new System.Drawing.Size(48, 23);
            this.FileTool.Text = "Файл";
            // 
            // EditTool
            // 
            this.EditTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GoTool});
            this.EditTool.Name = "EditTool";
            this.EditTool.Size = new System.Drawing.Size(59, 23);
            this.EditTool.Text = "Правка";
            // 
            // ViewTool
            // 
            this.ViewTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ColorPanel});
            this.ViewTool.Name = "ViewTool";
            this.ViewTool.Size = new System.Drawing.Size(39, 23);
            this.ViewTool.Text = "Вид";
            // 
            // CreateTool
            // 
            this.CreateTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.проектToolStripMenuItem,
            this.репозиторийToolStripMenuItem,
            this.файлToolStripMenuItem1});
            this.CreateTool.Name = "CreateTool";
            this.CreateTool.Size = new System.Drawing.Size(180, 22);
            this.CreateTool.Text = "Создать";
            // 
            // OpenTool
            // 
            this.OpenTool.Name = "OpenTool";
            this.OpenTool.Size = new System.Drawing.Size(180, 22);
            this.OpenTool.Text = "Открыть";
            // 
            // CloneTool
            // 
            this.CloneTool.Name = "CloneTool";
            this.CloneTool.Size = new System.Drawing.Size(180, 22);
            this.CloneTool.Text = "Клонировать";
            // 
            // DebugBox
            // 
            this.DebugBox.Items.AddRange(new object[] {
            "Debug",
            "Relase",
            "..."});
            this.DebugBox.MergeIndex = 0;
            this.DebugBox.Name = "DebugBox";
            this.DebugBox.Size = new System.Drawing.Size(121, 23);
            this.DebugBox.Text = "Debug";
            this.DebugBox.ToolTipText = "\r\n";
            // 
            // проектToolStripMenuItem
            // 
            this.проектToolStripMenuItem.Name = "проектToolStripMenuItem";
            this.проектToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.проектToolStripMenuItem.Text = "Проект";
            // 
            // репозиторийToolStripMenuItem
            // 
            this.репозиторийToolStripMenuItem.Name = "репозиторийToolStripMenuItem";
            this.репозиторийToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.репозиторийToolStripMenuItem.Text = "Репозиторий";
            // 
            // файлToolStripMenuItem1
            // 
            this.файлToolStripMenuItem1.Name = "файлToolStripMenuItem1";
            this.файлToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.файлToolStripMenuItem1.Text = "Файл";
            // 
            // ColorPanel
            // 
            this.ColorPanel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ByRed,
            this.ByGreen,
            this.ByBlue});
            this.ColorPanel.Name = "ColorPanel";
            this.ColorPanel.Size = new System.Drawing.Size(180, 22);
            this.ColorPanel.Text = "Цвет фона";
            // 
            // ByRed
            // 
            this.ByRed.ForeColor = System.Drawing.Color.Red;
            this.ByRed.Name = "ByRed";
            this.ByRed.Size = new System.Drawing.Size(180, 22);
            this.ByRed.Text = "Красный";
            this.ByRed.Click += new System.EventHandler(this.ByRed_Click);
            // 
            // ByGreen
            // 
            this.ByGreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ByGreen.Name = "ByGreen";
            this.ByGreen.Size = new System.Drawing.Size(180, 22);
            this.ByGreen.Text = "Зеленый";
            this.ByGreen.Click += new System.EventHandler(this.ByRed_Click);
            // 
            // ByBlue
            // 
            this.ByBlue.ForeColor = System.Drawing.Color.Blue;
            this.ByBlue.Name = "ByBlue";
            this.ByBlue.Size = new System.Drawing.Size(180, 22);
            this.ByBlue.Text = "Синий";
            this.ByBlue.Click += new System.EventHandler(this.ByRed_Click);
            // 
            // GoTool
            // 
            this.GoTool.Name = "GoTool";
            this.GoTool.Size = new System.Drawing.Size(180, 22);
            this.GoTool.Text = "Перейти";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitContainer1.Location = new System.Drawing.Point(530, 27);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Box1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Box2);
            this.splitContainer1.Size = new System.Drawing.Size(233, 423);
            this.splitContainer1.SplitterDistance = 205;
            this.splitContainer1.TabIndex = 2;
            // 
            // Box1
            // 
            this.Box1.Controls.Add(this.treeView1);
            this.Box1.Location = new System.Drawing.Point(3, 3);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(227, 200);
            this.Box1.TabIndex = 0;
            this.Box1.TabStop = false;
            this.Box1.Text = "Панель инструментов";
            // 
            // Box2
            // 
            this.Box2.Location = new System.Drawing.Point(3, 7);
            this.Box2.Name = "Box2";
            this.Box2.Size = new System.Drawing.Size(227, 204);
            this.Box2.TabIndex = 1;
            this.Box2.TabStop = false;
            this.Box2.Text = "Свойства";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(-3, 19);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(233, 188);
            this.treeView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.Box1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileTool;
        private System.Windows.Forms.ToolStripMenuItem EditTool;
        private System.Windows.Forms.ToolStripMenuItem ViewTool;
        private System.Windows.Forms.ToolStripMenuItem CreateTool;
        private System.Windows.Forms.ToolStripMenuItem OpenTool;
        private System.Windows.Forms.ToolStripMenuItem CloneTool;
        private System.Windows.Forms.ToolStripComboBox DebugBox;
        private System.Windows.Forms.ToolStripMenuItem проектToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem репозиторийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem GoTool;
        private System.Windows.Forms.ToolStripMenuItem ColorPanel;
        private System.Windows.Forms.ToolStripMenuItem ByRed;
        private System.Windows.Forms.ToolStripMenuItem ByGreen;
        private System.Windows.Forms.ToolStripMenuItem ByBlue;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox Box1;
        private System.Windows.Forms.GroupBox Box2;
        private System.Windows.Forms.TreeView treeView1;
    }
}

