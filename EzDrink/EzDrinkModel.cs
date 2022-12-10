using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EzDrink
{
    public class EzDrinkModel
    {
        const string EXTENSION = ".txt";
        List<Drink> _drinks = new List<Drink>();
        List<Orders> _orders = new List<Orders>();
        List<DrinkAddition> _drinkAdditions = new List<DrinkAddition>();
        Orders _nowOrders = new Orders();
        LoadFile _loadFile = new LoadFile();
        const string NORMAL_ICE = "正常";
        const string LESS_ICE = "少冰";
        const string NO_ICE = "去冰";
        const string HOT = "溫熱";
        const string NORMAL_SUGAR = "正常";
        const string HALF_SUGAR = "半糖";
        const string LESS_SUGAR = "微糖";
        const string NO_SUGAR = "無糖";

        //從檔案加入飲料
        public bool IsSetDrinkFromFileOK()
        {
            if (_loadFile.GetLoadFilePath(EXTENSION) != null)
            {
                Drink _drink = _loadFile.GetDrinkAndPrice();
                while (_drink != null)
                {
                    _drinks.Add(_drink);
                    _drink = _loadFile.GetDrinkAndPrice();
                }
                return true;
            }
            else
                return false;//開檔失敗
        }

        //從檔案加入加料
        public bool IsSetAdditionFromFileOK()
        {
            if (_loadFile.GetLoadFilePath(EXTENSION) != null)
            {
                DrinkAddition _drinkAddition = _loadFile.GetAdditionAndPrice();
                while (_drinkAddition != null)
                {
                    _drinkAdditions.Add(_drinkAddition);
                    _drinkAddition = _loadFile.GetAdditionAndPrice();
                }
                return true;
            }
            else
                return false;//開檔失敗
        }

        //增加飲料
        public void AddDrink(Drink drink)
        {
            _drinks.Add(drink);
        }

        //新增加料
        public void AddAddition(DrinkAddition drinkAddition)
        {
            _drinkAdditions.Add(drinkAddition);
        }

        //設置飲料
        public void SetDrink(int drinkNumber, string drinkName, int drinkPrice)
        {
            _drinks[drinkNumber] = new Drink(drinkName, drinkPrice);
        }

        //設置加料
        public void SetAddition(int additionNumber, string additionName, int additionPrice)
        {
            _drinkAdditions[additionNumber] = new DrinkAddition(additionName, additionPrice);
        }

        //增加飲料到點單
        public void AddDrinkToOrders(string drinkName, int drinkPrice)
        {
            _nowOrders.AddOrderDrink(drinkName, drinkPrice);
        }

        //增加加料到飲料
        public void AddAdditionToOrdersDrink(int drinkNumber, string additionName, int additionPrice)
        {
            _nowOrders.AddOrderDrinkAddition(drinkNumber, additionName, additionPrice);
        }

        //設定點單飲料甜度
        public void SetOrdersDrinkSugar(int drinkNumber, string sugarString)
        {
            switch (sugarString)
            {
                case NORMAL_SUGAR:
                    _nowOrders.SetOrderDrinkSugar(drinkNumber, Sugar.NormalSugar);
                    break;
                case LESS_SUGAR:
                    _nowOrders.SetOrderDrinkSugar(drinkNumber, Sugar.LessSugar);
                    break;
                case HALF_SUGAR:
                    _nowOrders.SetOrderDrinkSugar(drinkNumber, Sugar.HalfSugar);
                    break;
                case NO_SUGAR:
                    _nowOrders.SetOrderDrinkSugar(drinkNumber, Sugar.NoSugar);
                    break;
            }
        }

        //設定點單飲料溫度
        public void SetOrdersDrinkTemperature(int drinkNumber, string temperatureString)
        {
            switch (temperatureString)
            {
                case NORMAL_ICE:
                    _nowOrders.SetOrderDrinkTemperature(drinkNumber, Temperature.NormalIce);
                    break;
                case LESS_ICE:
                    _nowOrders.SetOrderDrinkTemperature(drinkNumber, Temperature.LessIce);
                    break;
                case NO_ICE:
                    _nowOrders.SetOrderDrinkTemperature(drinkNumber, Temperature.NoIce);
                    break;
                case HOT:
                    _nowOrders.SetOrderDrinkTemperature(drinkNumber, Temperature.Hot);
                    break;
            }
        }

        //取得總價
        public int GetTotalPrice()
        {
            int totalPrice = 0;
            for (int i = 0; i < _nowOrders.GetOrderCount(); i++)
                totalPrice += _nowOrders.GetOrderDrinkPrice(i);
            return totalPrice;
        }

        //刪除點單中飲料
        public void DeleteOrdersDrink(int drinkNumber)
        {
            _nowOrders.RemoveOrderDrink(drinkNumber);
        }

        //刪除飲料
        public void DeleteDrink(int drinkNumber)
        {
            _drinks.RemoveAt(drinkNumber);
        }

        //刪除加料
        public void DeleteAddition(int additionNumber)
        {
            _drinkAdditions.RemoveAt(additionNumber);
        }

        //判斷加料是否以點選
        public bool IsOrdersDrinkAdditionSelect(int drinkNumber, string additionName)
        {
            return _nowOrders.IsOrderDrinkAdditionSelect(drinkNumber, additionName);
        }

        //判斷是否可以結帳
        public bool IsOrdersComplete()
        {
            if (_nowOrders.GetOrderCount() == 0)
                return false;
            for (int i = 0; i < _nowOrders.GetOrderCount(); i++)
            {
                if (!(_nowOrders.IsOrderDrinkSugarTemperatureSet(i)))
                    return false;
            }
            return true;
        }

        //飲料是否已存在
        public bool IsDrinkHave(string drinkName)
        {
            for (int i = 0; i < _drinks.Count(); i++)
            {
                if (_drinks[i].GetDrinkName() == drinkName)
                    return true;
            }
            return false;
        }

        //加料是否已存在
        public bool IsAdditionHave(string additionName)
        {
            for (int i = 0; i < _drinkAdditions.Count(); i++)
            {
                if (_drinkAdditions[i].GetAdditionName() == additionName)
                    return true;
            }
            return false;
        }

        //全部orders的總價格
        public int GetTotalOrdersPrice()
        {
            int total = 0;
            for (int i = 0; i < _orders.Count(); i++)
                total += _orders[i].GetTotalPrice();
            return total;
        }

        //重設nowOrders
        public void ResetNowOrders()
        {
            _nowOrders = new Orders();
        }

        //結帳
        public void CheckOut()
        {
            _nowOrders.SetCheckOutTime(DateTime.Now);
            _orders.Add(_nowOrders);
            _nowOrders = new Orders();
        }

        //取得drink的addition清單
        public List<DrinkAddition> GetDrinkAdditionsList()
        {
            return _drinkAdditions;
        }

        //取得drink的drink清單
        public List<Drink> GetDrinksList()
        {
            return _drinks;
        }

        //取得drink的orders清單
        public List<Orders> GetOrdersList()
        {
            return _orders;
        }

        //取得drink的nowOrder
        public Orders GetNowOrders()
        {
            return _nowOrders;
        }
    }
}
