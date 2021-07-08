
namespace ExplorerTab
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.btn_Reload = new System.Windows.Forms.Button();
            this.tb_Path = new System.Windows.Forms.TextBox();
            this.btn_Forward = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.panel_ListDirectory = new System.Windows.Forms.Panel();
            this.listViewListDisk = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewQuickAccess = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.panel_Top.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel_ListDirectory.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel_Top.Controls.Add(this.btn_Reload);
            this.panel_Top.Controls.Add(this.tb_Path);
            this.panel_Top.Controls.Add(this.btn_Forward);
            this.panel_Top.Controls.Add(this.btn_Back);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(800, 33);
            this.panel_Top.TabIndex = 2;
            // 
            // btn_Reload
            // 
            this.btn_Reload.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Reload.Location = new System.Drawing.Point(762, 0);
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Size = new System.Drawing.Size(38, 33);
            this.btn_Reload.TabIndex = 3;
            this.btn_Reload.Text = "⟳";
            this.btn_Reload.UseVisualStyleBackColor = true;
            this.btn_Reload.Click += new System.EventHandler(this.btn_Reload_Click);
            // 
            // tb_Path
            // 
            this.tb_Path.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Path.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Path.Location = new System.Drawing.Point(76, 0);
            this.tb_Path.Name = "tb_Path";
            this.tb_Path.Size = new System.Drawing.Size(724, 31);
            this.tb_Path.TabIndex = 2;
            // 
            // btn_Forward
            // 
            this.btn_Forward.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Forward.Location = new System.Drawing.Point(38, 0);
            this.btn_Forward.Name = "btn_Forward";
            this.btn_Forward.Size = new System.Drawing.Size(38, 33);
            this.btn_Forward.TabIndex = 1;
            this.btn_Forward.Text = ">";
            this.btn_Forward.UseVisualStyleBackColor = true;
            this.btn_Forward.Click += new System.EventHandler(this.btn_Forward_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Back.Location = new System.Drawing.Point(0, 0);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(38, 33);
            this.btn_Back.TabIndex = 0;
            this.btn_Back.Text = "<";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(144, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(656, 395);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.TabIndexChanged += new System.EventHandler(this.tabControl1_TabIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabPage1.Controls.Add(this.webBrowser1);
            this.tabPage1.ForeColor = System.Drawing.Color.White;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(648, 369);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tab - 1 ";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(642, 363);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.webBrowser2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(648, 369);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tab - 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // webBrowser2
            // 
            this.webBrowser2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser2.Location = new System.Drawing.Point(3, 3);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(642, 363);
            this.webBrowser2.TabIndex = 0;
            this.webBrowser2.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser2_DocumentCompleted);
            // 
            // panel_ListDirectory
            // 
            this.panel_ListDirectory.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel_ListDirectory.Controls.Add(this.listViewListDisk);
            this.panel_ListDirectory.Controls.Add(this.listViewQuickAccess);
            this.panel_ListDirectory.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_ListDirectory.Location = new System.Drawing.Point(0, 33);
            this.panel_ListDirectory.Name = "panel_ListDirectory";
            this.panel_ListDirectory.Size = new System.Drawing.Size(144, 395);
            this.panel_ListDirectory.TabIndex = 3;
            // 
            // listViewListDisk
            // 
            this.listViewListDisk.BackColor = System.Drawing.SystemColors.HotTrack;
            this.listViewListDisk.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.listViewListDisk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewListDisk.HideSelection = false;
            this.listViewListDisk.Location = new System.Drawing.Point(0, 120);
            this.listViewListDisk.Name = "listViewListDisk";
            this.listViewListDisk.Size = new System.Drawing.Size(144, 275);
            this.listViewListDisk.TabIndex = 3;
            this.listViewListDisk.UseCompatibleStateImageBehavior = false;
            this.listViewListDisk.View = System.Windows.Forms.View.Details;
            this.listViewListDisk.SelectedIndexChanged += new System.EventHandler(this.listViewListDisk_SelectedIndexChanged);
            this.listViewListDisk.Click += new System.EventHandler(this.listViewListDisk_Click);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "This Pc :";
            this.columnHeader2.Width = 140;
            // 
            // listViewQuickAccess
            // 
            this.listViewQuickAccess.BackColor = System.Drawing.SystemColors.HotTrack;
            this.listViewQuickAccess.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewQuickAccess.Dock = System.Windows.Forms.DockStyle.Top;
            this.listViewQuickAccess.FullRowSelect = true;
            this.listViewQuickAccess.HideSelection = false;
            this.listViewQuickAccess.Location = new System.Drawing.Point(0, 0);
            this.listViewQuickAccess.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.listViewQuickAccess.Name = "listViewQuickAccess";
            this.listViewQuickAccess.Size = new System.Drawing.Size(144, 120);
            this.listViewQuickAccess.TabIndex = 2;
            this.listViewQuickAccess.UseCompatibleStateImageBehavior = false;
            this.listViewQuickAccess.View = System.Windows.Forms.View.Details;
            this.listViewQuickAccess.SelectedIndexChanged += new System.EventHandler(this.listViewQuickAccess_SelectedIndexChanged);
            this.listViewQuickAccess.Click += new System.EventHandler(this.listViewQuickAccess_Click);
            this.listViewQuickAccess.Leave += new System.EventHandler(this.listViewQuickAccess_Leave);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Quick Access :";
            this.columnHeader1.Width = 140;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(40, 17);
            this.toolStripStatusLabel1.Text = "0 Item";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(87, 17);
            this.toolStripStatusLabel2.Text = "0 Item Selected";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel_ListDirectory);
            this.Controls.Add(this.panel_Top);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "Explorer Tab";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel_ListDirectory.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_Reload;
        private System.Windows.Forms.TextBox tb_Path;
        private System.Windows.Forms.Button btn_Forward;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Panel panel_ListDirectory;
        private System.Windows.Forms.ListView listViewQuickAccess;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView listViewListDisk;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}

