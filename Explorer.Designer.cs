namespace FinanceManager
{
    partial class Explorer
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
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.metroTabControl2 = new MetroFramework.Controls.MetroTabControl();
            this.BankAccountsPage = new MetroFramework.Controls.MetroTabPage();
            this.BankAccountsContext = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.показатьИнформациюПоСчетуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьСчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьСчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PlasticCardsPage = new MetroFramework.Controls.MetroTabPage();
            this.PlasticCardContextMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.информацияОКартеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьПластиковуюКартуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьПластиковуюКартуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.OperationsList = new MetroFramework.Controls.MetroListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OperationsContextMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.добавитьОперациюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьОперациюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.metroTabControl2.SuspendLayout();
            this.BankAccountsContext.SuspendLayout();
            this.PlasticCardContextMenu.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.OperationsContextMenu.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.metroTabControl2);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(752, 305);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Счета";
            // 
            // metroTabControl2
            // 
            this.metroTabControl2.Controls.Add(this.BankAccountsPage);
            this.metroTabControl2.Controls.Add(this.PlasticCardsPage);
            this.metroTabControl2.Controls.Add(this.metroTabPage3);
            this.metroTabControl2.Controls.Add(this.metroTabPage4);
            this.metroTabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl2.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl2.Name = "metroTabControl2";
            this.metroTabControl2.SelectedIndex = 1;
            this.metroTabControl2.Size = new System.Drawing.Size(752, 305);
            this.metroTabControl2.TabIndex = 0;
            this.metroTabControl2.UseSelectable = true;
            // 
            // BankAccountsPage
            // 
            this.BankAccountsPage.ContextMenuStrip = this.BankAccountsContext;
            this.BankAccountsPage.HorizontalScrollbarBarColor = true;
            this.BankAccountsPage.HorizontalScrollbarHighlightOnWheel = false;
            this.BankAccountsPage.HorizontalScrollbarSize = 10;
            this.BankAccountsPage.Location = new System.Drawing.Point(4, 38);
            this.BankAccountsPage.Name = "BankAccountsPage";
            this.BankAccountsPage.Size = new System.Drawing.Size(744, 263);
            this.BankAccountsPage.TabIndex = 0;
            this.BankAccountsPage.Text = "Банковские счета";
            this.BankAccountsPage.VerticalScrollbar = true;
            this.BankAccountsPage.VerticalScrollbarBarColor = true;
            this.BankAccountsPage.VerticalScrollbarHighlightOnWheel = true;
            this.BankAccountsPage.VerticalScrollbarSize = 10;
            // 
            // BankAccountsContext
            // 
            this.BankAccountsContext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BankAccountsContext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BankAccountsContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.показатьИнформациюПоСчетуToolStripMenuItem,
            this.добавитьСчетToolStripMenuItem,
            this.удалитьСчетToolStripMenuItem});
            this.BankAccountsContext.Name = "BankAccountsContext";
            this.BankAccountsContext.Size = new System.Drawing.Size(254, 70);
            // 
            // показатьИнформациюПоСчетуToolStripMenuItem
            // 
            this.показатьИнформациюПоСчетуToolStripMenuItem.Name = "показатьИнформациюПоСчетуToolStripMenuItem";
            this.показатьИнформациюПоСчетуToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.показатьИнформациюПоСчетуToolStripMenuItem.Text = "Показать информацию по счету";
            this.показатьИнформациюПоСчетуToolStripMenuItem.Click += new System.EventHandler(this.показатьИнформациюПоСчетуToolStripMenuItem_Click);
            // 
            // добавитьСчетToolStripMenuItem
            // 
            this.добавитьСчетToolStripMenuItem.Name = "добавитьСчетToolStripMenuItem";
            this.добавитьСчетToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.добавитьСчетToolStripMenuItem.Text = "Добавить счет";
            this.добавитьСчетToolStripMenuItem.Click += new System.EventHandler(this.добавитьСчетToolStripMenuItem_Click);
            // 
            // удалитьСчетToolStripMenuItem
            // 
            this.удалитьСчетToolStripMenuItem.Name = "удалитьСчетToolStripMenuItem";
            this.удалитьСчетToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.удалитьСчетToolStripMenuItem.Text = "Удалить счет";
            this.удалитьСчетToolStripMenuItem.Click += new System.EventHandler(this.удалитьСчетToolStripMenuItem_Click);
            // 
            // PlasticCardsPage
            // 
            this.PlasticCardsPage.ContextMenuStrip = this.PlasticCardContextMenu;
            this.PlasticCardsPage.HorizontalScrollbarBarColor = true;
            this.PlasticCardsPage.HorizontalScrollbarHighlightOnWheel = false;
            this.PlasticCardsPage.HorizontalScrollbarSize = 10;
            this.PlasticCardsPage.Location = new System.Drawing.Point(4, 38);
            this.PlasticCardsPage.Name = "PlasticCardsPage";
            this.PlasticCardsPage.Size = new System.Drawing.Size(744, 263);
            this.PlasticCardsPage.TabIndex = 1;
            this.PlasticCardsPage.Text = "Пластиковые карточки";
            this.PlasticCardsPage.VerticalScrollbarBarColor = true;
            this.PlasticCardsPage.VerticalScrollbarHighlightOnWheel = false;
            this.PlasticCardsPage.VerticalScrollbarSize = 10;
            // 
            // PlasticCardContextMenu
            // 
            this.PlasticCardContextMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PlasticCardContextMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PlasticCardContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.информацияОКартеToolStripMenuItem,
            this.добавитьПластиковуюКартуToolStripMenuItem,
            this.удалитьПластиковуюКартуToolStripMenuItem});
            this.PlasticCardContextMenu.Name = "PlasticCardContextMenu";
            this.PlasticCardContextMenu.Size = new System.Drawing.Size(236, 70);
            // 
            // информацияОКартеToolStripMenuItem
            // 
            this.информацияОКартеToolStripMenuItem.Name = "информацияОКартеToolStripMenuItem";
            this.информацияОКартеToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.информацияОКартеToolStripMenuItem.Text = "Информация о карте";
            this.информацияОКартеToolStripMenuItem.Click += new System.EventHandler(this.информацияОКартеToolStripMenuItem_Click);
            // 
            // добавитьПластиковуюКартуToolStripMenuItem
            // 
            this.добавитьПластиковуюКартуToolStripMenuItem.Name = "добавитьПластиковуюКартуToolStripMenuItem";
            this.добавитьПластиковуюКартуToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.добавитьПластиковуюКартуToolStripMenuItem.Text = "Добавить пластиковую карту";
            this.добавитьПластиковуюКартуToolStripMenuItem.Click += new System.EventHandler(this.добавитьПластиковуюКартуToolStripMenuItem_Click);
            // 
            // удалитьПластиковуюКартуToolStripMenuItem
            // 
            this.удалитьПластиковуюКартуToolStripMenuItem.Name = "удалитьПластиковуюКартуToolStripMenuItem";
            this.удалитьПластиковуюКартуToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.удалитьПластиковуюКартуToolStripMenuItem.Text = "Удалить пластиковую карту";
            this.удалитьПластиковуюКартуToolStripMenuItem.Click += new System.EventHandler(this.удалитьПластиковуюКартуToolStripMenuItem_Click);
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(744, 263);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Криптовалютные кошельки";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.HorizontalScrollbarSize = 10;
            this.metroTabPage4.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Size = new System.Drawing.Size(744, 263);
            this.metroTabPage4.TabIndex = 3;
            this.metroTabPage4.Text = "Остальное";
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            this.metroTabPage4.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.VerticalScrollbarSize = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.OperationsList);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(752, 305);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Операции";
            // 
            // OperationsList
            // 
            this.OperationsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.OperationsList.ContextMenuStrip = this.OperationsContextMenu;
            this.OperationsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OperationsList.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.OperationsList.FullRowSelect = true;
            this.OperationsList.Location = new System.Drawing.Point(0, 0);
            this.OperationsList.Name = "OperationsList";
            this.OperationsList.OwnerDraw = true;
            this.OperationsList.Scrollable = false;
            this.OperationsList.Size = new System.Drawing.Size(752, 305);
            this.OperationsList.TabIndex = 0;
            this.OperationsList.UseCompatibleStateImageBehavior = false;
            this.OperationsList.UseSelectable = true;
            this.OperationsList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Номер операции";
            this.columnHeader1.Width = 147;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Наименование операции";
            this.columnHeader2.Width = 206;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Откуда";
            this.columnHeader3.Width = 127;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Куда";
            this.columnHeader4.Width = 121;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Сумма";
            this.columnHeader5.Width = 105;
            // 
            // OperationsContextMenu
            // 
            this.OperationsContextMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.OperationsContextMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.OperationsContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьОперациюToolStripMenuItem,
            this.удалитьОперациюToolStripMenuItem});
            this.OperationsContextMenu.Name = "OperationsContextMenu";
            this.OperationsContextMenu.Size = new System.Drawing.Size(187, 48);
            // 
            // добавитьОперациюToolStripMenuItem
            // 
            this.добавитьОперациюToolStripMenuItem.Name = "добавитьОперациюToolStripMenuItem";
            this.добавитьОперациюToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.добавитьОперациюToolStripMenuItem.Text = "Добавить операцию";
            this.добавитьОперациюToolStripMenuItem.Click += new System.EventHandler(this.добавитьОперациюToolStripMenuItem_Click);
            // 
            // удалитьОперациюToolStripMenuItem
            // 
            this.удалитьОперациюToolStripMenuItem.Name = "удалитьОперациюToolStripMenuItem";
            this.удалитьОперациюToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.удалитьОперациюToolStripMenuItem.Text = "Удалить операцию";
            this.удалитьОперациюToolStripMenuItem.Click += new System.EventHandler(this.удалитьОперациюToolStripMenuItem_Click);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabPage1);
            this.metroTabControl1.Controls.Add(this.tabPage2);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(760, 347);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.SizeChanged += new System.EventHandler(this.metroTabControl1_Resize);
            this.metroTabControl1.Resize += new System.EventHandler(this.metroTabControl1_Resize);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(618, 5);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(100, 19);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "Настройки";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Explorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 427);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroTabControl1);
            this.MinimumSize = new System.Drawing.Size(652, 0);
            this.Name = "Explorer";
            this.Text = "Обозреватель";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Resize += new System.EventHandler(this.Form2_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.metroTabControl2.ResumeLayout(false);
            this.BankAccountsContext.ResumeLayout(false);
            this.PlasticCardContextMenu.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.OperationsContextMenu.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private MetroFramework.Controls.MetroTabControl metroTabControl2;
        private MetroFramework.Controls.MetroTabPage PlasticCardsPage;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroTabPage metroTabPage4;
        private MetroFramework.Controls.MetroContextMenu BankAccountsContext;
        private System.Windows.Forms.ToolStripMenuItem добавитьСчетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьСчетToolStripMenuItem;
        private MetroFramework.Controls.MetroContextMenu PlasticCardContextMenu;
        private System.Windows.Forms.ToolStripMenuItem добавитьПластиковуюКартуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьПластиковуюКартуToolStripMenuItem;
        public MetroFramework.Controls.MetroTabPage BankAccountsPage;
        private MetroFramework.Controls.MetroContextMenu OperationsContextMenu;
        private System.Windows.Forms.ToolStripMenuItem добавитьОперациюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьОперациюToolStripMenuItem;
        public MetroFramework.Controls.MetroListView OperationsList;
        public MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.ToolStripMenuItem показатьИнформациюПоСчетуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияОКартеToolStripMenuItem;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}