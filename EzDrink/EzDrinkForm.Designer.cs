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
            this._orderNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._orderPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._orderSugarColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._orderTemperatureColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._orderAdditionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._orderButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this._categoryGroupBox = new System.Windows.Forms.GroupBox();
            this._drinkDataGridView = new System.Windows.Forms.DataGridView();
            this._drinkButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this._drinkNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._drinkPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._additionGroupBox = new System.Windows.Forms.GroupBox();
            this._additionDataGridView = new System.Windows.Forms.DataGridView();
            this._additionButtonColumn = new EzDrink.DataGridViewDisableButtonColumn();
            this._additionNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._additionPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this._drinkListButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this._drinkListNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._drinkListPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._additionListGroupBox = new System.Windows.Forms.GroupBox();
            this._additionListDataGridView = new System.Windows.Forms.DataGridView();
            this._additionListButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this._additionListNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._additionListPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._drinkManipulateGroupBox = new System.Windows.Forms.GroupBox();
            this._drinkManipulateTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._newDrinkButton = new System.Windows.Forms.Button();
            this._fileImportDrinkButton = new System.Windows.Forms.Button();
            this._drinkNameLabel = new System.Windows.Forms.Label();
            this._drinkPriceLabel = new System.Windows.Forms.Label();
            this._drinkNameTextBox = new System.Windows.Forms.TextBox();
            this._drinkPriceTextBox = new System.Windows.Forms.TextBox();
            this._additionManipulateGroupBox = new System.Windows.Forms.GroupBox();
            this._additionManipulateTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._newAdditionButton = new System.Windows.Forms.Button();
            this._fileImportAdditionButton = new System.Windows.Forms.Button();
            this._additionNameLabel = new System.Windows.Forms.Label();
            this._additionPriceLabel = new System.Windows.Forms.Label();
            this._additionNameTextBox = new System.Windows.Forms.TextBox();
            this._additionPriceTextBox = new System.Windows.Forms.TextBox();
            this._historyTabPage = new System.Windows.Forms.TabPage();
            this._historyTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._historyGroupBox = new System.Windows.Forms.GroupBox();
            this._historyDataGridView = new System.Windows.Forms.DataGridView();
            this._detailGroupBox = new System.Windows.Forms.GroupBox();
            this._detailDataGridView = new System.Windows.Forms.DataGridView();
            this._historyNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._historyPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._historySugarColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._historyTemperatureColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._historyAdditionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._historyTotalPriceTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._historyTotalPriceLabel = new System.Windows.Forms.Label();
            this._timeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._totalPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._menuStrip.SuspendLayout();
            this._tabControl.SuspendLayout();
            this._orderSystemTabPage.SuspendLayout();
            this._orderSystemTableLayoutPanel.SuspendLayout();
            this._orderGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._orderDataGridView)).BeginInit();
            this._categoryGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._drinkDataGridView)).BeginInit();
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
            this._drinkManipulateGroupBox.SuspendLayout();
            this._drinkManipulateTableLayoutPanel.SuspendLayout();
            this._additionManipulateGroupBox.SuspendLayout();
            this._additionManipulateTableLayoutPanel.SuspendLayout();
            this._historyTabPage.SuspendLayout();
            this._historyTableLayoutPanel.SuspendLayout();
            this._historyGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._historyDataGridView)).BeginInit();
            this._detailGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._detailDataGridView)).BeginInit();
            this._historyTotalPriceTableLayoutPanel.SuspendLayout();
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
            this._aboutToolStripMenuItem.Click += new System.EventHandler(this.ClickAboutToolStripMenuItem);
            // 
            // _tabControl
            // 
            this._tabControl.Controls.Add(this._orderSystemTabPage);
            this._tabControl.Controls.Add(this._managementSystemTabPage);
            this._tabControl.Controls.Add(this._historyTabPage);
            this._tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tabControl.Location = new System.Drawing.Point(0, 24);
            this._tabControl.Name = "_tabControl";
            this._tabControl.SelectedIndex = 0;
            this._tabControl.Size = new System.Drawing.Size(884, 517);
            this._tabControl.TabIndex = 1;
            this._tabControl.SelectedIndexChanged += new System.EventHandler(this.ChangeTabControlSelectedIndex);
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
            // _categoryGroupBox
            // 
            this._categoryGroupBox.Controls.Add(this._drinkDataGridView);
            this._categoryGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._categoryGroupBox.Location = new System.Drawing.Point(3, 3);
            this._categoryGroupBox.Name = "_categoryGroupBox";
            this._orderSystemTableLayoutPanel.SetRowSpan(this._categoryGroupBox, 5);
            this._categoryGroupBox.Size = new System.Drawing.Size(233, 479);
            this._categoryGroupBox.TabIndex = 0;
            this._categoryGroupBox.TabStop = false;
            this._categoryGroupBox.Text = "飲料";
            // 
            // _drinkDataGridView
            // 
            this._drinkDataGridView.AllowUserToAddRows = false;
            this._drinkDataGridView.AllowUserToResizeColumns = false;
            this._drinkDataGridView.AllowUserToResizeRows = false;
            this._drinkDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._drinkDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._drinkDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this._drinkDataGridView.ColumnHeadersHeight = 20;
            this._drinkDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this._drinkDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._drinkButtonColumn,
            this._drinkNameColumn,
            this._drinkPriceColumn});
            this._drinkDataGridView.Location = new System.Drawing.Point(5, 21);
            this._drinkDataGridView.Name = "_drinkDataGridView";
            this._drinkDataGridView.ReadOnly = true;
            this._drinkDataGridView.RowHeadersVisible = false;
            this._drinkDataGridView.RowTemplate.Height = 24;
            this._drinkDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this._drinkDataGridView.Size = new System.Drawing.Size(223, 452);
            this._drinkDataGridView.TabIndex = 0;
            this._drinkDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickDrinkDataGridViewCellContent);
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
            this._drinkListDataGridView.AllowUserToResizeColumns = false;
            this._drinkListDataGridView.AllowUserToResizeRows = false;
            this._drinkListDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._drinkListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._drinkListDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this._drinkListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._drinkListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._drinkListButtonColumn,
            this._drinkListNameColumn,
            this._drinkListPriceColumn});
            this._drinkListDataGridView.Location = new System.Drawing.Point(5, 21);
            this._drinkListDataGridView.Name = "_drinkListDataGridView";
            this._drinkListDataGridView.RowHeadersVisible = false;
            this._drinkListDataGridView.RowTemplate.Height = 24;
            this._drinkListDataGridView.Size = new System.Drawing.Size(279, 452);
            this._drinkListDataGridView.TabIndex = 0;
            this._drinkListDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickDrinkListDataGridViewCellContent);
            this._drinkListDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.EndEditDrinkListDataGridViewCell);
            // 
            // _drinkListButtonColumn
            // 
            this._drinkListButtonColumn.FillWeight = 40F;
            this._drinkListButtonColumn.HeaderText = "";
            this._drinkListButtonColumn.Name = "_drinkListButtonColumn";
            // 
            // _drinkListNameColumn
            // 
            this._drinkListNameColumn.FillWeight = 170F;
            this._drinkListNameColumn.HeaderText = "飲料名稱";
            this._drinkListNameColumn.Name = "_drinkListNameColumn";
            this._drinkListNameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _drinkListPriceColumn
            // 
            this._drinkListPriceColumn.FillWeight = 66F;
            this._drinkListPriceColumn.HeaderText = "價格";
            this._drinkListPriceColumn.Name = "_drinkListPriceColumn";
            this._drinkListPriceColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            this._additionListDataGridView.AllowUserToResizeColumns = false;
            this._additionListDataGridView.AllowUserToResizeRows = false;
            this._additionListDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._additionListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._additionListDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this._additionListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._additionListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._additionListButtonColumn,
            this._additionListNameColumn,
            this._additionListPriceColumn});
            this._additionListDataGridView.Location = new System.Drawing.Point(5, 21);
            this._additionListDataGridView.Name = "_additionListDataGridView";
            this._additionListDataGridView.RowHeadersVisible = false;
            this._additionListDataGridView.RowTemplate.Height = 24;
            this._additionListDataGridView.Size = new System.Drawing.Size(282, 452);
            this._additionListDataGridView.TabIndex = 1;
            this._additionListDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickAdditionListDataGridViewCellContent);
            this._additionListDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.EndEditAdditionListDataGridViewCell);
            // 
            // _additionListButtonColumn
            // 
            this._additionListButtonColumn.FillWeight = 40F;
            this._additionListButtonColumn.HeaderText = "";
            this._additionListButtonColumn.Name = "_additionListButtonColumn";
            // 
            // _additionListNameColumn
            // 
            this._additionListNameColumn.FillWeight = 170F;
            this._additionListNameColumn.HeaderText = "名稱";
            this._additionListNameColumn.Name = "_additionListNameColumn";
            this._additionListNameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this._additionListNameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _additionListPriceColumn
            // 
            this._additionListPriceColumn.FillWeight = 69F;
            this._additionListPriceColumn.HeaderText = "價格";
            this._additionListPriceColumn.Name = "_additionListPriceColumn";
            this._additionListPriceColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _drinkManipulateGroupBox
            // 
            this._drinkManipulateGroupBox.Controls.Add(this._drinkManipulateTableLayoutPanel);
            this._drinkManipulateGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._drinkManipulateGroupBox.Location = new System.Drawing.Point(315, 3);
            this._drinkManipulateGroupBox.Name = "_drinkManipulateGroupBox";
            this._drinkManipulateGroupBox.Size = new System.Drawing.Size(237, 236);
            this._drinkManipulateGroupBox.TabIndex = 2;
            this._drinkManipulateGroupBox.TabStop = false;
            this._drinkManipulateGroupBox.Text = "飲料清單操作";
            // 
            // _drinkManipulateTableLayoutPanel
            // 
            this._drinkManipulateTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._drinkManipulateTableLayoutPanel.ColumnCount = 3;
            this._drinkManipulateTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46F));
            this._drinkManipulateTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this._drinkManipulateTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46F));
            this._drinkManipulateTableLayoutPanel.Controls.Add(this._newDrinkButton, 0, 0);
            this._drinkManipulateTableLayoutPanel.Controls.Add(this._fileImportDrinkButton, 2, 0);
            this._drinkManipulateTableLayoutPanel.Controls.Add(this._drinkNameLabel, 0, 1);
            this._drinkManipulateTableLayoutPanel.Controls.Add(this._drinkPriceLabel, 0, 2);
            this._drinkManipulateTableLayoutPanel.Controls.Add(this._drinkNameTextBox, 2, 1);
            this._drinkManipulateTableLayoutPanel.Controls.Add(this._drinkPriceTextBox, 2, 2);
            this._drinkManipulateTableLayoutPanel.Location = new System.Drawing.Point(6, 21);
            this._drinkManipulateTableLayoutPanel.Name = "_drinkManipulateTableLayoutPanel";
            this._drinkManipulateTableLayoutPanel.RowCount = 3;
            this._drinkManipulateTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this._drinkManipulateTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this._drinkManipulateTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this._drinkManipulateTableLayoutPanel.Size = new System.Drawing.Size(225, 209);
            this._drinkManipulateTableLayoutPanel.TabIndex = 0;
            // 
            // _newDrinkButton
            // 
            this._newDrinkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._newDrinkButton.Location = new System.Drawing.Point(3, 3);
            this._newDrinkButton.Name = "_newDrinkButton";
            this._newDrinkButton.Size = new System.Drawing.Size(97, 56);
            this._newDrinkButton.TabIndex = 0;
            this._newDrinkButton.Text = "新增";
            this._newDrinkButton.UseVisualStyleBackColor = true;
            this._newDrinkButton.Click += new System.EventHandler(this.ClickNewDrinkButton);
            // 
            // _fileImportDrinkButton
            // 
            this._fileImportDrinkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._fileImportDrinkButton.Location = new System.Drawing.Point(124, 3);
            this._fileImportDrinkButton.Name = "_fileImportDrinkButton";
            this._fileImportDrinkButton.Size = new System.Drawing.Size(98, 56);
            this._fileImportDrinkButton.TabIndex = 1;
            this._fileImportDrinkButton.Text = "從檔案匯入";
            this._fileImportDrinkButton.UseVisualStyleBackColor = true;
            this._fileImportDrinkButton.Click += new System.EventHandler(this.ClickFileImportDrinkButton);
            // 
            // _drinkNameLabel
            // 
            this._drinkNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._drinkNameLabel.AutoSize = true;
            this._drinkNameLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._drinkNameLabel.Location = new System.Drawing.Point(3, 88);
            this._drinkNameLabel.Name = "_drinkNameLabel";
            this._drinkNameLabel.Size = new System.Drawing.Size(97, 20);
            this._drinkNameLabel.TabIndex = 2;
            this._drinkNameLabel.Text = "飲料名稱 :";
            this._drinkNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _drinkPriceLabel
            // 
            this._drinkPriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._drinkPriceLabel.AutoSize = true;
            this._drinkPriceLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._drinkPriceLabel.Location = new System.Drawing.Point(3, 162);
            this._drinkPriceLabel.Name = "_drinkPriceLabel";
            this._drinkPriceLabel.Size = new System.Drawing.Size(97, 20);
            this._drinkPriceLabel.TabIndex = 3;
            this._drinkPriceLabel.Text = "價格 :";
            this._drinkPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _drinkNameTextBox
            // 
            this._drinkNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._drinkNameTextBox.Location = new System.Drawing.Point(124, 87);
            this._drinkNameTextBox.Name = "_drinkNameTextBox";
            this._drinkNameTextBox.Size = new System.Drawing.Size(98, 22);
            this._drinkNameTextBox.TabIndex = 4;
            // 
            // _drinkPriceTextBox
            // 
            this._drinkPriceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._drinkPriceTextBox.Location = new System.Drawing.Point(124, 161);
            this._drinkPriceTextBox.Name = "_drinkPriceTextBox";
            this._drinkPriceTextBox.Size = new System.Drawing.Size(98, 22);
            this._drinkPriceTextBox.TabIndex = 5;
            // 
            // _additionManipulateGroupBox
            // 
            this._additionManipulateGroupBox.Controls.Add(this._additionManipulateTableLayoutPanel);
            this._additionManipulateGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._additionManipulateGroupBox.Location = new System.Drawing.Point(315, 245);
            this._additionManipulateGroupBox.Name = "_additionManipulateGroupBox";
            this._additionManipulateGroupBox.Size = new System.Drawing.Size(237, 237);
            this._additionManipulateGroupBox.TabIndex = 3;
            this._additionManipulateGroupBox.TabStop = false;
            this._additionManipulateGroupBox.Text = "加料清單操作";
            // 
            // _additionManipulateTableLayoutPanel
            // 
            this._additionManipulateTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._additionManipulateTableLayoutPanel.ColumnCount = 3;
            this._additionManipulateTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46F));
            this._additionManipulateTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this._additionManipulateTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46F));
            this._additionManipulateTableLayoutPanel.Controls.Add(this._newAdditionButton, 0, 0);
            this._additionManipulateTableLayoutPanel.Controls.Add(this._fileImportAdditionButton, 2, 0);
            this._additionManipulateTableLayoutPanel.Controls.Add(this._additionNameLabel, 0, 1);
            this._additionManipulateTableLayoutPanel.Controls.Add(this._additionPriceLabel, 0, 2);
            this._additionManipulateTableLayoutPanel.Controls.Add(this._additionNameTextBox, 2, 1);
            this._additionManipulateTableLayoutPanel.Controls.Add(this._additionPriceTextBox, 2, 2);
            this._additionManipulateTableLayoutPanel.Location = new System.Drawing.Point(6, 21);
            this._additionManipulateTableLayoutPanel.Name = "_additionManipulateTableLayoutPanel";
            this._additionManipulateTableLayoutPanel.RowCount = 3;
            this._additionManipulateTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this._additionManipulateTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this._additionManipulateTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this._additionManipulateTableLayoutPanel.Size = new System.Drawing.Size(225, 209);
            this._additionManipulateTableLayoutPanel.TabIndex = 1;
            // 
            // _newAdditionButton
            // 
            this._newAdditionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._newAdditionButton.Location = new System.Drawing.Point(3, 3);
            this._newAdditionButton.Name = "_newAdditionButton";
            this._newAdditionButton.Size = new System.Drawing.Size(97, 56);
            this._newAdditionButton.TabIndex = 0;
            this._newAdditionButton.Text = "新增";
            this._newAdditionButton.UseVisualStyleBackColor = true;
            this._newAdditionButton.Click += new System.EventHandler(this.ClickNewAdditionButton);
            // 
            // _fileImportAdditionButton
            // 
            this._fileImportAdditionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._fileImportAdditionButton.Location = new System.Drawing.Point(124, 3);
            this._fileImportAdditionButton.Name = "_fileImportAdditionButton";
            this._fileImportAdditionButton.Size = new System.Drawing.Size(98, 56);
            this._fileImportAdditionButton.TabIndex = 1;
            this._fileImportAdditionButton.Text = "從檔案匯入";
            this._fileImportAdditionButton.UseVisualStyleBackColor = true;
            this._fileImportAdditionButton.Click += new System.EventHandler(this.ClickFileImportAdditionButton);
            // 
            // _additionNameLabel
            // 
            this._additionNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._additionNameLabel.AutoSize = true;
            this._additionNameLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._additionNameLabel.Location = new System.Drawing.Point(3, 88);
            this._additionNameLabel.Name = "_additionNameLabel";
            this._additionNameLabel.Size = new System.Drawing.Size(97, 20);
            this._additionNameLabel.TabIndex = 2;
            this._additionNameLabel.Text = "加料名稱 :";
            this._additionNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _additionPriceLabel
            // 
            this._additionPriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._additionPriceLabel.AutoSize = true;
            this._additionPriceLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._additionPriceLabel.Location = new System.Drawing.Point(3, 162);
            this._additionPriceLabel.Name = "_additionPriceLabel";
            this._additionPriceLabel.Size = new System.Drawing.Size(97, 20);
            this._additionPriceLabel.TabIndex = 3;
            this._additionPriceLabel.Text = "價格 :";
            this._additionPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _additionNameTextBox
            // 
            this._additionNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._additionNameTextBox.Location = new System.Drawing.Point(124, 87);
            this._additionNameTextBox.Name = "_additionNameTextBox";
            this._additionNameTextBox.Size = new System.Drawing.Size(98, 22);
            this._additionNameTextBox.TabIndex = 6;
            // 
            // _additionPriceTextBox
            // 
            this._additionPriceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._additionPriceTextBox.Location = new System.Drawing.Point(124, 161);
            this._additionPriceTextBox.Name = "_additionPriceTextBox";
            this._additionPriceTextBox.Size = new System.Drawing.Size(98, 22);
            this._additionPriceTextBox.TabIndex = 7;
            // 
            // _historyTabPage
            // 
            this._historyTabPage.Controls.Add(this._historyTableLayoutPanel);
            this._historyTabPage.Location = new System.Drawing.Point(4, 22);
            this._historyTabPage.Name = "_historyTabPage";
            this._historyTabPage.Padding = new System.Windows.Forms.Padding(3);
            this._historyTabPage.Size = new System.Drawing.Size(876, 491);
            this._historyTabPage.TabIndex = 2;
            this._historyTabPage.Text = "歷史紀錄";
            this._historyTabPage.UseVisualStyleBackColor = true;
            // 
            // _historyTableLayoutPanel
            // 
            this._historyTableLayoutPanel.ColumnCount = 5;
            this._historyTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this._historyTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this._historyTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this._historyTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this._historyTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this._historyTableLayoutPanel.Controls.Add(this._historyGroupBox, 1, 0);
            this._historyTableLayoutPanel.Controls.Add(this._detailGroupBox, 3, 0);
            this._historyTableLayoutPanel.Controls.Add(this._historyTotalPriceTableLayoutPanel, 3, 1);
            this._historyTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._historyTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this._historyTableLayoutPanel.Name = "_historyTableLayoutPanel";
            this._historyTableLayoutPanel.RowCount = 2;
            this._historyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this._historyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this._historyTableLayoutPanel.Size = new System.Drawing.Size(870, 485);
            this._historyTableLayoutPanel.TabIndex = 0;
            // 
            // _historyGroupBox
            // 
            this._historyGroupBox.Controls.Add(this._historyDataGridView);
            this._historyGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._historyGroupBox.Location = new System.Drawing.Point(29, 3);
            this._historyGroupBox.Name = "_historyGroupBox";
            this._historyTableLayoutPanel.SetRowSpan(this._historyGroupBox, 2);
            this._historyGroupBox.Size = new System.Drawing.Size(385, 479);
            this._historyGroupBox.TabIndex = 0;
            this._historyGroupBox.TabStop = false;
            this._historyGroupBox.Text = "歷史";
            // 
            // _historyDataGridView
            // 
            this._historyDataGridView.AllowUserToAddRows = false;
            this._historyDataGridView.AllowUserToResizeColumns = false;
            this._historyDataGridView.AllowUserToResizeRows = false;
            this._historyDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._historyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._historyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._historyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._timeColumn,
            this._totalPriceColumn});
            this._historyDataGridView.Location = new System.Drawing.Point(5, 21);
            this._historyDataGridView.Name = "_historyDataGridView";
            this._historyDataGridView.ReadOnly = true;
            this._historyDataGridView.RowHeadersVisible = false;
            this._historyDataGridView.RowTemplate.Height = 24;
            this._historyDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._historyDataGridView.Size = new System.Drawing.Size(375, 452);
            this._historyDataGridView.TabIndex = 0;
            this._historyDataGridView.CurrentCellChanged += new System.EventHandler(this.ChangeHistoryDataGridViewCurrentCell);
            // 
            // _detailGroupBox
            // 
            this._detailGroupBox.Controls.Add(this._detailDataGridView);
            this._detailGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._detailGroupBox.Location = new System.Drawing.Point(454, 3);
            this._detailGroupBox.Name = "_detailGroupBox";
            this._detailGroupBox.Size = new System.Drawing.Size(385, 430);
            this._detailGroupBox.TabIndex = 1;
            this._detailGroupBox.TabStop = false;
            this._detailGroupBox.Text = "詳細";
            // 
            // _detailDataGridView
            // 
            this._detailDataGridView.AllowUserToAddRows = false;
            this._detailDataGridView.AllowUserToResizeColumns = false;
            this._detailDataGridView.AllowUserToResizeRows = false;
            this._detailDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._detailDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._detailDataGridView.ColumnHeadersHeight = 20;
            this._detailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this._detailDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._historyNameColumn,
            this._historyPriceColumn,
            this._historySugarColumn,
            this._historyTemperatureColumn,
            this._historyAdditionColumn});
            this._detailDataGridView.Location = new System.Drawing.Point(5, 21);
            this._detailDataGridView.Name = "_detailDataGridView";
            this._detailDataGridView.ReadOnly = true;
            this._detailDataGridView.RowHeadersVisible = false;
            this._detailDataGridView.RowTemplate.Height = 24;
            this._detailDataGridView.Size = new System.Drawing.Size(375, 403);
            this._detailDataGridView.TabIndex = 0;
            // 
            // _historyNameColumn
            // 
            this._historyNameColumn.FillWeight = 90F;
            this._historyNameColumn.HeaderText = "飲料名稱";
            this._historyNameColumn.Name = "_historyNameColumn";
            this._historyNameColumn.ReadOnly = true;
            // 
            // _historyPriceColumn
            // 
            this._historyPriceColumn.FillWeight = 60F;
            this._historyPriceColumn.HeaderText = "價格";
            this._historyPriceColumn.Name = "_historyPriceColumn";
            this._historyPriceColumn.ReadOnly = true;
            // 
            // _historySugarColumn
            // 
            this._historySugarColumn.FillWeight = 60F;
            this._historySugarColumn.HeaderText = "甜度";
            this._historySugarColumn.Name = "_historySugarColumn";
            this._historySugarColumn.ReadOnly = true;
            // 
            // _historyTemperatureColumn
            // 
            this._historyTemperatureColumn.FillWeight = 60F;
            this._historyTemperatureColumn.HeaderText = "溫度";
            this._historyTemperatureColumn.Name = "_historyTemperatureColumn";
            this._historyTemperatureColumn.ReadOnly = true;
            // 
            // _historyAdditionColumn
            // 
            this._historyAdditionColumn.FillWeight = 102F;
            this._historyAdditionColumn.HeaderText = "加料";
            this._historyAdditionColumn.Name = "_historyAdditionColumn";
            this._historyAdditionColumn.ReadOnly = true;
            // 
            // _historyTotalPriceTableLayoutPanel
            // 
            this._historyTotalPriceTableLayoutPanel.ColumnCount = 2;
            this._historyTotalPriceTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this._historyTotalPriceTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this._historyTotalPriceTableLayoutPanel.Controls.Add(this._historyTotalPriceLabel, 1, 0);
            this._historyTotalPriceTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._historyTotalPriceTableLayoutPanel.Location = new System.Drawing.Point(454, 439);
            this._historyTotalPriceTableLayoutPanel.Name = "_historyTotalPriceTableLayoutPanel";
            this._historyTotalPriceTableLayoutPanel.RowCount = 1;
            this._historyTotalPriceTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._historyTotalPriceTableLayoutPanel.Size = new System.Drawing.Size(385, 43);
            this._historyTotalPriceTableLayoutPanel.TabIndex = 3;
            // 
            // _historyTotalPriceLabel
            // 
            this._historyTotalPriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._historyTotalPriceLabel.AutoSize = true;
            this._historyTotalPriceLabel.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._historyTotalPriceLabel.Location = new System.Drawing.Point(272, 8);
            this._historyTotalPriceLabel.Name = "_historyTotalPriceLabel";
            this._historyTotalPriceLabel.Size = new System.Drawing.Size(110, 27);
            this._historyTotalPriceLabel.TabIndex = 2;
            this._historyTotalPriceLabel.Text = "總價 : ";
            this._historyTotalPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _timeColumn
            // 
            this._timeColumn.FillWeight = 270F;
            this._timeColumn.HeaderText = "時間";
            this._timeColumn.Name = "_timeColumn";
            this._timeColumn.ReadOnly = true;
            this._timeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _totalPriceColumn
            // 
            this._totalPriceColumn.FillWeight = 102F;
            this._totalPriceColumn.HeaderText = "總價";
            this._totalPriceColumn.Name = "_totalPriceColumn";
            this._totalPriceColumn.ReadOnly = true;
            this._totalPriceColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            ((System.ComponentModel.ISupportInitialize)(this._drinkDataGridView)).EndInit();
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
            this._drinkManipulateGroupBox.ResumeLayout(false);
            this._drinkManipulateTableLayoutPanel.ResumeLayout(false);
            this._drinkManipulateTableLayoutPanel.PerformLayout();
            this._additionManipulateGroupBox.ResumeLayout(false);
            this._additionManipulateTableLayoutPanel.ResumeLayout(false);
            this._additionManipulateTableLayoutPanel.PerformLayout();
            this._historyTabPage.ResumeLayout(false);
            this._historyTableLayoutPanel.ResumeLayout(false);
            this._historyGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._historyDataGridView)).EndInit();
            this._detailGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._detailDataGridView)).EndInit();
            this._historyTotalPriceTableLayoutPanel.ResumeLayout(false);
            this._historyTotalPriceTableLayoutPanel.PerformLayout();
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
        private System.Windows.Forms.TabPage _historyTabPage;
        private System.Windows.Forms.GroupBox _categoryGroupBox;
        private System.Windows.Forms.GroupBox _orderGroupBox;
        private System.Windows.Forms.DataGridView _drinkDataGridView;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn _additionNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _additionPriceColumn;
        private DataGridViewDisableButtonColumn _additionButtonColumn;
        private System.Windows.Forms.TableLayoutPanel _drinkManipulateTableLayoutPanel;
        private System.Windows.Forms.Button _newDrinkButton;
        private System.Windows.Forms.Button _fileImportDrinkButton;
        private System.Windows.Forms.TableLayoutPanel _additionManipulateTableLayoutPanel;
        private System.Windows.Forms.Button _newAdditionButton;
        private System.Windows.Forms.Button _fileImportAdditionButton;
        private System.Windows.Forms.Label _drinkNameLabel;
        private System.Windows.Forms.Label _drinkPriceLabel;
        private System.Windows.Forms.Label _additionNameLabel;
        private System.Windows.Forms.Label _additionPriceLabel;
        private System.Windows.Forms.TextBox _drinkNameTextBox;
        private System.Windows.Forms.TextBox _drinkPriceTextBox;
        private System.Windows.Forms.TextBox _additionNameTextBox;
        private System.Windows.Forms.TextBox _additionPriceTextBox;
        private System.Windows.Forms.DataGridViewButtonColumn _drinkButtonColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _drinkNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _drinkPriceColumn;
        private System.Windows.Forms.DataGridViewButtonColumn _drinkListButtonColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _drinkListNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _drinkListPriceColumn;
        private System.Windows.Forms.DataGridViewButtonColumn _additionListButtonColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _additionListNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _additionListPriceColumn;
        private System.Windows.Forms.TableLayoutPanel _historyTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel _historyTotalPriceTableLayoutPanel;
        private System.Windows.Forms.GroupBox _historyGroupBox;
        private System.Windows.Forms.DataGridView _historyDataGridView;
        private System.Windows.Forms.GroupBox _detailGroupBox;
        private System.Windows.Forms.DataGridView _detailDataGridView;
        private System.Windows.Forms.Label _historyTotalPriceLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn _historyTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _historyTotalPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _historyNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _historyPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _historySugarColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _historyTemperatureColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _historyAdditionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _timeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _totalPriceColumn;
    }
}