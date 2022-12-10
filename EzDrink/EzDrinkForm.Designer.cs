using System.Windows.Forms;
namespace EzDrink
{
    partial class EzDrinkForm : Form
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
            this._menuStrip = new System.Windows.Forms.MenuStrip();
            this._fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._orderTabControl = new System.Windows.Forms.TabControl();
            this._orderTabPage = new System.Windows.Forms.TabPage();
            this._orderSystemTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._drinkGroupBox = new System.Windows.Forms.GroupBox();
            this._drinkListDataGridView = new System.Windows.Forms.DataGridView();
            this._drinkButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this._drinkName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._drinkPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._additionGroupBox = new System.Windows.Forms.GroupBox();
            this._additionDataGridView = new System.Windows.Forms.DataGridView();
            this._additionButtonColumn = new EzDrink.DataGridViewDisableButtonColumn();
            this._additionNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._additionPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._orderGroupBox = new System.Windows.Forms.GroupBox();
            this._orderListDataGridView = new System.Windows.Forms.DataGridView();
            this._orderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._orderPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._orderSugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._orderIce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._orderAddition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._orderDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this._temperatureGroupBox = new System.Windows.Forms.GroupBox();
            this._temperatureTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._hotButton = new System.Windows.Forms.Button();
            this._iceNormalButton = new System.Windows.Forms.Button();
            this._iceLessButton = new System.Windows.Forms.Button();
            this._iceNoButton = new System.Windows.Forms.Button();
            this._sugarGroupBox = new System.Windows.Forms.GroupBox();
            this._sugarTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._sugarNoButton = new System.Windows.Forms.Button();
            this._sugarNormalButton = new System.Windows.Forms.Button();
            this._sugarLessButton = new System.Windows.Forms.Button();
            this._sugarHalfButton = new System.Windows.Forms.Button();
            this._totalPriceTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._buyButton = new System.Windows.Forms.Button();
            this._totalPriceLabel = new System.Windows.Forms.Label();
            this._backStageTabPage = new System.Windows.Forms.TabPage();
            this._backStageTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._backDrinksGroupBox = new System.Windows.Forms.GroupBox();
            this._backDrinksListDataGridView = new System.Windows.Forms.DataGridView();
            this._backDrinksListButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this._backDrinksListNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._backDrinksListPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._backAdditionListGroupBox = new System.Windows.Forms.GroupBox();
            this._backAdditionListDataGridView = new System.Windows.Forms.DataGridView();
            this._backAdditionButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this._backAdditionListNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._backAdditionListPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._backDrinksListControlGroupBox = new System.Windows.Forms.GroupBox();
            this._backDrinksListControlTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._backDrinksListControlNewButton = new System.Windows.Forms.Button();
            this._backDrinksListControlNewFromFileButton = new System.Windows.Forms.Button();
            this._backDrinksListControlDrinkNameLabel = new System.Windows.Forms.Label();
            this._backDrinkNameTextBox = new System.Windows.Forms.TextBox();
            this._backDrinksListControlDrinkPriceLabel = new System.Windows.Forms.Label();
            this._backDrinkPriceTextBox = new System.Windows.Forms.TextBox();
            this._backDrinksAdditionControlGroupBox = new System.Windows.Forms.GroupBox();
            this._backAdditionListControlTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._backAdditionListControlAdditionPriceLabel = new System.Windows.Forms.Label();
            this._backAdditionListControlNewButton = new System.Windows.Forms.Button();
            this._backAdditionListNewFromFileButton = new System.Windows.Forms.Button();
            this._backAdditionNameTextBox = new System.Windows.Forms.TextBox();
            this._backAdditionListControlAdditionNameLabel = new System.Windows.Forms.Label();
            this._backAdditionPriceTextBox = new System.Windows.Forms.TextBox();
            this._historyTabPage = new System.Windows.Forms.TabPage();
            this._historyTableLayOut = new System.Windows.Forms.TableLayoutPanel();
            this._historyGroupBox = new System.Windows.Forms.GroupBox();
            this._historyDataGridView = new System.Windows.Forms.DataGridView();
            this._historyTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._historyPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._listGroupBox = new System.Windows.Forms.GroupBox();
            this._listDataGridView = new System.Windows.Forms.DataGridView();
            this._listName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._listPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._listSugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._listIce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._listAddition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._listTotalPriceLabel = new System.Windows.Forms.Label();
            this._menuStrip.SuspendLayout();
            this._orderTabControl.SuspendLayout();
            this._orderTabPage.SuspendLayout();
            this._orderSystemTableLayoutPanel.SuspendLayout();
            this._drinkGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._drinkListDataGridView)).BeginInit();
            this._additionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._additionDataGridView)).BeginInit();
            this._orderGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._orderListDataGridView)).BeginInit();
            this._temperatureGroupBox.SuspendLayout();
            this._temperatureTableLayoutPanel.SuspendLayout();
            this._sugarGroupBox.SuspendLayout();
            this._sugarTableLayoutPanel.SuspendLayout();
            this._totalPriceTableLayoutPanel.SuspendLayout();
            this._backStageTabPage.SuspendLayout();
            this._backStageTableLayoutPanel.SuspendLayout();
            this._backDrinksGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._backDrinksListDataGridView)).BeginInit();
            this._backAdditionListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._backAdditionListDataGridView)).BeginInit();
            this._backDrinksListControlGroupBox.SuspendLayout();
            this._backDrinksListControlTableLayoutPanel.SuspendLayout();
            this._backDrinksAdditionControlGroupBox.SuspendLayout();
            this._backAdditionListControlTableLayoutPanel.SuspendLayout();
            this._historyTabPage.SuspendLayout();
            this._historyTableLayOut.SuspendLayout();
            this._historyGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._historyDataGridView)).BeginInit();
            this._listGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._listDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _menuStrip
            // 
            this._menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._fileToolStripMenuItem,
            this._helpToolStripMenuItem});
            this._menuStrip.Location = new System.Drawing.Point(0, 0);
            this._menuStrip.Name = "_menuStrip";
            this._menuStrip.Size = new System.Drawing.Size(999, 24);
            this._menuStrip.TabIndex = 0;
            this._menuStrip.Text = "menuStrip1";
            // 
            // _fileToolStripMenuItem
            // 
            this._fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._exitMenuItem});
            this._fileToolStripMenuItem.Name = "_fileToolStripMenuItem";
            this._fileToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this._fileToolStripMenuItem.Text = "File";
            // 
            // _exitMenuItem
            // 
            this._exitMenuItem.Name = "_exitMenuItem";
            this._exitMenuItem.Size = new System.Drawing.Size(96, 22);
            this._exitMenuItem.Text = "Exit";
            this._exitMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // _helpToolStripMenuItem
            // 
            this._helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._aboutToolStripMenuItem});
            this._helpToolStripMenuItem.Name = "_helpToolStripMenuItem";
            this._helpToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this._helpToolStripMenuItem.Text = "Help";
            // 
            // _aboutToolStripMenuItem
            // 
            this._aboutToolStripMenuItem.Name = "_aboutToolStripMenuItem";
            this._aboutToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this._aboutToolStripMenuItem.Text = "About";
            // 
            // _orderTabControl
            // 
            this._orderTabControl.Controls.Add(this._orderTabPage);
            this._orderTabControl.Controls.Add(this._backStageTabPage);
            this._orderTabControl.Controls.Add(this._historyTabPage);
            this._orderTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._orderTabControl.Location = new System.Drawing.Point(0, 24);
            this._orderTabControl.Multiline = true;
            this._orderTabControl.Name = "_orderTabControl";
            this._orderTabControl.SelectedIndex = 0;
            this._orderTabControl.Size = new System.Drawing.Size(999, 492);
            this._orderTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this._orderTabControl.TabIndex = 1;
            this._orderTabControl.SelectedIndexChanged += new System.EventHandler(this.ChangeTabControlSelectedIndex);
            // 
            // _orderTabPage
            // 
            this._orderTabPage.Controls.Add(this._orderSystemTableLayoutPanel);
            this._orderTabPage.Location = new System.Drawing.Point(4, 22);
            this._orderTabPage.Name = "_orderTabPage";
            this._orderTabPage.Padding = new System.Windows.Forms.Padding(3);
            this._orderTabPage.Size = new System.Drawing.Size(991, 466);
            this._orderTabPage.TabIndex = 0;
            this._orderTabPage.Text = "點餐系統";
            this._orderTabPage.UseVisualStyleBackColor = true;
            // 
            // _orderSystemTableLayoutPanel
            // 
            this._orderSystemTableLayoutPanel.ColumnCount = 5;
            this._orderSystemTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.1292F));
            this._orderSystemTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.831129F));
            this._orderSystemTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.8413F));
            this._orderSystemTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.8138352F));
            this._orderSystemTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.38454F));
            this._orderSystemTableLayoutPanel.Controls.Add(this._drinkGroupBox, 0, 0);
            this._orderSystemTableLayoutPanel.Controls.Add(this._additionGroupBox, 2, 0);
            this._orderSystemTableLayoutPanel.Controls.Add(this._orderGroupBox, 4, 0);
            this._orderSystemTableLayoutPanel.Controls.Add(this._temperatureGroupBox, 2, 3);
            this._orderSystemTableLayoutPanel.Controls.Add(this._sugarGroupBox, 2, 1);
            this._orderSystemTableLayoutPanel.Controls.Add(this._totalPriceTableLayoutPanel, 4, 4);
            this._orderSystemTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._orderSystemTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this._orderSystemTableLayoutPanel.Name = "_orderSystemTableLayoutPanel";
            this._orderSystemTableLayoutPanel.RowCount = 5;
            this._orderSystemTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._orderSystemTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this._orderSystemTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this._orderSystemTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this._orderSystemTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this._orderSystemTableLayoutPanel.Size = new System.Drawing.Size(985, 460);
            this._orderSystemTableLayoutPanel.TabIndex = 8;
            // 
            // _drinkGroupBox
            // 
            this._drinkGroupBox.Controls.Add(this._drinkListDataGridView);
            this._drinkGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._drinkGroupBox.Location = new System.Drawing.Point(3, 3);
            this._drinkGroupBox.Name = "_drinkGroupBox";
            this._orderSystemTableLayoutPanel.SetRowSpan(this._drinkGroupBox, 5);
            this._drinkGroupBox.Size = new System.Drawing.Size(300, 454);
            this._drinkGroupBox.TabIndex = 1;
            this._drinkGroupBox.TabStop = false;
            this._drinkGroupBox.Text = "飲料";
            // 
            // _drinkListDataGridView
            // 
            this._drinkListDataGridView.AllowUserToAddRows = false;
            this._drinkListDataGridView.AllowUserToResizeColumns = false;
            this._drinkListDataGridView.AllowUserToResizeRows = false;
            this._drinkListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._drinkListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._drinkListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._drinkButton,
            this._drinkName,
            this._drinkPrice});
            this._drinkListDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._drinkListDataGridView.Location = new System.Drawing.Point(3, 18);
            this._drinkListDataGridView.Name = "_drinkListDataGridView";
            this._drinkListDataGridView.ReadOnly = true;
            this._drinkListDataGridView.RowHeadersVisible = false;
            this._drinkListDataGridView.RowTemplate.Height = 24;
            this._drinkListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this._drinkListDataGridView.Size = new System.Drawing.Size(294, 433);
            this._drinkListDataGridView.TabIndex = 0;
            this._drinkListDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DrinkListDataGridViewCellClick);
            // 
            // _drinkButton
            // 
            this._drinkButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this._drinkButton.HeaderText = "";
            this._drinkButton.Name = "_drinkButton";
            this._drinkButton.ReadOnly = true;
            this._drinkButton.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this._drinkButton.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this._drinkButton.Width = 40;
            // 
            // _drinkName
            // 
            this._drinkName.HeaderText = "名稱";
            this._drinkName.Name = "_drinkName";
            this._drinkName.ReadOnly = true;
            this._drinkName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _drinkPrice
            // 
            this._drinkPrice.HeaderText = "價格";
            this._drinkPrice.Name = "_drinkPrice";
            this._drinkPrice.ReadOnly = true;
            this._drinkPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _additionGroupBox
            // 
            this._additionGroupBox.Controls.Add(this._additionDataGridView);
            this._additionGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._additionGroupBox.Location = new System.Drawing.Point(327, 3);
            this._additionGroupBox.Name = "_additionGroupBox";
            this._additionGroupBox.Size = new System.Drawing.Size(307, 224);
            this._additionGroupBox.TabIndex = 3;
            this._additionGroupBox.TabStop = false;
            this._additionGroupBox.Text = "加料";
            // 
            // _additionDataGridView
            // 
            this._additionDataGridView.AllowUserToAddRows = false;
            this._additionDataGridView.AllowUserToResizeColumns = false;
            this._additionDataGridView.AllowUserToResizeRows = false;
            this._additionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._additionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._additionButtonColumn,
            this._additionNameColumn,
            this._additionPriceColumn});
            this._additionDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._additionDataGridView.Location = new System.Drawing.Point(3, 18);
            this._additionDataGridView.Name = "_additionDataGridView";
            this._additionDataGridView.ReadOnly = true;
            this._additionDataGridView.RowHeadersVisible = false;
            this._additionDataGridView.RowTemplate.Height = 24;
            this._additionDataGridView.Size = new System.Drawing.Size(301, 203);
            this._additionDataGridView.TabIndex = 0;
            this._additionDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickAdditionDataGridView);
            // 
            // _additionButtonColumn
            // 
            this._additionButtonColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this._additionButtonColumn.HeaderText = "";
            this._additionButtonColumn.Name = "_additionButtonColumn";
            this._additionButtonColumn.ReadOnly = true;
            this._additionButtonColumn.Width = 40;
            // 
            // _additionNameColumn
            // 
            this._additionNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._additionNameColumn.HeaderText = "名稱";
            this._additionNameColumn.Name = "_additionNameColumn";
            this._additionNameColumn.ReadOnly = true;
            this._additionNameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _additionPriceColumn
            // 
            this._additionPriceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._additionPriceColumn.HeaderText = "價格";
            this._additionPriceColumn.Name = "_additionPriceColumn";
            this._additionPriceColumn.ReadOnly = true;
            this._additionPriceColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _orderGroupBox
            // 
            this._orderGroupBox.Controls.Add(this._orderListDataGridView);
            this._orderGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._orderGroupBox.Location = new System.Drawing.Point(648, 3);
            this._orderGroupBox.Name = "_orderGroupBox";
            this._orderSystemTableLayoutPanel.SetRowSpan(this._orderGroupBox, 4);
            this._orderGroupBox.Size = new System.Drawing.Size(334, 395);
            this._orderGroupBox.TabIndex = 2;
            this._orderGroupBox.TabStop = false;
            this._orderGroupBox.Text = "點餐";
            // 
            // _orderListDataGridView
            // 
            this._orderListDataGridView.AllowUserToAddRows = false;
            this._orderListDataGridView.AllowUserToResizeColumns = false;
            this._orderListDataGridView.AllowUserToResizeRows = false;
            this._orderListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._orderListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._orderListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._orderName,
            this._orderPrice,
            this._orderSugar,
            this._orderIce,
            this._orderAddition,
            this._orderDelete});
            this._orderListDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._orderListDataGridView.Location = new System.Drawing.Point(3, 18);
            this._orderListDataGridView.Name = "_orderListDataGridView";
            this._orderListDataGridView.ReadOnly = true;
            this._orderListDataGridView.RowHeadersVisible = false;
            this._orderListDataGridView.RowTemplate.Height = 24;
            this._orderListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this._orderListDataGridView.Size = new System.Drawing.Size(328, 374);
            this._orderListDataGridView.TabIndex = 0;
            this._orderListDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickOrderListDataGridView);
            // 
            // _orderName
            // 
            this._orderName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._orderName.FillWeight = 200F;
            this._orderName.HeaderText = "名稱";
            this._orderName.Name = "_orderName";
            this._orderName.ReadOnly = true;
            this._orderName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _orderPrice
            // 
            this._orderPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._orderPrice.HeaderText = "價格";
            this._orderPrice.Name = "_orderPrice";
            this._orderPrice.ReadOnly = true;
            this._orderPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this._orderPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _orderSugar
            // 
            this._orderSugar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._orderSugar.HeaderText = "甜度";
            this._orderSugar.Name = "_orderSugar";
            this._orderSugar.ReadOnly = true;
            this._orderSugar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this._orderSugar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _orderIce
            // 
            this._orderIce.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._orderIce.HeaderText = "溫度";
            this._orderIce.Name = "_orderIce";
            this._orderIce.ReadOnly = true;
            this._orderIce.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this._orderIce.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _orderAddition
            // 
            this._orderAddition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._orderAddition.FillWeight = 150F;
            this._orderAddition.HeaderText = "加料";
            this._orderAddition.Name = "_orderAddition";
            this._orderAddition.ReadOnly = true;
            this._orderAddition.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _orderDelete
            // 
            this._orderDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this._orderDelete.HeaderText = "";
            this._orderDelete.Name = "_orderDelete";
            this._orderDelete.ReadOnly = true;
            this._orderDelete.Width = 40;
            // 
            // _temperatureGroupBox
            // 
            this._temperatureGroupBox.Controls.Add(this._temperatureTableLayoutPanel);
            this._temperatureGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._temperatureGroupBox.Location = new System.Drawing.Point(327, 347);
            this._temperatureGroupBox.Name = "_temperatureGroupBox";
            this._orderSystemTableLayoutPanel.SetRowSpan(this._temperatureGroupBox, 2);
            this._temperatureGroupBox.Size = new System.Drawing.Size(307, 110);
            this._temperatureGroupBox.TabIndex = 5;
            this._temperatureGroupBox.TabStop = false;
            this._temperatureGroupBox.Text = "溫度";
            // 
            // _temperatureTableLayoutPanel
            // 
            this._temperatureTableLayoutPanel.AutoSize = true;
            this._temperatureTableLayoutPanel.ColumnCount = 2;
            this._temperatureTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._temperatureTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._temperatureTableLayoutPanel.Controls.Add(this._hotButton, 1, 1);
            this._temperatureTableLayoutPanel.Controls.Add(this._iceNormalButton, 0, 0);
            this._temperatureTableLayoutPanel.Controls.Add(this._iceLessButton, 1, 0);
            this._temperatureTableLayoutPanel.Controls.Add(this._iceNoButton, 0, 1);
            this._temperatureTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._temperatureTableLayoutPanel.Location = new System.Drawing.Point(3, 18);
            this._temperatureTableLayoutPanel.Name = "_temperatureTableLayoutPanel";
            this._temperatureTableLayoutPanel.RowCount = 2;
            this._temperatureTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._temperatureTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._temperatureTableLayoutPanel.Size = new System.Drawing.Size(301, 89);
            this._temperatureTableLayoutPanel.TabIndex = 1;
            // 
            // _hotButton
            // 
            this._hotButton.AutoSize = true;
            this._hotButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._hotButton.Location = new System.Drawing.Point(153, 47);
            this._hotButton.Name = "_hotButton";
            this._hotButton.Size = new System.Drawing.Size(145, 39);
            this._hotButton.TabIndex = 4;
            this._hotButton.Text = "溫熱";
            this._hotButton.UseVisualStyleBackColor = true;
            this._hotButton.Click += new System.EventHandler(this.ClickIceButton);
            // 
            // _iceNormalButton
            // 
            this._iceNormalButton.AutoSize = true;
            this._iceNormalButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._iceNormalButton.Location = new System.Drawing.Point(3, 3);
            this._iceNormalButton.Name = "_iceNormalButton";
            this._iceNormalButton.Size = new System.Drawing.Size(144, 38);
            this._iceNormalButton.TabIndex = 1;
            this._iceNormalButton.Text = "正常";
            this._iceNormalButton.UseVisualStyleBackColor = true;
            this._iceNormalButton.Click += new System.EventHandler(this.ClickIceButton);
            // 
            // _iceLessButton
            // 
            this._iceLessButton.AutoSize = true;
            this._iceLessButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._iceLessButton.Location = new System.Drawing.Point(153, 3);
            this._iceLessButton.Name = "_iceLessButton";
            this._iceLessButton.Size = new System.Drawing.Size(145, 38);
            this._iceLessButton.TabIndex = 2;
            this._iceLessButton.Text = "少冰";
            this._iceLessButton.UseVisualStyleBackColor = true;
            this._iceLessButton.Click += new System.EventHandler(this.ClickIceButton);
            // 
            // _iceNoButton
            // 
            this._iceNoButton.AutoSize = true;
            this._iceNoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._iceNoButton.Location = new System.Drawing.Point(3, 47);
            this._iceNoButton.Name = "_iceNoButton";
            this._iceNoButton.Size = new System.Drawing.Size(144, 39);
            this._iceNoButton.TabIndex = 3;
            this._iceNoButton.Text = "去冰";
            this._iceNoButton.UseVisualStyleBackColor = true;
            this._iceNoButton.Click += new System.EventHandler(this.ClickIceButton);
            // 
            // _sugarGroupBox
            // 
            this._sugarGroupBox.Controls.Add(this._sugarTableLayoutPanel);
            this._sugarGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._sugarGroupBox.Location = new System.Drawing.Point(327, 233);
            this._sugarGroupBox.Name = "_sugarGroupBox";
            this._orderSystemTableLayoutPanel.SetRowSpan(this._sugarGroupBox, 2);
            this._sugarGroupBox.Size = new System.Drawing.Size(307, 108);
            this._sugarGroupBox.TabIndex = 4;
            this._sugarGroupBox.TabStop = false;
            this._sugarGroupBox.Text = "甜度";
            // 
            // _sugarTableLayoutPanel
            // 
            this._sugarTableLayoutPanel.ColumnCount = 2;
            this._sugarTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._sugarTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._sugarTableLayoutPanel.Controls.Add(this._sugarNoButton, 1, 1);
            this._sugarTableLayoutPanel.Controls.Add(this._sugarNormalButton, 0, 0);
            this._sugarTableLayoutPanel.Controls.Add(this._sugarLessButton, 0, 1);
            this._sugarTableLayoutPanel.Controls.Add(this._sugarHalfButton, 1, 0);
            this._sugarTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this._sugarTableLayoutPanel.Location = new System.Drawing.Point(3, 18);
            this._sugarTableLayoutPanel.Name = "_sugarTableLayoutPanel";
            this._sugarTableLayoutPanel.RowCount = 2;
            this._sugarTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._sugarTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._sugarTableLayoutPanel.Size = new System.Drawing.Size(301, 84);
            this._sugarTableLayoutPanel.TabIndex = 1;
            // 
            // _sugarNoButton
            // 
            this._sugarNoButton.AutoSize = true;
            this._sugarNoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._sugarNoButton.Location = new System.Drawing.Point(153, 45);
            this._sugarNoButton.Name = "_sugarNoButton";
            this._sugarNoButton.Size = new System.Drawing.Size(145, 36);
            this._sugarNoButton.TabIndex = 3;
            this._sugarNoButton.Text = "無糖";
            this._sugarNoButton.UseVisualStyleBackColor = true;
            this._sugarNoButton.Click += new System.EventHandler(this.ClickSugarButton);
            // 
            // _sugarNormalButton
            // 
            this._sugarNormalButton.AutoSize = true;
            this._sugarNormalButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._sugarNormalButton.Location = new System.Drawing.Point(3, 3);
            this._sugarNormalButton.Name = "_sugarNormalButton";
            this._sugarNormalButton.Size = new System.Drawing.Size(144, 36);
            this._sugarNormalButton.TabIndex = 0;
            this._sugarNormalButton.Text = "正常";
            this._sugarNormalButton.UseVisualStyleBackColor = true;
            this._sugarNormalButton.Click += new System.EventHandler(this.ClickSugarButton);
            // 
            // _sugarLessButton
            // 
            this._sugarLessButton.AutoSize = true;
            this._sugarLessButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._sugarLessButton.Location = new System.Drawing.Point(3, 45);
            this._sugarLessButton.Name = "_sugarLessButton";
            this._sugarLessButton.Size = new System.Drawing.Size(144, 36);
            this._sugarLessButton.TabIndex = 2;
            this._sugarLessButton.Text = "微糖";
            this._sugarLessButton.UseVisualStyleBackColor = true;
            this._sugarLessButton.Click += new System.EventHandler(this.ClickSugarButton);
            // 
            // _sugarHalfButton
            // 
            this._sugarHalfButton.AutoSize = true;
            this._sugarHalfButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._sugarHalfButton.Location = new System.Drawing.Point(153, 3);
            this._sugarHalfButton.Name = "_sugarHalfButton";
            this._sugarHalfButton.Size = new System.Drawing.Size(145, 36);
            this._sugarHalfButton.TabIndex = 1;
            this._sugarHalfButton.Text = "半糖";
            this._sugarHalfButton.UseVisualStyleBackColor = true;
            this._sugarHalfButton.Click += new System.EventHandler(this.ClickSugarButton);
            // 
            // _totalPriceTableLayoutPanel
            // 
            this._totalPriceTableLayoutPanel.ColumnCount = 2;
            this._totalPriceTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.69486F));
            this._totalPriceTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.30514F));
            this._totalPriceTableLayoutPanel.Controls.Add(this._buyButton, 1, 0);
            this._totalPriceTableLayoutPanel.Controls.Add(this._totalPriceLabel, 0, 0);
            this._totalPriceTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._totalPriceTableLayoutPanel.Location = new System.Drawing.Point(648, 404);
            this._totalPriceTableLayoutPanel.Name = "_totalPriceTableLayoutPanel";
            this._totalPriceTableLayoutPanel.RowCount = 1;
            this._totalPriceTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._totalPriceTableLayoutPanel.Size = new System.Drawing.Size(334, 53);
            this._totalPriceTableLayoutPanel.TabIndex = 8;
            // 
            // _buyButton
            // 
            this._buyButton.AutoSize = true;
            this._buyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._buyButton.Enabled = false;
            this._buyButton.Location = new System.Drawing.Point(239, 3);
            this._buyButton.Name = "_buyButton";
            this._buyButton.Size = new System.Drawing.Size(92, 47);
            this._buyButton.TabIndex = 7;
            this._buyButton.Text = "結帳";
            this._buyButton.UseVisualStyleBackColor = true;
            this._buyButton.Click += new System.EventHandler(this.ClickCheckOutButton);
            // 
            // _totalPriceLabel
            // 
            this._totalPriceLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._totalPriceLabel.AutoSize = true;
            this._totalPriceLabel.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._totalPriceLabel.Location = new System.Drawing.Point(3, 14);
            this._totalPriceLabel.Name = "_totalPriceLabel";
            this._totalPriceLabel.Size = new System.Drawing.Size(60, 24);
            this._totalPriceLabel.TabIndex = 6;
            this._totalPriceLabel.Text = "總價";
            // 
            // _backStageTabPage
            // 
            this._backStageTabPage.Controls.Add(this._backStageTableLayoutPanel);
            this._backStageTabPage.Location = new System.Drawing.Point(4, 22);
            this._backStageTabPage.Name = "_backStageTabPage";
            this._backStageTabPage.Padding = new System.Windows.Forms.Padding(3);
            this._backStageTabPage.Size = new System.Drawing.Size(991, 466);
            this._backStageTabPage.TabIndex = 1;
            this._backStageTabPage.Text = "後台管理";
            this._backStageTabPage.UseVisualStyleBackColor = true;
            // 
            // _backStageTableLayoutPanel
            // 
            this._backStageTableLayoutPanel.ColumnCount = 5;
            this._backStageTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.35478F));
            this._backStageTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.064698F));
            this._backStageTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.35478F));
            this._backStageTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.870956F));
            this._backStageTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.35478F));
            this._backStageTableLayoutPanel.Controls.Add(this._backDrinksGroupBox, 0, 0);
            this._backStageTableLayoutPanel.Controls.Add(this._backAdditionListGroupBox, 4, 0);
            this._backStageTableLayoutPanel.Controls.Add(this._backDrinksListControlGroupBox, 2, 0);
            this._backStageTableLayoutPanel.Controls.Add(this._backDrinksAdditionControlGroupBox, 2, 2);
            this._backStageTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._backStageTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this._backStageTableLayoutPanel.Name = "_backStageTableLayoutPanel";
            this._backStageTableLayoutPanel.RowCount = 4;
            this._backStageTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._backStageTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._backStageTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._backStageTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._backStageTableLayoutPanel.Size = new System.Drawing.Size(985, 460);
            this._backStageTableLayoutPanel.TabIndex = 0;
            // 
            // _backDrinksGroupBox
            // 
            this._backDrinksGroupBox.Controls.Add(this._backDrinksListDataGridView);
            this._backDrinksGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._backDrinksGroupBox.Location = new System.Drawing.Point(3, 3);
            this._backDrinksGroupBox.Name = "_backDrinksGroupBox";
            this._backStageTableLayoutPanel.SetRowSpan(this._backDrinksGroupBox, 4);
            this._backDrinksGroupBox.Size = new System.Drawing.Size(283, 454);
            this._backDrinksGroupBox.TabIndex = 0;
            this._backDrinksGroupBox.TabStop = false;
            this._backDrinksGroupBox.Text = "飲料清單";
            // 
            // _backDrinksListDataGridView
            // 
            this._backDrinksListDataGridView.AllowUserToAddRows = false;
            this._backDrinksListDataGridView.AllowUserToResizeColumns = false;
            this._backDrinksListDataGridView.AllowUserToResizeRows = false;
            this._backDrinksListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._backDrinksListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._backDrinksListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._backDrinksListButtonColumn,
            this._backDrinksListNameColumn,
            this._backDrinksListPriceColumn});
            this._backDrinksListDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._backDrinksListDataGridView.Location = new System.Drawing.Point(3, 18);
            this._backDrinksListDataGridView.Name = "_backDrinksListDataGridView";
            this._backDrinksListDataGridView.RowHeadersVisible = false;
            this._backDrinksListDataGridView.RowTemplate.Height = 24;
            this._backDrinksListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this._backDrinksListDataGridView.Size = new System.Drawing.Size(277, 433);
            this._backDrinksListDataGridView.TabIndex = 1;
            this._backDrinksListDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickBackDrinkDataGridView);
            this._backDrinksListDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChangeBackDrinkDataGridView);
            // 
            // _backDrinksListButtonColumn
            // 
            this._backDrinksListButtonColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this._backDrinksListButtonColumn.HeaderText = "";
            this._backDrinksListButtonColumn.Name = "_backDrinksListButtonColumn";
            this._backDrinksListButtonColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this._backDrinksListButtonColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this._backDrinksListButtonColumn.Width = 40;
            // 
            // _backDrinksListNameColumn
            // 
            this._backDrinksListNameColumn.HeaderText = "價格";
            this._backDrinksListNameColumn.Name = "_backDrinksListNameColumn";
            this._backDrinksListNameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _backDrinksListPriceColumn
            // 
            this._backDrinksListPriceColumn.HeaderText = "價格";
            this._backDrinksListPriceColumn.Name = "_backDrinksListPriceColumn";
            this._backDrinksListPriceColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _backAdditionListGroupBox
            // 
            this._backAdditionListGroupBox.Controls.Add(this._backAdditionListDataGridView);
            this._backAdditionListGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._backAdditionListGroupBox.Location = new System.Drawing.Point(697, 3);
            this._backAdditionListGroupBox.Name = "_backAdditionListGroupBox";
            this._backStageTableLayoutPanel.SetRowSpan(this._backAdditionListGroupBox, 4);
            this._backAdditionListGroupBox.Size = new System.Drawing.Size(285, 454);
            this._backAdditionListGroupBox.TabIndex = 3;
            this._backAdditionListGroupBox.TabStop = false;
            this._backAdditionListGroupBox.Text = "加料清單";
            // 
            // _backAdditionListDataGridView
            // 
            this._backAdditionListDataGridView.AllowUserToAddRows = false;
            this._backAdditionListDataGridView.AllowUserToResizeColumns = false;
            this._backAdditionListDataGridView.AllowUserToResizeRows = false;
            this._backAdditionListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._backAdditionListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._backAdditionButtonColumn,
            this._backAdditionListNameColumn,
            this._backAdditionListPriceColumn});
            this._backAdditionListDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._backAdditionListDataGridView.Location = new System.Drawing.Point(3, 18);
            this._backAdditionListDataGridView.Name = "_backAdditionListDataGridView";
            this._backAdditionListDataGridView.RowHeadersVisible = false;
            this._backAdditionListDataGridView.RowTemplate.Height = 24;
            this._backAdditionListDataGridView.Size = new System.Drawing.Size(279, 433);
            this._backAdditionListDataGridView.TabIndex = 1;
            this._backAdditionListDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickBackAdditionDataGridView);
            this._backAdditionListDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChangeBackAdditionDataGridView);
            // 
            // _backAdditionButtonColumn
            // 
            this._backAdditionButtonColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this._backAdditionButtonColumn.HeaderText = "";
            this._backAdditionButtonColumn.Name = "_backAdditionButtonColumn";
            this._backAdditionButtonColumn.Width = 40;
            // 
            // _backAdditionListNameColumn
            // 
            this._backAdditionListNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._backAdditionListNameColumn.HeaderText = "名稱";
            this._backAdditionListNameColumn.Name = "_backAdditionListNameColumn";
            this._backAdditionListNameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _backAdditionListPriceColumn
            // 
            this._backAdditionListPriceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._backAdditionListPriceColumn.HeaderText = "價格";
            this._backAdditionListPriceColumn.Name = "_backAdditionListPriceColumn";
            this._backAdditionListPriceColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _backDrinksListControlGroupBox
            // 
            this._backDrinksListControlGroupBox.Controls.Add(this._backDrinksListControlTableLayoutPanel);
            this._backDrinksListControlGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._backDrinksListControlGroupBox.Location = new System.Drawing.Point(351, 3);
            this._backDrinksListControlGroupBox.Name = "_backDrinksListControlGroupBox";
            this._backStageTableLayoutPanel.SetRowSpan(this._backDrinksListControlGroupBox, 2);
            this._backDrinksListControlGroupBox.Size = new System.Drawing.Size(283, 224);
            this._backDrinksListControlGroupBox.TabIndex = 1;
            this._backDrinksListControlGroupBox.TabStop = false;
            this._backDrinksListControlGroupBox.Text = "飲料清單操作";
            // 
            // _backDrinksListControlTableLayoutPanel
            // 
            this._backDrinksListControlTableLayoutPanel.ColumnCount = 5;
            this._backDrinksListControlTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.72727F));
            this._backDrinksListControlTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.72727F));
            this._backDrinksListControlTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.09091F));
            this._backDrinksListControlTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.72727F));
            this._backDrinksListControlTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.72727F));
            this._backDrinksListControlTableLayoutPanel.Controls.Add(this._backDrinksListControlNewButton, 0, 0);
            this._backDrinksListControlTableLayoutPanel.Controls.Add(this._backDrinksListControlNewFromFileButton, 3, 0);
            this._backDrinksListControlTableLayoutPanel.Controls.Add(this._backDrinksListControlDrinkNameLabel, 0, 4);
            this._backDrinksListControlTableLayoutPanel.Controls.Add(this._backDrinkNameTextBox, 3, 4);
            this._backDrinksListControlTableLayoutPanel.Controls.Add(this._backDrinksListControlDrinkPriceLabel, 0, 6);
            this._backDrinksListControlTableLayoutPanel.Controls.Add(this._backDrinkPriceTextBox, 3, 6);
            this._backDrinksListControlTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._backDrinksListControlTableLayoutPanel.Location = new System.Drawing.Point(3, 18);
            this._backDrinksListControlTableLayoutPanel.Name = "_backDrinksListControlTableLayoutPanel";
            this._backDrinksListControlTableLayoutPanel.RowCount = 8;
            this._backDrinksListControlTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this._backDrinksListControlTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this._backDrinksListControlTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this._backDrinksListControlTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this._backDrinksListControlTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this._backDrinksListControlTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this._backDrinksListControlTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this._backDrinksListControlTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this._backDrinksListControlTableLayoutPanel.Size = new System.Drawing.Size(277, 203);
            this._backDrinksListControlTableLayoutPanel.TabIndex = 0;
            // 
            // _backDrinksListControlNewButton
            // 
            this._backDrinksListControlTableLayoutPanel.SetColumnSpan(this._backDrinksListControlNewButton, 2);
            this._backDrinksListControlNewButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._backDrinksListControlNewButton.Location = new System.Drawing.Point(3, 3);
            this._backDrinksListControlNewButton.Name = "_backDrinksListControlNewButton";
            this._backDrinksListControlTableLayoutPanel.SetRowSpan(this._backDrinksListControlNewButton, 2);
            this._backDrinksListControlNewButton.Size = new System.Drawing.Size(118, 44);
            this._backDrinksListControlNewButton.TabIndex = 0;
            this._backDrinksListControlNewButton.Text = "新增";
            this._backDrinksListControlNewButton.UseVisualStyleBackColor = true;
            this._backDrinksListControlNewButton.Click += new System.EventHandler(this.ClickNewDrinkButton);
            // 
            // _backDrinksListControlNewFromFileButton
            // 
            this._backDrinksListControlTableLayoutPanel.SetColumnSpan(this._backDrinksListControlNewFromFileButton, 2);
            this._backDrinksListControlNewFromFileButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._backDrinksListControlNewFromFileButton.Location = new System.Drawing.Point(152, 3);
            this._backDrinksListControlNewFromFileButton.Name = "_backDrinksListControlNewFromFileButton";
            this._backDrinksListControlTableLayoutPanel.SetRowSpan(this._backDrinksListControlNewFromFileButton, 2);
            this._backDrinksListControlNewFromFileButton.Size = new System.Drawing.Size(122, 44);
            this._backDrinksListControlNewFromFileButton.TabIndex = 1;
            this._backDrinksListControlNewFromFileButton.Text = "從檔案匯入";
            this._backDrinksListControlNewFromFileButton.UseVisualStyleBackColor = true;
            this._backDrinksListControlNewFromFileButton.Click += new System.EventHandler(this.ClickAddDrinksFormFile);
            // 
            // _backDrinksListControlDrinkNameLabel
            // 
            this._backDrinksListControlDrinkNameLabel.AutoSize = true;
            this._backDrinksListControlTableLayoutPanel.SetColumnSpan(this._backDrinksListControlDrinkNameLabel, 2);
            this._backDrinksListControlDrinkNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._backDrinksListControlDrinkNameLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._backDrinksListControlDrinkNameLabel.Location = new System.Drawing.Point(3, 100);
            this._backDrinksListControlDrinkNameLabel.Name = "_backDrinksListControlDrinkNameLabel";
            this._backDrinksListControlDrinkNameLabel.Size = new System.Drawing.Size(118, 25);
            this._backDrinksListControlDrinkNameLabel.TabIndex = 2;
            this._backDrinksListControlDrinkNameLabel.Text = "飲料名稱：";
            this._backDrinksListControlDrinkNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _backDrinkNameTextBox
            // 
            this._backDrinksListControlTableLayoutPanel.SetColumnSpan(this._backDrinkNameTextBox, 2);
            this._backDrinkNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._backDrinkNameTextBox.Enabled = false;
            this._backDrinkNameTextBox.Location = new System.Drawing.Point(152, 103);
            this._backDrinkNameTextBox.Name = "_backDrinkNameTextBox";
            this._backDrinkNameTextBox.Size = new System.Drawing.Size(122, 22);
            this._backDrinkNameTextBox.TabIndex = 3;
            // 
            // _backDrinksListControlDrinkPriceLabel
            // 
            this._backDrinksListControlDrinkPriceLabel.AutoSize = true;
            this._backDrinksListControlTableLayoutPanel.SetColumnSpan(this._backDrinksListControlDrinkPriceLabel, 2);
            this._backDrinksListControlDrinkPriceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._backDrinksListControlDrinkPriceLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._backDrinksListControlDrinkPriceLabel.Location = new System.Drawing.Point(3, 150);
            this._backDrinksListControlDrinkPriceLabel.Name = "_backDrinksListControlDrinkPriceLabel";
            this._backDrinksListControlDrinkPriceLabel.Size = new System.Drawing.Size(118, 25);
            this._backDrinksListControlDrinkPriceLabel.TabIndex = 4;
            this._backDrinksListControlDrinkPriceLabel.Text = "價格：";
            this._backDrinksListControlDrinkPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _backDrinkPriceTextBox
            // 
            this._backDrinksListControlTableLayoutPanel.SetColumnSpan(this._backDrinkPriceTextBox, 2);
            this._backDrinkPriceTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._backDrinkPriceTextBox.Enabled = false;
            this._backDrinkPriceTextBox.Location = new System.Drawing.Point(152, 153);
            this._backDrinkPriceTextBox.Name = "_backDrinkPriceTextBox";
            this._backDrinkPriceTextBox.Size = new System.Drawing.Size(122, 22);
            this._backDrinkPriceTextBox.TabIndex = 5;
            // 
            // _backDrinksAdditionControlGroupBox
            // 
            this._backDrinksAdditionControlGroupBox.Controls.Add(this._backAdditionListControlTableLayoutPanel);
            this._backDrinksAdditionControlGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._backDrinksAdditionControlGroupBox.Location = new System.Drawing.Point(351, 233);
            this._backDrinksAdditionControlGroupBox.Name = "_backDrinksAdditionControlGroupBox";
            this._backStageTableLayoutPanel.SetRowSpan(this._backDrinksAdditionControlGroupBox, 2);
            this._backDrinksAdditionControlGroupBox.Size = new System.Drawing.Size(283, 224);
            this._backDrinksAdditionControlGroupBox.TabIndex = 2;
            this._backDrinksAdditionControlGroupBox.TabStop = false;
            this._backDrinksAdditionControlGroupBox.Text = "加料清單操作";
            // 
            // _backAdditionListControlTableLayoutPanel
            // 
            this._backAdditionListControlTableLayoutPanel.ColumnCount = 5;
            this._backAdditionListControlTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.72727F));
            this._backAdditionListControlTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.72727F));
            this._backAdditionListControlTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.09091F));
            this._backAdditionListControlTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.72727F));
            this._backAdditionListControlTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.72727F));
            this._backAdditionListControlTableLayoutPanel.Controls.Add(this._backAdditionListControlAdditionPriceLabel, 0, 7);
            this._backAdditionListControlTableLayoutPanel.Controls.Add(this._backAdditionListControlNewButton, 0, 0);
            this._backAdditionListControlTableLayoutPanel.Controls.Add(this._backAdditionListNewFromFileButton, 3, 0);
            this._backAdditionListControlTableLayoutPanel.Controls.Add(this._backAdditionNameTextBox, 3, 5);
            this._backAdditionListControlTableLayoutPanel.Controls.Add(this._backAdditionListControlAdditionNameLabel, 0, 5);
            this._backAdditionListControlTableLayoutPanel.Controls.Add(this._backAdditionPriceTextBox, 3, 7);
            this._backAdditionListControlTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._backAdditionListControlTableLayoutPanel.Location = new System.Drawing.Point(3, 18);
            this._backAdditionListControlTableLayoutPanel.Name = "_backAdditionListControlTableLayoutPanel";
            this._backAdditionListControlTableLayoutPanel.RowCount = 9;
            this._backAdditionListControlTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this._backAdditionListControlTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this._backAdditionListControlTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this._backAdditionListControlTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this._backAdditionListControlTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this._backAdditionListControlTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this._backAdditionListControlTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this._backAdditionListControlTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this._backAdditionListControlTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._backAdditionListControlTableLayoutPanel.Size = new System.Drawing.Size(277, 203);
            this._backAdditionListControlTableLayoutPanel.TabIndex = 1;
            // 
            // _backAdditionListControlAdditionPriceLabel
            // 
            this._backAdditionListControlAdditionPriceLabel.AutoSize = true;
            this._backAdditionListControlTableLayoutPanel.SetColumnSpan(this._backAdditionListControlAdditionPriceLabel, 2);
            this._backAdditionListControlAdditionPriceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._backAdditionListControlAdditionPriceLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._backAdditionListControlAdditionPriceLabel.Location = new System.Drawing.Point(3, 154);
            this._backAdditionListControlAdditionPriceLabel.Name = "_backAdditionListControlAdditionPriceLabel";
            this._backAdditionListControlAdditionPriceLabel.Size = new System.Drawing.Size(118, 22);
            this._backAdditionListControlAdditionPriceLabel.TabIndex = 8;
            this._backAdditionListControlAdditionPriceLabel.Text = "價格：";
            this._backAdditionListControlAdditionPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _backAdditionListControlNewButton
            // 
            this._backAdditionListControlTableLayoutPanel.SetColumnSpan(this._backAdditionListControlNewButton, 2);
            this._backAdditionListControlNewButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._backAdditionListControlNewButton.Location = new System.Drawing.Point(3, 3);
            this._backAdditionListControlNewButton.Name = "_backAdditionListControlNewButton";
            this._backAdditionListControlTableLayoutPanel.SetRowSpan(this._backAdditionListControlNewButton, 2);
            this._backAdditionListControlNewButton.Size = new System.Drawing.Size(118, 38);
            this._backAdditionListControlNewButton.TabIndex = 0;
            this._backAdditionListControlNewButton.Text = "新增";
            this._backAdditionListControlNewButton.UseVisualStyleBackColor = true;
            this._backAdditionListControlNewButton.Click += new System.EventHandler(this.ClickNewAdditionButton);
            // 
            // _backAdditionListNewFromFileButton
            // 
            this._backAdditionListControlTableLayoutPanel.SetColumnSpan(this._backAdditionListNewFromFileButton, 2);
            this._backAdditionListNewFromFileButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._backAdditionListNewFromFileButton.Location = new System.Drawing.Point(152, 3);
            this._backAdditionListNewFromFileButton.Name = "_backAdditionListNewFromFileButton";
            this._backAdditionListControlTableLayoutPanel.SetRowSpan(this._backAdditionListNewFromFileButton, 2);
            this._backAdditionListNewFromFileButton.Size = new System.Drawing.Size(122, 38);
            this._backAdditionListNewFromFileButton.TabIndex = 1;
            this._backAdditionListNewFromFileButton.Text = "從檔案匯入";
            this._backAdditionListNewFromFileButton.UseVisualStyleBackColor = true;
            this._backAdditionListNewFromFileButton.Click += new System.EventHandler(this.ClickAddAdditionFromFile);
            // 
            // _backAdditionNameTextBox
            // 
            this._backAdditionListControlTableLayoutPanel.SetColumnSpan(this._backAdditionNameTextBox, 2);
            this._backAdditionNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._backAdditionNameTextBox.Enabled = false;
            this._backAdditionNameTextBox.Location = new System.Drawing.Point(152, 113);
            this._backAdditionNameTextBox.Name = "_backAdditionNameTextBox";
            this._backAdditionNameTextBox.Size = new System.Drawing.Size(122, 22);
            this._backAdditionNameTextBox.TabIndex = 7;
            // 
            // _backAdditionListControlAdditionNameLabel
            // 
            this._backAdditionListControlAdditionNameLabel.AutoSize = true;
            this._backAdditionListControlTableLayoutPanel.SetColumnSpan(this._backAdditionListControlAdditionNameLabel, 2);
            this._backAdditionListControlAdditionNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._backAdditionListControlAdditionNameLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._backAdditionListControlAdditionNameLabel.Location = new System.Drawing.Point(3, 110);
            this._backAdditionListControlAdditionNameLabel.Name = "_backAdditionListControlAdditionNameLabel";
            this._backAdditionListControlAdditionNameLabel.Size = new System.Drawing.Size(118, 22);
            this._backAdditionListControlAdditionNameLabel.TabIndex = 6;
            this._backAdditionListControlAdditionNameLabel.Text = "加料名稱：";
            this._backAdditionListControlAdditionNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _backAdditionPriceTextBox
            // 
            this._backAdditionListControlTableLayoutPanel.SetColumnSpan(this._backAdditionPriceTextBox, 2);
            this._backAdditionPriceTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._backAdditionPriceTextBox.Enabled = false;
            this._backAdditionPriceTextBox.Location = new System.Drawing.Point(152, 157);
            this._backAdditionPriceTextBox.Name = "_backAdditionPriceTextBox";
            this._backAdditionPriceTextBox.Size = new System.Drawing.Size(122, 22);
            this._backAdditionPriceTextBox.TabIndex = 9;
            // 
            // _historyTabPage
            // 
            this._historyTabPage.Controls.Add(this._historyTableLayOut);
            this._historyTabPage.Location = new System.Drawing.Point(4, 22);
            this._historyTabPage.Name = "_historyTabPage";
            this._historyTabPage.Padding = new System.Windows.Forms.Padding(3);
            this._historyTabPage.Size = new System.Drawing.Size(991, 466);
            this._historyTabPage.TabIndex = 2;
            this._historyTabPage.Text = "歷史紀錄";
            this._historyTabPage.UseVisualStyleBackColor = true;
            // 
            // _historyTableLayOut
            // 
            this._historyTableLayOut.ColumnCount = 2;
            this._historyTableLayOut.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._historyTableLayOut.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._historyTableLayOut.Controls.Add(this._historyGroupBox, 0, 0);
            this._historyTableLayOut.Controls.Add(this._listGroupBox, 1, 0);
            this._historyTableLayOut.Controls.Add(this._listTotalPriceLabel, 1, 1);
            this._historyTableLayOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this._historyTableLayOut.Location = new System.Drawing.Point(3, 3);
            this._historyTableLayOut.Name = "_historyTableLayOut";
            this._historyTableLayOut.RowCount = 2;
            this._historyTableLayOut.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._historyTableLayOut.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this._historyTableLayOut.Size = new System.Drawing.Size(985, 460);
            this._historyTableLayOut.TabIndex = 0;
            // 
            // _historyGroupBox
            // 
            this._historyGroupBox.Controls.Add(this._historyDataGridView);
            this._historyGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._historyGroupBox.Location = new System.Drawing.Point(3, 3);
            this._historyGroupBox.Name = "_historyGroupBox";
            this._historyTableLayOut.SetRowSpan(this._historyGroupBox, 2);
            this._historyGroupBox.Size = new System.Drawing.Size(486, 454);
            this._historyGroupBox.TabIndex = 0;
            this._historyGroupBox.TabStop = false;
            this._historyGroupBox.Text = "歷史";
            // 
            // _historyDataGridView
            // 
            this._historyDataGridView.AllowUserToAddRows = false;
            this._historyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._historyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._historyTime,
            this._historyPrice});
            this._historyDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._historyDataGridView.Location = new System.Drawing.Point(3, 18);
            this._historyDataGridView.Name = "_historyDataGridView";
            this._historyDataGridView.ReadOnly = true;
            this._historyDataGridView.RowHeadersVisible = false;
            this._historyDataGridView.RowTemplate.Height = 24;
            this._historyDataGridView.Size = new System.Drawing.Size(480, 433);
            this._historyDataGridView.TabIndex = 0;
            this._historyDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickHistoryTimeList);
            // 
            // _historyTime
            // 
            this._historyTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._historyTime.FillWeight = 80F;
            this._historyTime.HeaderText = "時間";
            this._historyTime.Name = "_historyTime";
            this._historyTime.ReadOnly = true;
            // 
            // _historyPrice
            // 
            this._historyPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._historyPrice.FillWeight = 20F;
            this._historyPrice.HeaderText = "價格";
            this._historyPrice.Name = "_historyPrice";
            this._historyPrice.ReadOnly = true;
            // 
            // _listGroupBox
            // 
            this._listGroupBox.Controls.Add(this._listDataGridView);
            this._listGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._listGroupBox.Location = new System.Drawing.Point(495, 3);
            this._listGroupBox.Name = "_listGroupBox";
            this._listGroupBox.Size = new System.Drawing.Size(487, 393);
            this._listGroupBox.TabIndex = 1;
            this._listGroupBox.TabStop = false;
            this._listGroupBox.Text = "詳細";
            // 
            // _listDataGridView
            // 
            this._listDataGridView.AllowUserToAddRows = false;
            this._listDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._listDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._listName,
            this._listPrice,
            this._listSugar,
            this._listIce,
            this._listAddition});
            this._listDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._listDataGridView.Enabled = false;
            this._listDataGridView.Location = new System.Drawing.Point(3, 18);
            this._listDataGridView.Name = "_listDataGridView";
            this._listDataGridView.ReadOnly = true;
            this._listDataGridView.RowHeadersVisible = false;
            this._listDataGridView.RowTemplate.Height = 24;
            this._listDataGridView.Size = new System.Drawing.Size(481, 372);
            this._listDataGridView.TabIndex = 0;
            // 
            // _listName
            // 
            this._listName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._listName.FillWeight = 30F;
            this._listName.HeaderText = "飲料名稱";
            this._listName.Name = "_listName";
            this._listName.ReadOnly = true;
            // 
            // _listPrice
            // 
            this._listPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._listPrice.FillWeight = 25F;
            this._listPrice.HeaderText = "價格";
            this._listPrice.Name = "_listPrice";
            this._listPrice.ReadOnly = true;
            // 
            // _listSugar
            // 
            this._listSugar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._listSugar.FillWeight = 20F;
            this._listSugar.HeaderText = "甜度";
            this._listSugar.Name = "_listSugar";
            this._listSugar.ReadOnly = true;
            // 
            // _listIce
            // 
            this._listIce.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._listIce.FillWeight = 20F;
            this._listIce.HeaderText = "溫度";
            this._listIce.Name = "_listIce";
            this._listIce.ReadOnly = true;
            // 
            // _listAddition
            // 
            this._listAddition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._listAddition.FillWeight = 30F;
            this._listAddition.HeaderText = "加料";
            this._listAddition.Name = "_listAddition";
            this._listAddition.ReadOnly = true;
            // 
            // _listTotalPriceLabel
            // 
            this._listTotalPriceLabel.AutoSize = true;
            this._listTotalPriceLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this._listTotalPriceLabel.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._listTotalPriceLabel.Location = new System.Drawing.Point(895, 399);
            this._listTotalPriceLabel.Name = "_listTotalPriceLabel";
            this._listTotalPriceLabel.Size = new System.Drawing.Size(87, 61);
            this._listTotalPriceLabel.TabIndex = 2;
            this._listTotalPriceLabel.Text = "總價:";
            // 
            // EzDrinkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(999, 516);
            this.Controls.Add(this._orderTabControl);
            this.Controls.Add(this._menuStrip);
            this.MainMenuStrip = this._menuStrip;
            this.MinimumSize = new System.Drawing.Size(1015, 554);
            this.Name = "EzDrinkForm";
            this.Text = "EzDrinkForm";
            this._menuStrip.ResumeLayout(false);
            this._menuStrip.PerformLayout();
            this._orderTabControl.ResumeLayout(false);
            this._orderTabPage.ResumeLayout(false);
            this._orderSystemTableLayoutPanel.ResumeLayout(false);
            this._drinkGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._drinkListDataGridView)).EndInit();
            this._additionGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._additionDataGridView)).EndInit();
            this._orderGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._orderListDataGridView)).EndInit();
            this._temperatureGroupBox.ResumeLayout(false);
            this._temperatureGroupBox.PerformLayout();
            this._temperatureTableLayoutPanel.ResumeLayout(false);
            this._temperatureTableLayoutPanel.PerformLayout();
            this._sugarGroupBox.ResumeLayout(false);
            this._sugarTableLayoutPanel.ResumeLayout(false);
            this._sugarTableLayoutPanel.PerformLayout();
            this._totalPriceTableLayoutPanel.ResumeLayout(false);
            this._totalPriceTableLayoutPanel.PerformLayout();
            this._backStageTabPage.ResumeLayout(false);
            this._backStageTableLayoutPanel.ResumeLayout(false);
            this._backDrinksGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._backDrinksListDataGridView)).EndInit();
            this._backAdditionListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._backAdditionListDataGridView)).EndInit();
            this._backDrinksListControlGroupBox.ResumeLayout(false);
            this._backDrinksListControlTableLayoutPanel.ResumeLayout(false);
            this._backDrinksListControlTableLayoutPanel.PerformLayout();
            this._backDrinksAdditionControlGroupBox.ResumeLayout(false);
            this._backAdditionListControlTableLayoutPanel.ResumeLayout(false);
            this._backAdditionListControlTableLayoutPanel.PerformLayout();
            this._historyTabPage.ResumeLayout(false);
            this._historyTableLayOut.ResumeLayout(false);
            this._historyTableLayOut.PerformLayout();
            this._historyGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._historyDataGridView)).EndInit();
            this._listGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._listDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip _menuStrip;
        private ToolStripMenuItem _fileToolStripMenuItem;
        private ToolStripMenuItem _exitMenuItem;
        private TabControl _orderTabControl;
        private TabPage _orderTabPage;
        private GroupBox _drinkGroupBox;
        private DataGridView _drinkListDataGridView;
        private GroupBox _orderGroupBox;
        private DataGridView _orderListDataGridView;
        private Button _buyButton;
        private Label _totalPriceLabel;
        private GroupBox _temperatureGroupBox;
        private Button _hotButton;
        private Button _iceNoButton;
        private Button _iceLessButton;
        private Button _iceNormalButton;
        private GroupBox _sugarGroupBox;
        private Button _sugarNoButton;
        private Button _sugarLessButton;
        private Button _sugarHalfButton;
        private Button _sugarNormalButton;
        private GroupBox _additionGroupBox;
        private DataGridView _additionDataGridView;
        private DataGridViewButtonColumn _drinkButton;
        private DataGridViewTextBoxColumn _drinkName;
        private DataGridViewTextBoxColumn _drinkPrice;
        private DataGridViewTextBoxColumn _orderName;
        private DataGridViewTextBoxColumn _orderPrice;
        private DataGridViewTextBoxColumn _orderSugar;
        private DataGridViewTextBoxColumn _orderIce;
        private DataGridViewTextBoxColumn _orderAddition;
        private DataGridViewButtonColumn _orderDelete;
        private TableLayoutPanel _temperatureTableLayoutPanel;
        private TableLayoutPanel _sugarTableLayoutPanel;
        private TableLayoutPanel _orderSystemTableLayoutPanel;
        private TableLayoutPanel _totalPriceTableLayoutPanel;
        private ToolStripMenuItem _helpToolStripMenuItem;
        private ToolStripMenuItem _aboutToolStripMenuItem;
        private TabPage _backStageTabPage;
        private TableLayoutPanel _backStageTableLayoutPanel;
        private GroupBox _backDrinksGroupBox;
        private DataGridView _backDrinksListDataGridView;
        private GroupBox _backAdditionListGroupBox;
        private DataGridView _backAdditionListDataGridView;
        private GroupBox _backDrinksListControlGroupBox;
        private TableLayoutPanel _backDrinksListControlTableLayoutPanel;
        private Button _backDrinksListControlNewButton;
        private Button _backDrinksListControlNewFromFileButton;
        private Label _backDrinksListControlDrinkNameLabel;
        private TextBox _backDrinkNameTextBox;
        private GroupBox _backDrinksAdditionControlGroupBox;
        private TableLayoutPanel _backAdditionListControlTableLayoutPanel;
        private Button _backAdditionListControlNewButton;
        private Button _backAdditionListNewFromFileButton;
        private Label _backDrinksListControlDrinkPriceLabel;
        private TextBox _backDrinkPriceTextBox;
        private Label _backAdditionListControlAdditionPriceLabel;
        private TextBox _backAdditionNameTextBox;
        private Label _backAdditionListControlAdditionNameLabel;
        private TextBox _backAdditionPriceTextBox;
        private DataGridViewButtonColumn _backDrinksListButtonColumn;
        private DataGridViewTextBoxColumn _backDrinksListNameColumn;
        private DataGridViewTextBoxColumn _backDrinksListPriceColumn;
        private DataGridViewButtonColumn _backAdditionButtonColumn;
        private DataGridViewTextBoxColumn _backAdditionListNameColumn;
        private DataGridViewTextBoxColumn _backAdditionListPriceColumn;
        private DataGridViewDisableButtonColumn _additionButtonColumn;
        private DataGridViewTextBoxColumn _additionNameColumn;
        private DataGridViewTextBoxColumn _additionPriceColumn;
        private TabPage _historyTabPage;
        private TableLayoutPanel _historyTableLayOut;
        private GroupBox _historyGroupBox;
        private DataGridView _historyDataGridView;
        private DataGridViewTextBoxColumn _historyTime;
        private DataGridViewTextBoxColumn _historyPrice;
        private GroupBox _listGroupBox;
        private DataGridView _listDataGridView;
        private DataGridViewTextBoxColumn _listName;
        private DataGridViewTextBoxColumn _listPrice;
        private DataGridViewTextBoxColumn _listSugar;
        private DataGridViewTextBoxColumn _listIce;
        private DataGridViewTextBoxColumn _listAddition;
        private Label _listTotalPriceLabel;
    }
}