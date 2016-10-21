namespace EzDrink
{
    partial class EzDrinkForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this._menuStrip = new System.Windows.Forms.MenuStrip();
            this._fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._tabControl = new System.Windows.Forms.TabControl();
            this._orderSystemTabPage = new System.Windows.Forms.TabPage();
            this._orderSystemTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._orderGroupBox = new System.Windows.Forms.GroupBox();
            this._orderDataGridView = new System.Windows.Forms.DataGridView();
            this._categoryGroupBox = new System.Windows.Forms.GroupBox();
            this._categoryDataGridView = new System.Windows.Forms.DataGridView();
            this._additionGroupBox = new System.Windows.Forms.GroupBox();
            this._additionDataGridView = new System.Windows.Forms.DataGridView();
            this._sugarGroupBox = new System.Windows.Forms.GroupBox();
            this._sugarTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._halfSugarButton = new System.Windows.Forms.Button();
            this._normalSugarButton = new System.Windows.Forms.Button();
            this._lessSugarButton = new System.Windows.Forms.Button();
            this._noSugarButton = new System.Windows.Forms.Button();
            this._temperatureGroupBox = new System.Windows.Forms.GroupBox();
            this._temperatureTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._hotButton = new System.Windows.Forms.Button();
            this._normalIceButton = new System.Windows.Forms.Button();
            this._noIceButton = new System.Windows.Forms.Button();
            this._lessIceButton = new System.Windows.Forms.Button();
            this._payTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._payButton = new System.Windows.Forms.Button();
            this._totalPriceLabel = new System.Windows.Forms.Label();
            this._managementSystemTabPage = new System.Windows.Forms.TabPage();
            this._managementSystemTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._drinkListGroupBox = new System.Windows.Forms.GroupBox();
            this._drinkListDataGridView = new System.Windows.Forms.DataGridView();
            this._additionListGroupBox = new System.Windows.Forms.GroupBox();
            this._additionListDataGridView = new System.Windows.Forms.DataGridView();
            this._drinkManipulateGroupBox = new System.Windows.Forms.GroupBox();
            this._additionManipulateGroupBox = new System.Windows.Forms.GroupBox();
            this._drinkButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this._drinkNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._drinkPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._additionButtonColumn = new EzDrink.DataGridViewDisableButtonColumn();
            this._additionNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._additionPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._orderNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._orderPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._orderSugarColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._orderTemperatureColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._orderAdditionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._orderButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this._menuStrip.SuspendLayout();
            this._tabControl.SuspendLayout();
            this._orderSystemTabPage.SuspendLayout();
            this._orderSystemTableLayoutPanel.SuspendLayout();
            this._orderGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._orderDataGridView)).BeginInit();
            this._categoryGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._categoryDataGridView)).BeginInit();
            this._additionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._additionDataGridView)).BeginInit();
            this._sugarGroupBox.SuspendLayout();
            this._sugarTableLayoutPanel.SuspendLayout();
            this._temperatureGroupBox.SuspendLayout();
            this._temperatureTableLayoutPanel.SuspendLayout();
            this._payTableLayoutPanel.SuspendLayout();
            this._managementSystemTabPage.SuspendLayout();
            this._managementSystemTableLayoutPanel.SuspendLayout();
            this._drinkListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._drinkListDataGridView)).BeginInit();
            this._additionListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._additionListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _menuStrip
            // 
            this._menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._fileToolStripMenuItem,
            this._helpToolStripMenuItem});
            this._menuStrip.Location = new System.Drawing.Point(0, 0);
            this._menuStrip.Name = "_menuStrip";
            this._menuStrip.Size = new System.Drawing.Size(884, 24);
            this._menuStrip.TabIndex = 0;
            this._menuStrip.Text = "menuStrip";
            // 
            // _fileToolStripMenuItem
            // 
            this._fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._exitToolStripMenuItem});
            this._fileToolStripMenuItem.Name = "_fileToolStripMenuItem";
            this._fileToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this._fileToolStripMenuItem.Text = "File";
            // 
            // _exitToolStripMenuItem
            // 
            this._exitToolStripMenuItem.Name = "_exitToolStripMenuItem";
            this._exitToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this._exitToolStripMenuItem.Text = "Exit";
            this._exitToolStripMenuItem.Click += new System.EventHandler(this.ClickExitToolStripMenuItem);
            // 
            // _helpToolStripMenuItem
            // 
            this._helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._aboutToolStripMenuItem});
            this._helpToolStripMenuItem.Name = "_helpToolStripMenuItem";
            this._helpToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this._helpToolStripMenuItem.Text = "Help";
            // 
            // _aboutToolStripMenuItem
            // 
            this._aboutToolStripMenuItem.Name = "_aboutToolStripMenuItem";
            this._aboutToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this._aboutToolStripMenuItem.Text = "About";
            this._aboutToolStripMenuItem.Click += new System.EventHandler(this._aboutToolStripMenuItem_Click);
            // 
            // _tabControl
            // 
            this._tabControl.Controls.Add(this._orderSystemTabPage);
            this._tabControl.Controls.Add(this._managementSystemTabPage);
            this._tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tabControl.Location = new System.Drawing.Point(0, 24);
            this._tabControl.Name = "_tabControl";
            this._tabControl.SelectedIndex = 0;
            this._tabControl.Size = new System.Drawing.Size(884, 517);
            this._tabControl.TabIndex = 1;
            // 
            // _orderSystemTabPage
            // 
            this._orderSystemTabPage.Controls.Add(this._orderSystemTableLayoutPanel);
            this._orderSystemTabPage.Location = new System.Drawing.Point(4, 22);
            this._orderSystemTabPage.Name = "_orderSystemTabPage";
            this._orderSystemTabPage.Padding = new System.Windows.Forms.Padding(3);
            this._orderSystemTabPage.Size = new System.Drawing.Size(876, 491);
            this._orderSystemTabPage.TabIndex = 0;
            this._orderSystemTabPage.Text = "點餐系統";
            this._orderSystemTabPage.UseVisualStyleBackColor = true;
            // 
            // _orderSystemTableLayoutPanel
            // 
            this._orderSystemTableLayoutPanel.ColumnCount = 5;
            this._orderSystemTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.52264F));
            this._orderSystemTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.39544F));
            this._orderSystemTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.52264F));
            this._orderSystemTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.39544F));
            this._orderSystemTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.16385F));
            this._orderSystemTableLayoutPanel.Controls.Add(this._orderGroupBox, 4, 0);
            this._orderSystemTableLayoutPanel.Controls.Add(this._categoryGroupBox, 0, 0);
            this._orderSystemTableLayoutPanel.Controls.Add(this._additionGroupBox, 2, 0);
            this._orderSystemTableLayoutPanel.Controls.Add(this._sugarGroupBox, 2, 1);
            this._orderSystemTableLayoutPanel.Controls.Add(this._temperatureGroupBox, 2, 3);
            this._orderSystemTableLayoutPanel.Controls.Add(this._payTableLayoutPanel, 4, 4);
            this._orderSystemTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._orderSystemTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this._orderSystemTableLayoutPanel.Name = "_orderSystemTableLayoutPanel";
            this._orderSystemTableLayoutPanel.RowCount = 5;
            this._orderSystemTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._orderSystemTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this._orderSystemTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this._orderSystemTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this._orderSystemTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this._orderSystemTableLayoutPanel.Size = new System.Drawing.Size(870, 485);
            this._orderSystemTableLayoutPanel.TabIndex = 2;
            // 
            // _orderGroupBox
            // 
            this._orderGroupBox.Controls.Add(this._orderDataGridView);
            this._orderGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._orderGroupBox.Location = new System.Drawing.Point(521, 3);
            this._orderGroupBox.Name = "_orderGroupBox";
            this._orderSystemTableLayoutPanel.SetRowSpan(this._orderGroupBox, 4);
            this._orderGroupBox.Size = new System.Drawing.Size(346, 416);
            this._orderGroupBox.TabIndex = 1;
            this._orderGroupBox.TabStop = false;
            this._orderGroupBox.Text = "點單";
            // 
            // _orderDataGridView
            // 
            this._orderDataGridView.AllowUserToAddRows = false;
            this._orderDataGridView.AllowUserToResizeColumns = false;
            this._orderDataGridView.AllowUserToResizeRows = false;
            this._orderDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._orderDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._orderDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this._orderDataGridView.ColumnHeadersHeight = 20;
            this._orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this._orderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._orderNameColumn,
            this._orderPriceColumn,
            this._orderSugarColumn,
            this._orderTemperatureColumn,
            this._orderAdditionColumn,
            this._orderButtonColumn});
            this._orderDataGridView.Location = new System.Drawing.Point(5, 21);
            this._orderDataGridView.Name = "_orderDataGridView";
            this._orderDataGridView.ReadOnly = true;
            this._orderDataGridView.RowHeadersVisible = false;
            this._orderDataGridView.RowTemplate.Height = 24;
            this._orderDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this._orderDataGridView.Size = new System.Drawing.Size(336, 389);
            this._orderDataGridView.TabIndex = 0;
            this._orderDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickOrderDataGridViewCellContent);
            this._orderDataGridView.Click += new System.EventHandler(this.ClickOrderDataGridView);
            // 
            // _categoryGroupBox
            // 
            this._categoryGroupBox.Controls.Add(this._categoryDataGridView);
            this._categoryGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._categoryGroupBox.Location = new System.Drawing.Point(3, 3);
            this._categoryGroupBox.Name = "_categoryGroupBox";
            this._orderSystemTableLayoutPanel.SetRowSpan(this._categoryGroupBox, 5);
            this._categoryGroupBox.Size = new System.Drawing.Size(233, 479);
            this._categoryGroupBox.TabIndex = 0;
            this._categoryGroupBox.TabStop = false;
            this._categoryGroupBox.Text = "飲料";
            // 
            // _categoryDataGridView
            // 
            this._categoryDataGridView.AllowUserToAddRows = false;
            this._categoryDataGridView.AllowUserToResizeColumns = false;
            this._categoryDataGridView.AllowUserToResizeRows = false;
            this._categoryDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._categoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._categoryDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this._categoryDataGridView.ColumnHeadersHeight = 20;
            this._categoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this._categoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._drinkButtonColumn,
            this._drinkNameColumn,
            this._drinkPriceColumn});
            this._categoryDataGridView.Location = new System.Drawing.Point(5, 21);
            this._categoryDataGridView.Name = "_categoryDataGridView";
            this._categoryDataGridView.ReadOnly = true;
            this._categoryDataGridView.RowHeadersVisible = false;
            this._categoryDataGridView.RowTemplate.Height = 24;
            this._categoryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this._categoryDataGridView.Size = new System.Drawing.Size(223, 452);
            this._categoryDataGridView.TabIndex = 0;
            this._categoryDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickCategoryDataGridViewCellContent);
            // 
            // _additionGroupBox
            // 
            this._additionGroupBox.Controls.Add(this._additionDataGridView);
            this._additionGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._additionGroupBox.Location = new System.Drawing.Point(262, 3);
            this._additionGroupBox.Name = "_additionGroupBox";
            this._additionGroupBox.Size = new System.Drawing.Size(233, 236);
            this._additionGroupBox.TabIndex = 2;
            this._additionGroupBox.TabStop = false;
            this._additionGroupBox.Text = "加料";
            // 
            // _additionDataGridView
            // 
            this._additionDataGridView.AllowUserToAddRows = false;
            this._additionDataGridView.AllowUserToResizeColumns = false;
            this._additionDataGridView.AllowUserToResizeRows = false;
            this._additionDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._additionDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._additionDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this._additionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._additionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._additionButtonColumn,
            this._additionNameColumn,
            this._additionPriceColumn});
            this._additionDataGridView.Location = new System.Drawing.Point(5, 21);
            this._additionDataGridView.Name = "_additionDataGridView";
            this._additionDataGridView.ReadOnly = true;
            this._additionDataGridView.RowHeadersVisible = false;
            this._additionDataGridView.RowTemplate.Height = 24;
            this._additionDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this._additionDataGridView.Size = new System.Drawing.Size(223, 209);
            this._additionDataGridView.TabIndex = 0;
            this._additionDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickAdditionDataGridViewCellContent);
            // 
            // _sugarGroupBox
            // 
            this._sugarGroupBox.Controls.Add(this._sugarTableLayoutPanel);
            this._sugarGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._sugarGroupBox.Location = new System.Drawing.Point(262, 245);
            this._sugarGroupBox.Name = "_sugarGroupBox";
            this._orderSystemTableLayoutPanel.SetRowSpan(this._sugarGroupBox, 2);
            this._sugarGroupBox.Size = new System.Drawing.Size(233, 114);
            this._sugarGroupBox.TabIndex = 3;
            this._sugarGroupBox.TabStop = false;
            this._sugarGroupBox.Text = "甜度";
            // 
            // _sugarTableLayoutPanel
            // 
            this._sugarTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._sugarTableLayoutPanel.ColumnCount = 3;
            this._sugarTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.6F));
            this._sugarTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.8F));
            this._sugarTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.6F));
            this._sugarTableLayoutPanel.Controls.Add(this._halfSugarButton, 2, 0);
            this._sugarTableLayoutPanel.Controls.Add(this._normalSugarButton, 0, 0);
            this._sugarTableLayoutPanel.Controls.Add(this._lessSugarButton, 0, 2);
            this._sugarTableLayoutPanel.Controls.Add(this._noSugarButton, 2, 2);
            this._sugarTableLayoutPanel.Location = new System.Drawing.Point(5, 13);
            this._sugarTableLayoutPanel.Name = "_sugarTableLayoutPanel";
            this._sugarTableLayoutPanel.RowCount = 3;
            this._sugarTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.20005F));
            this._sugarTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.59991F));
            this._sugarTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.20005F));
            this._sugarTableLayoutPanel.Size = new System.Drawing.Size(223, 95);
            this._sugarTableLayoutPanel.TabIndex = 4;
            // 
            // _halfSugarButton
            // 
            this._halfSugarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._halfSugarButton.Location = new System.Drawing.Point(119, 3);
            this._halfSugarButton.Name = "_halfSugarButton";
            this._halfSugarButton.Size = new System.Drawing.Size(101, 35);
            this._halfSugarButton.TabIndex = 1;
            this._halfSugarButton.Text = "半糖";
            this._halfSugarButton.UseVisualStyleBackColor = true;
            this._halfSugarButton.Click += new System.EventHandler(this.ClickHalfSugarButton);
            // 
            // _normalSugarButton
            // 
            this._normalSugarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._normalSugarButton.Location = new System.Drawing.Point(3, 3);
            this._normalSugarButton.Name = "_normalSugarButton";
            this._normalSugarButton.Size = new System.Drawing.Size(100, 35);
            this._normalSugarButton.TabIndex = 0;
            this._normalSugarButton.Text = "正常";
            this._normalSugarButton.UseVisualStyleBackColor = true;
            this._normalSugarButton.Click += new System.EventHandler(this.ClickNormalSugarButton);
            // 
            // _lessSugarButton
            // 
            this._lessSugarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._lessSugarButton.Location = new System.Drawing.Point(3, 55);
            this._lessSugarButton.Name = "_lessSugarButton";
            this._lessSugarButton.Size = new System.Drawing.Size(100, 37);
            this._lessSugarButton.TabIndex = 2;
            this._lessSugarButton.Text = "微糖";
            this._lessSugarButton.UseVisualStyleBackColor = true;
            this._lessSugarButton.Click += new System.EventHandler(this.ClickLessSugarButton);
            // 
            // _noSugarButton
            // 
            this._noSugarButton.Location = new System.Drawing.Point(119, 55);
            this._noSugarButton.Name = "_noSugarButton";
            this._noSugarButton.Size = new System.Drawing.Size(101, 37);
            this._noSugarButton.TabIndex = 3;
            this._noSugarButton.Text = "無糖";
            this._noSugarButton.UseVisualStyleBackColor = true;
            this._noSugarButton.Click += new System.EventHandler(this.ClickNoSugarButton);
            // 
            // _temperatureGroupBox
            // 
            this._temperatureGroupBox.Controls.Add(this._temperatureTableLayoutPanel);
            this._temperatureGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._temperatureGroupBox.Location = new System.Drawing.Point(262, 365);
            this._temperatureGroupBox.Name = "_temperatureGroupBox";
            this._orderSystemTableLayoutPanel.SetRowSpan(this._temperatureGroupBox, 2);
            this._temperatureGroupBox.Size = new System.Drawing.Size(233, 117);
            this._temperatureGroupBox.TabIndex = 4;
            this._temperatureGroupBox.TabStop = false;
            this._temperatureGroupBox.Text = "溫度";
            // 
            // _temperatureTableLayoutPanel
            // 
            this._temperatureTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._temperatureTableLayoutPanel.ColumnCount = 3;
            this._temperatureTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.6F));
            this._temperatureTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.8F));
            this._temperatureTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.6F));
            this._temperatureTableLayoutPanel.Controls.Add(this._hotButton, 2, 2);
            this._temperatureTableLayoutPanel.Controls.Add(this._normalIceButton, 0, 0);
            this._temperatureTableLayoutPanel.Controls.Add(this._noIceButton, 0, 2);
            this._temperatureTableLayoutPanel.Controls.Add(this._lessIceButton, 2, 0);
            this._temperatureTableLayoutPanel.Location = new System.Drawing.Point(5, 15);
            this._temperatureTableLayoutPanel.Name = "_temperatureTableLayoutPanel";
            this._temperatureTableLayoutPanel.RowCount = 3;
            this._temperatureTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.20005F));
            this._temperatureTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.59991F));
            this._temperatureTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.20005F));
            this._temperatureTableLayoutPanel.Size = new System.Drawing.Size(223, 95);
            this._temperatureTableLayoutPanel.TabIndex = 5;
            // 
            // _hotButton
            // 
            this._hotButton.Location = new System.Drawing.Point(119, 55);
            this._hotButton.Name = "_hotButton";
            this._hotButton.Size = new System.Drawing.Size(101, 37);
            this._hotButton.TabIndex = 3;
            this._hotButton.Text = "溫熱";
            this._hotButton.UseVisualStyleBackColor = true;
            this._hotButton.Click += new System.EventHandler(this.ClickHotButton);
            // 
            // _normalIceButton
            // 
            this._normalIceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._normalIceButton.Location = new System.Drawing.Point(3, 3);
            this._normalIceButton.Name = "_normalIceButton";
            this._normalIceButton.Size = new System.Drawing.Size(100, 35);
            this._normalIceButton.TabIndex = 0;
            this._normalIceButton.Text = "正常";
            this._normalIceButton.UseVisualStyleBackColor = true;
            this._normalIceButton.Click += new System.EventHandler(this.ClickNormalIceButton);
            // 
            // _noIceButton
            // 
            this._noIceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._noIceButton.Location = new System.Drawing.Point(3, 55);
            this._noIceButton.Name = "_noIceButton";
            this._noIceButton.Size = new System.Drawing.Size(100, 37);
            this._noIceButton.TabIndex = 2;
            this._noIceButton.Text = "去冰";
            this._noIceButton.UseVisualStyleBackColor = true;
            this._noIceButton.Click += new System.EventHandler(this.ClickNoIceButton);
            // 
            // _lessIceButton
            // 
            this._lessIceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._lessIceButton.Location = new System.Drawing.Point(119, 3);
            this._lessIceButton.Name = "_lessIceButton";
            this._lessIceButton.Size = new System.Drawing.Size(101, 35);
            this._lessIceButton.TabIndex = 1;
            this._lessIceButton.Text = "少冰";
            this._lessIceButton.UseVisualStyleBackColor = true;
            this._lessIceButton.Click += new System.EventHandler(this.ClickLessIceButton);
            // 
            // _payTableLayoutPanel
            // 
            this._payTableLayoutPanel.ColumnCount = 2;
            this._payTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this._payTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this._payTableLayoutPanel.Controls.Add(this._payButton, 1, 0);
            this._payTableLayoutPanel.Controls.Add(this._totalPriceLabel, 0, 0);
            this._payTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._payTableLayoutPanel.Location = new System.Drawing.Point(521, 425);
            this._payTableLayoutPanel.Name = "_payTableLayoutPanel";
            this._payTableLayoutPanel.RowCount = 1;
            this._payTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._payTableLayoutPanel.Size = new System.Drawing.Size(346, 57);
            this._payTableLayoutPanel.TabIndex = 5;
            // 
            // _payButton
            // 
            this._payButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._payButton.Location = new System.Drawing.Point(245, 3);
            this._payButton.Name = "_payButton";
            this._payButton.Size = new System.Drawing.Size(98, 51);
            this._payButton.TabIndex = 0;
            this._payButton.Text = "結帳";
            this._payButton.UseVisualStyleBackColor = true;
            this._payButton.Click += new System.EventHandler(this.ClickPayButton);
            // 
            // _totalPriceLabel
            // 
            this._totalPriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._totalPriceLabel.AutoSize = true;
            this._totalPriceLabel.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._totalPriceLabel.Location = new System.Drawing.Point(3, 15);
            this._totalPriceLabel.Name = "_totalPriceLabel";
            this._totalPriceLabel.Size = new System.Drawing.Size(236, 27);
            this._totalPriceLabel.TabIndex = 5;
            this._totalPriceLabel.Text = "總價 : ";
            this._totalPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _managementSystemTabPage
            // 
            this._managementSystemTabPage.Controls.Add(this._managementSystemTableLayoutPanel);
            this._managementSystemTabPage.Location = new System.Drawing.Point(4, 22);
            this._managementSystemTabPage.Name = "_managementSystemTabPage";
            this._managementSystemTabPage.Padding = new System.Windows.Forms.Padding(3);
            this._managementSystemTabPage.Size = new System.Drawing.Size(876, 491);
            this._managementSystemTabPage.TabIndex = 1;
            this._managementSystemTabPage.Text = "後台管理";
            this._managementSystemTabPage.UseVisualStyleBackColor = true;
            // 
            // _managementSystemTableLayoutPanel
            // 
            this._managementSystemTableLayoutPanel.ColumnCount = 5;
            this._managementSystemTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this._managementSystemTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this._managementSystemTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this._managementSystemTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this._managementSystemTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this._managementSystemTableLayoutPanel.Controls.Add(this._drinkListGroupBox, 0, 0);
            this._managementSystemTableLayoutPanel.Controls.Add(this._additionListGroupBox, 4, 0);
            this._managementSystemTableLayoutPanel.Controls.Add(this._drinkManipulateGroupBox, 2, 0);
            this._managementSystemTableLayoutPanel.Controls.Add(this._additionManipulateGroupBox, 2, 1);
            this._managementSystemTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._managementSystemTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this._managementSystemTableLayoutPanel.Name = "_managementSystemTableLayoutPanel";
            this._managementSystemTableLayoutPanel.RowCount = 2;
            this._managementSystemTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._managementSystemTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._managementSystemTableLayoutPanel.Size = new System.Drawing.Size(870, 485);
            this._managementSystemTableLayoutPanel.TabIndex = 0;
            // 
            // _drinkListGroupBox
            // 
            this._drinkListGroupBox.Controls.Add(this._drinkListDataGridView);
            this._drinkListGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._drinkListGroupBox.Location = new System.Drawing.Point(3, 3);
            this._drinkListGroupBox.Name = "_drinkListGroupBox";
            this._managementSystemTableLayoutPanel.SetRowSpan(this._drinkListGroupBox, 2);
            this._drinkListGroupBox.Size = new System.Drawing.Size(289, 479);
            this._drinkListGroupBox.TabIndex = 0;
            this._drinkListGroupBox.TabStop = false;
            this._drinkListGroupBox.Text = "飲料清單";
            // 
            // _drinkListDataGridView
            // 
            this._drinkListDataGridView.AllowUserToAddRows = false;
            this._drinkListDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._drinkListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._drinkListDataGridView.Location = new System.Drawing.Point(5, 21);
            this._drinkListDataGridView.Name = "_drinkListDataGridView";
            this._drinkListDataGridView.ReadOnly = true;
            this._drinkListDataGridView.RowTemplate.Height = 24;
            this._drinkListDataGridView.Size = new System.Drawing.Size(279, 452);
            this._drinkListDataGridView.TabIndex = 0;
            // 
            // _additionListGroupBox
            // 
            this._additionListGroupBox.Controls.Add(this._additionListDataGridView);
            this._additionListGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._additionListGroupBox.Location = new System.Drawing.Point(575, 3);
            this._additionListGroupBox.Name = "_additionListGroupBox";
            this._managementSystemTableLayoutPanel.SetRowSpan(this._additionListGroupBox, 2);
            this._additionListGroupBox.Size = new System.Drawing.Size(292, 479);
            this._additionListGroupBox.TabIndex = 1;
            this._additionListGroupBox.TabStop = false;
            this._additionListGroupBox.Text = "加料清單";
            // 
            // _additionListDataGridView
            // 
            this._additionListDataGridView.AllowUserToAddRows = false;
            this._additionListDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._additionListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._additionListDataGridView.Location = new System.Drawing.Point(5, 21);
            this._additionListDataGridView.Name = "_additionListDataGridView";
            this._additionListDataGridView.ReadOnly = true;
            this._additionListDataGridView.RowTemplate.Height = 24;
            this._additionListDataGridView.Size = new System.Drawing.Size(282, 452);
            this._additionListDataGridView.TabIndex = 1;
            // 
            // _drinkManipulateGroupBox
            // 
            this._drinkManipulateGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._drinkManipulateGroupBox.Location = new System.Drawing.Point(315, 3);
            this._drinkManipulateGroupBox.Name = "_drinkManipulateGroupBox";
            this._drinkManipulateGroupBox.Size = new System.Drawing.Size(237, 236);
            this._drinkManipulateGroupBox.TabIndex = 2;
            this._drinkManipulateGroupBox.TabStop = false;
            this._drinkManipulateGroupBox.Text = "飲料清單操作";
            // 
            // _additionManipulateGroupBox
            // 
            this._additionManipulateGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._additionManipulateGroupBox.Location = new System.Drawing.Point(315, 245);
            this._additionManipulateGroupBox.Name = "_additionManipulateGroupBox";
            this._additionManipulateGroupBox.Size = new System.Drawing.Size(237, 237);
            this._additionManipulateGroupBox.TabIndex = 3;
            this._additionManipulateGroupBox.TabStop = false;
            this._additionManipulateGroupBox.Text = "加料清單操作";
            // 
            // _drinkButtonColumn
            // 
            this._drinkButtonColumn.FillWeight = 40F;
            this._drinkButtonColumn.HeaderText = "";
            this._drinkButtonColumn.Name = "_drinkButtonColumn";
            this._drinkButtonColumn.ReadOnly = true;
            // 
            // _drinkNameColumn
            // 
            this._drinkNameColumn.FillWeight = 110F;
            this._drinkNameColumn.HeaderText = "名稱";
            this._drinkNameColumn.Name = "_drinkNameColumn";
            this._drinkNameColumn.ReadOnly = true;
            this._drinkNameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _drinkPriceColumn
            // 
            this._drinkPriceColumn.FillWeight = 70F;
            this._drinkPriceColumn.HeaderText = "價格";
            this._drinkPriceColumn.Name = "_drinkPriceColumn";
            this._drinkPriceColumn.ReadOnly = true;
            this._drinkPriceColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _additionButtonColumn
            // 
            this._additionButtonColumn.FillWeight = 40F;
            this._additionButtonColumn.HeaderText = "";
            this._additionButtonColumn.Name = "_additionButtonColumn";
            this._additionButtonColumn.ReadOnly = true;
            // 
            // _additionNameColumn
            // 
            this._additionNameColumn.FillWeight = 110F;
            this._additionNameColumn.HeaderText = "名稱";
            this._additionNameColumn.Name = "_additionNameColumn";
            this._additionNameColumn.ReadOnly = true;
            this._additionNameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _additionPriceColumn
            // 
            this._additionPriceColumn.FillWeight = 70F;
            this._additionPriceColumn.HeaderText = "價格";
            this._additionPriceColumn.Name = "_additionPriceColumn";
            this._additionPriceColumn.ReadOnly = true;
            this._additionPriceColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _orderNameColumn
            // 
            this._orderNameColumn.FillWeight = 90F;
            this._orderNameColumn.HeaderText = "飲料名稱";
            this._orderNameColumn.Name = "_orderNameColumn";
            this._orderNameColumn.ReadOnly = true;
            this._orderNameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _orderPriceColumn
            // 
            this._orderPriceColumn.FillWeight = 40F;
            this._orderPriceColumn.HeaderText = "價格";
            this._orderPriceColumn.Name = "_orderPriceColumn";
            this._orderPriceColumn.ReadOnly = true;
            this._orderPriceColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _orderSugarColumn
            // 
            this._orderSugarColumn.FillWeight = 40F;
            this._orderSugarColumn.HeaderText = "甜度";
            this._orderSugarColumn.Name = "_orderSugarColumn";
            this._orderSugarColumn.ReadOnly = true;
            this._orderSugarColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _orderTemperatureColumn
            // 
            this._orderTemperatureColumn.FillWeight = 40F;
            this._orderTemperatureColumn.HeaderText = "溫度";
            this._orderTemperatureColumn.Name = "_orderTemperatureColumn";
            this._orderTemperatureColumn.ReadOnly = true;
            this._orderTemperatureColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _orderAdditionColumn
            // 
            this._orderAdditionColumn.FillWeight = 83F;
            this._orderAdditionColumn.HeaderText = "加料";
            this._orderAdditionColumn.Name = "_orderAdditionColumn";
            this._orderAdditionColumn.ReadOnly = true;
            this._orderAdditionColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _orderButtonColumn
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "刪除";
            this._orderButtonColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this._orderButtonColumn.FillWeight = 40F;
            this._orderButtonColumn.HeaderText = "";
            this._orderButtonColumn.Name = "_orderButtonColumn";
            this._orderButtonColumn.ReadOnly = true;
            // 
            // EzDrinkForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(884, 541);
            this.Controls.Add(this._tabControl);
            this.Controls.Add(this._menuStrip);
            this.MinimumSize = new System.Drawing.Size(900, 580);
            this.Name = "EzDrinkForm";
            this.Text = "EzDrink";
            this._menuStrip.ResumeLayout(false);
            this._menuStrip.PerformLayout();
            this._tabControl.ResumeLayout(false);
            this._orderSystemTabPage.ResumeLayout(false);
            this._orderSystemTableLayoutPanel.ResumeLayout(false);
            this._orderGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._orderDataGridView)).EndInit();
            this._categoryGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._categoryDataGridView)).EndInit();
            this._additionGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._additionDataGridView)).EndInit();
            this._sugarGroupBox.ResumeLayout(false);
            this._sugarTableLayoutPanel.ResumeLayout(false);
            this._temperatureGroupBox.ResumeLayout(false);
            this._temperatureTableLayoutPanel.ResumeLayout(false);
            this._payTableLayoutPanel.ResumeLayout(false);
            this._payTableLayoutPanel.PerformLayout();
            this._managementSystemTabPage.ResumeLayout(false);
            this._managementSystemTableLayoutPanel.ResumeLayout(false);
            this._drinkListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._drinkListDataGridView)).EndInit();
            this._additionListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._additionListDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip _menuStrip;
        private System.Windows.Forms.ToolStripMenuItem _fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _aboutToolStripMenuItem;
        private System.Windows.Forms.TabControl _tabControl;
        private System.Windows.Forms.TabPage _orderSystemTabPage;
        private System.Windows.Forms.TabPage _managementSystemTabPage;
        private System.Windows.Forms.GroupBox _categoryGroupBox;
        private System.Windows.Forms.GroupBox _orderGroupBox;
        private System.Windows.Forms.DataGridView _categoryDataGridView;
        private System.Windows.Forms.DataGridView _orderDataGridView;
        private System.Windows.Forms.GroupBox _additionGroupBox;
        private System.Windows.Forms.DataGridView _additionDataGridView;
        private System.Windows.Forms.GroupBox _temperatureGroupBox;
        private System.Windows.Forms.GroupBox _sugarGroupBox;
        private System.Windows.Forms.Button _normalSugarButton;
        private System.Windows.Forms.Button _halfSugarButton;
        private System.Windows.Forms.Button _lessSugarButton;
        private System.Windows.Forms.Button _noSugarButton;
        private System.Windows.Forms.Button _normalIceButton;
        private System.Windows.Forms.Button _lessIceButton;
        private System.Windows.Forms.Button _noIceButton;
        private System.Windows.Forms.Button _hotButton;
        private System.Windows.Forms.Button _payButton;
        private System.Windows.Forms.Label _totalPriceLabel;
        private System.Windows.Forms.TableLayoutPanel _orderSystemTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel _sugarTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel _temperatureTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel _payTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel _managementSystemTableLayoutPanel;
        private System.Windows.Forms.GroupBox _drinkListGroupBox;
        private System.Windows.Forms.GroupBox _additionListGroupBox;
        private System.Windows.Forms.GroupBox _drinkManipulateGroupBox;
        private System.Windows.Forms.GroupBox _additionManipulateGroupBox;
        private System.Windows.Forms.DataGridView _drinkListDataGridView;
        private System.Windows.Forms.DataGridView _additionListDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn _orderNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _orderPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _orderSugarColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _orderTemperatureColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _orderAdditionColumn;
        private System.Windows.Forms.DataGridViewButtonColumn _orderButtonColumn;
        private System.Windows.Forms.DataGridViewButtonColumn _drinkButtonColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _drinkNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _drinkPriceColumn;
        private DataGridViewDisableButtonColumn _additionButtonColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _additionNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _additionPriceColumn;
    }
}
