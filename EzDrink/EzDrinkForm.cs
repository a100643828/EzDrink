using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EzDrink
{
    public partial class EzDrinkForm : Form
    {
        const string OPEN_FAIL = "開檔失敗";
        EzDrinkModel _drinkModel;
        EzDrinkPresentationModel _drinkPresentationModel;
        const string CHOOSE = "選擇";
        const string DELETE = "刪除";
        const int ONE = 1;
        const int TWO = 2;
        const string TOTAL_PRICE = "總價:";
        const string DOLLAR = "元";
        public EzDrinkForm(EzDrinkModel model, EzDrinkPresentationModel presentationModel)
        {
            InitializeComponent();
            this._drinkModel = model;
            _drinkPresentationModel = presentationModel;
        }
        //共用

        //離開程式
        private void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //飲料顯示刷新
        private void RefreshDrinkDataGridView()
        {
            _drinkListDataGridView.RowCount = 0;
            _backDrinksListDataGridView.RowCount = 0;
            for (int i = 0; i < _drinkModel.GetDrinksList().Count(); i++)
            {
                _drinkListDataGridView.Rows.Add(CHOOSE, _drinkModel.GetDrinksList()[i].GetDrinkName(), _drinkModel.GetDrinksList()[i].GetDrinkPrice());
                _backDrinksListDataGridView.Rows.Add(DELETE, _drinkModel.GetDrinksList()[i].GetDrinkName(), _drinkModel.GetDrinksList()[i].GetDrinkPrice());
            }
        }

        //加料顯示刷新
        private void RefreshAdditionDataGridView()
        {
            _additionDataGridView.RowCount = 0;
            _backAdditionListDataGridView.RowCount = 0;
            for (int i = 0; i < _drinkModel.GetDrinkAdditionsList().Count(); i++)
            {
                _additionDataGridView.Rows.Add(CHOOSE, _drinkModel.GetDrinkAdditionsList()[i].GetAdditionName(), _drinkModel.GetDrinkAdditionsList()[i].GetAdditionPrice());
                _backAdditionListDataGridView.Rows.Add(DELETE, _drinkModel.GetDrinkAdditionsList()[i].GetAdditionName(), _drinkModel.GetDrinkAdditionsList()[i].GetAdditionPrice());
            }
        }

        //Tab1

        //更新點單顯示
        private void RefreshOrderDataGridView()
        {
            _orderListDataGridView.RowCount = 0;
            for (int i = 0; i < _drinkModel.GetNowOrders().GetOrderCount(); i++)
                _orderListDataGridView.Rows.Add(_drinkModel.GetNowOrders().GetOrderDrinkName(i), _drinkModel.GetNowOrders().GetOrderDrinkPrice(i), _drinkModel.GetNowOrders().GetOrderDrinkSugar(i), _drinkModel.GetNowOrders().GetOrderDrinkTemperature(i), _drinkModel.GetNowOrders().GetOrderDrinkAddition(i), DELETE);
            string totalPrice = TOTAL_PRICE + _drinkModel.GetTotalPrice().ToString() + DOLLAR;
            _totalPriceLabel.Text = totalPrice;
            _buyButton.Enabled = _drinkModel.IsOrdersComplete();
            RefreshAdditionButton();
        }

        //點擊飲料菜單
        private void DrinkListDataGridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                const int NAMECOLUMN = 1;
                const int PRICECOLUMN = 2;
                _drinkModel.AddDrinkToOrders(_drinkListDataGridView[NAMECOLUMN, e.RowIndex].Value.ToString(), Convert.ToInt32(_drinkListDataGridView[PRICECOLUMN, e.RowIndex].Value));
                RefreshOrderDataGridView();
            }
        }

        //點擊甜度按鈕
        private void ClickSugarButton(object sender, EventArgs e)
        {
            _drinkModel.SetOrdersDrinkSugar(_orderListDataGridView.CurrentCellAddress.Y, ((Button)sender).Text);
            RefreshOrderDataGridView();
        }

        //點擊正常溫度按鈕
        private void ClickIceButton(object sender, EventArgs e)
        {
            _drinkModel.SetOrdersDrinkTemperature(_orderListDataGridView.CurrentCellAddress.Y, ((Button)sender).Text);
            RefreshOrderDataGridView();
        }

        //點擊加料按鈕
        private void ClickAdditionDataGridView(object sender, DataGridViewCellEventArgs e)
        {
            if (_orderListDataGridView.CurrentCell != null)
                if (e.ColumnIndex == 0 && e.RowIndex >= 0)
                    if (!(_drinkModel.IsOrdersDrinkAdditionSelect(_orderListDataGridView.CurrentCellAddress.Y, _additionDataGridView[ONE, e.RowIndex].Value.ToString())))
                    {
                        _drinkModel.AddAdditionToOrdersDrink(_orderListDataGridView.CurrentCellAddress.Y, _additionDataGridView[ONE, e.RowIndex].Value.ToString(), Convert.ToInt32(_additionDataGridView[TWO, e.RowIndex].Value));
                        RefreshAdditionButton();
                        RefreshOrderDataGridView();
                    }
        }

        //更新加料按鈕
        private void RefreshAdditionButton()
        {
            foreach (DataGridViewRow row in _additionDataGridView.Rows)
                if (_drinkModel.GetNowOrders().GetOrderCount() != 0)
                    ((DataGridViewDisableButtonCell)row.Cells[0]).Enabled = _drinkPresentationModel.IsAdditionButtonAble(_orderListDataGridView.CurrentCellAddress.Y, row.Cells[1].Value.ToString());
                else
                    ((DataGridViewDisableButtonCell)row.Cells[0]).Enabled = false;
            _additionDataGridView.Refresh();
        }

        //點擊點單中刪除按鈕
        private void ClickOrderListDataGridView(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.RowIndex >= 0)
            {
                _drinkModel.DeleteOrdersDrink(e.RowIndex);
                RefreshOrderDataGridView();
            }
            RefreshAdditionButton();
        }

        //點擊結帳按鈕
        private void ClickCheckOutButton(object sender, EventArgs e)
        {
            _drinkModel.CheckOut();
            RefreshOrderDataGridView();
        }

        //Tab2

        //點擊從檔案加入飲料
        private void ClickAddDrinksFormFile(object sender, EventArgs e)
        {
            if (_drinkPresentationModel.ClickNewDrinkFormFileEvent())
            {
                RefreshBackStageObject();
                RefreshDrinkDataGridView();
            }
            else
                MessageBox.Show(OPEN_FAIL);
        }

        //點擊從檔案加入加料
        private void ClickAddAdditionFromFile(object sender, EventArgs e)
        {
            if (_drinkPresentationModel.ClickNewAdditionFormFileEvent())
            {
                RefreshBackStageObject();
                RefreshAdditionDataGridView();
            }
            else
                MessageBox.Show(OPEN_FAIL);
        }

        //點擊後台飲料DGV中的刪除
        private void ClickBackDrinkDataGridView(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
                if (WarnMessageBoxResult() == DialogResult.Yes)
                {
                    _drinkModel.DeleteDrink(e.RowIndex);
                    RefreshDrinkDataGridView();
                }
        }

        //點擊後台加料DGV中的刪除
        private void ClickBackAdditionDataGridView(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
                if (WarnMessageBoxResult() == DialogResult.Yes)
                {
                    _drinkModel.DeleteAddition(e.RowIndex);
                    RefreshAdditionDataGridView();
                }
        }

        //確認刪除的警告視窗結果
        private static DialogResult WarnMessageBoxResult()
        {
            const string TITLE = "警告";
            const string CONFIRM = "確定要刪除?";
            DialogResult dialogResult = MessageBox.Show(CONFIRM, TITLE, MessageBoxButtons.YesNo);
            return dialogResult;
        }

        //編輯後台飲料DGV
        private void ChangeBackDrinkDataGridView(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _drinkModel.SetDrink(e.RowIndex, _backDrinksListDataGridView[ONE, e.RowIndex].Value.ToString(), Convert.ToInt32(_backDrinksListDataGridView[TWO, e.RowIndex].Value.ToString()));
                RefreshDrinkDataGridView();
            }
        }

        //編輯後台加料DGV
        private void ChangeBackAdditionDataGridView(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _drinkModel.SetAddition(e.RowIndex, _backAdditionListDataGridView[ONE, e.RowIndex].Value.ToString(), Convert.ToInt32(_backAdditionListDataGridView[TWO, e.RowIndex].Value.ToString()));
                RefreshAdditionDataGridView();
            }
        }

        //點擊新增飲料按鈕
        private void ClickNewDrinkButton(object sender, EventArgs e)
        {
            if (!_drinkPresentationModel.ClickNewDrinkButton(_backDrinkNameTextBox.Text, _backDrinkPriceTextBox.Text))
                MessageBox.Show("飲料已存在");
            RefreshBackStageObject();
            RefreshDrinkDataGridView();
        }

        //更新後台物件狀態
        private void RefreshBackStageObject()
        {
            //_backDrinkNameTextBox.DataBindings.Add("Enable",_drinkPresentationModel, "_newDrinkNamePriceState");
            _backDrinkNameTextBox.Enabled = _drinkPresentationModel.GetNewDrinkNamePriceState();
            _backDrinkNameTextBox.Text = "";
            _backDrinkPriceTextBox.Enabled = _drinkPresentationModel.GetNewDrinkNamePriceState();
            _backDrinkPriceTextBox.Text = "";
            _backDrinksListControlNewButton.Text = _drinkPresentationModel.GetNewDrinkButtonState();
            _backDrinksListControlNewFromFileButton.Text = _drinkPresentationModel.GetNewDrinkFromFileState();
            _backAdditionNameTextBox.Enabled = _drinkPresentationModel.GetNewAdditionNamePriceState();
            _backAdditionNameTextBox.Text = "";
            _backAdditionPriceTextBox.Enabled = _drinkPresentationModel.GetNewAdditionNamePriceState();
            _backAdditionPriceTextBox.Text = "";
            _backAdditionListControlNewButton.Text = _drinkPresentationModel.GetNewAdditionButtonState();
            _backAdditionListNewFromFileButton.Text = _drinkPresentationModel.GetNewAdditionFromFileState();
        }

        //點擊新增加料按鈕
        private void ClickNewAdditionButton(object sender, EventArgs e)
        {
            if (!_drinkPresentationModel.ClickNewAdditionButton(_backAdditionNameTextBox.Text, _backAdditionPriceTextBox.Text))
                MessageBox.Show("加料已存在");
            RefreshBackStageObject();
            RefreshAdditionDataGridView();
        }

        //tab3

        //點擊歷史記綠清單
        private void ClickHistoryTimeList(object sender, DataGridViewCellEventArgs e)
        {
            _listDataGridView.RowCount = 0;
            for (int i = 0; i < _drinkModel.GetOrdersList()[_historyDataGridView.CurrentCellAddress.Y].GetOrderCount(); i++)
                _listDataGridView.Rows.Add(_drinkModel.GetOrdersList()[_historyDataGridView.CurrentCellAddress.Y].GetOrderDrinkName(i),_drinkModel.GetOrdersList()[_historyDataGridView.CurrentCellAddress.Y].GetOrderDrinkPrice(i),_drinkModel.GetOrdersList()[_historyDataGridView.CurrentCellAddress.Y].GetOrderDrinkSugar(i),_drinkModel.GetOrdersList()[_historyDataGridView.CurrentCellAddress.Y].GetOrderDrinkTemperature(i),_drinkModel.GetOrdersList()[_historyDataGridView.CurrentCellAddress.Y].GetOrderDrinkAddition(i));
        }

        //換頁動作
        private void ChangeTabControlSelectedIndex(object sender, EventArgs e)
        {
            if (((TabControl)sender).SelectedIndex == 0)
                RefreshOrderDataGridView();
            else if (((TabControl)sender).SelectedIndex == 1)
                _drinkModel.ResetNowOrders();
            else if (((TabControl)sender).SelectedIndex == 2)
            {
                _historyDataGridView.RowCount = 0;
                for (int i = 0; i < _drinkModel.GetOrdersList().Count(); i++)
                    _historyDataGridView.Rows.Add(_drinkModel.GetOrdersList()[i].GetCheckOutTime(), _drinkModel.GetOrdersList()[i].GetTotalPrice());
                _listTotalPriceLabel.Text = TOTAL_PRICE + _drinkModel.GetTotalOrdersPrice() + DOLLAR;
            }
        }
    }
}
