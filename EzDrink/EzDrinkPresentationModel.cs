using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzDrink
{
    public class EzDrinkPresentationModel
    {
        EzDrinkModel _drinkModel;
        bool _newDrinkButtonState = true;
        bool _newDrinkFromFileButtonState = true;
        bool _newDrinkNamePriceState = false;
        bool _newAdditionButtonState = true;
        bool _newAdditionFromFileButtonState = true;
        bool _newAdditionNamePriceState = false;
        const string CONFIRM = "確定";
        const string NEW = "新增";
        const string FROM_FILE = "從檔案匯入";
        const string CANCEL = "取消";
        //預設EzDrinkPresentationModel
        public EzDrinkPresentationModel(EzDrinkModel model)
        {
            _drinkModel = model;
        }

        //處理加料按鈕
        public bool IsAdditionButtonAble(int orderDrinkNumber, string additionName)
        {
            return !(_drinkModel.IsOrdersDrinkAdditionSelect(orderDrinkNumber, additionName));//確認隱料甜度冰塊
        }

        //點擊後台新增飲料按鈕
        public bool ClickNewDrinkButton(string drinkName, string drinkPrice)
        {
            if (_newDrinkButtonState)
                ChangeNewDrinkButtonEvents(false);
            else
            {
                if (drinkName != null && drinkPrice != null)
                {
                    if (_drinkModel.IsDrinkHave(drinkName))
                        return false;
                    Drink _drink = new Drink(drinkName, Convert.ToInt32(drinkPrice));
                    _drinkModel.AddDrink(_drink);
                    ChangeNewDrinkButtonEvents(true);
                }
            }
            return true;
        }

        //新增飲料按鈕的狀態控制
        public string GetNewDrinkButtonState()
        {
            if (_newDrinkButtonState)
                return NEW;
            else
                return CONFIRM;
        }

        //取得從檔案新增飲料狀態
        public string GetNewDrinkFromFileState()
        {
            if (_newDrinkFromFileButtonState)
                return FROM_FILE;
            else
                return CANCEL;
        }

        //取得飲料名稱價格TEXTBOX的狀態
        public bool GetNewDrinkNamePriceState()
        {
            return _newDrinkNamePriceState;
        }

        //從檔案新增飲料事件
        public bool ClickNewDrinkFormFileEvent()
        {
            if (_newDrinkFromFileButtonState)
            {
                if (!_drinkModel.IsSetDrinkFromFileOK())
                    return false;
            }
            else
                ChangeNewDrinkButtonEvents(true);
            return true;
        }

        //處理新增飲料相關物件的狀態
        private void ChangeNewDrinkButtonEvents(bool able)
        {
            _newDrinkButtonState = able;
            _newDrinkFromFileButtonState = able;
            _newDrinkNamePriceState = !able;
        }

        //點擊後台新增加料按鈕
        public bool ClickNewAdditionButton(string additionName, string additionPrice)
        {
            if (_newAdditionButtonState)
                ChangeNewAdditionButtonEvents(false);
            else
            {
                if (additionName != null && additionPrice != null)
                {
                    if (_drinkModel.IsAdditionHave(additionName))
                        return false;
                    DrinkAddition _drinkAddition = new DrinkAddition(additionName, Convert.ToInt32(additionPrice));
                    _drinkModel.AddAddition(_drinkAddition);
                    ChangeNewAdditionButtonEvents(true);
                }
            }
            return true;
        }

        //新增加料按鈕的狀態控制
        public string GetNewAdditionButtonState()
        {
            if (_newAdditionButtonState)
                return NEW;
            else
                return CONFIRM;
        }

        //取得從檔案新增加料狀態
        public string GetNewAdditionFromFileState()
        {
            if (_newAdditionFromFileButtonState)
                return FROM_FILE;
            else
                return CANCEL;
        }

        //取得加料名稱價格TEXTBOX的狀態
        public bool GetNewAdditionNamePriceState()
        {
            return _newAdditionNamePriceState;
        }

        //從檔案新增加料事件
        public bool ClickNewAdditionFormFileEvent()
        {
            if (_newAdditionFromFileButtonState)
            {
                if (!_drinkModel.IsSetAdditionFromFileOK())
                    return false;
            }
            else
            {
                ChangeNewAdditionButtonEvents(true);
            }
            return true;
        }

        //處理新增加料相關物見狀態
        private void ChangeNewAdditionButtonEvents(bool able)
        {
            _newAdditionButtonState = able;
            _newAdditionFromFileButtonState = able;
            _newAdditionNamePriceState = !able;
        }
    }
}
