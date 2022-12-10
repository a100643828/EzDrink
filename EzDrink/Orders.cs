using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzDrink
{
    public class Orders
    {
        List<Order> _order = new List<Order>();
        DateTime _orderTime = new DateTime();
        const string NORMAL_ICE = "正常";
        const string LESS_ICE = "少冰";
        const string NO_ICE = "去冰";
        const string HOT = "溫熱";
        const string NORMAL_SUGAR = "正常";
        const string HALF_SUGAR = "半糖";
        const string LESS_SUGAR = "微糖";
        const string NO_SUGAR = "無糖";

        //設定點單飲料
        public void AddOrderDrink(string name, int price)
        {
            _order.Add(new Order(name, price));
        }

        //設定甜度
        public void SetOrderDrinkSugar(int orderDrinkNumber, Sugar sugar)
        {
            _order[orderDrinkNumber].SetOrderDrinkSugar(sugar);
        }

        //設定溫度
        public void SetOrderDrinkTemperature(int orderDrinkNumber, Temperature temperature)
        {
            _order[orderDrinkNumber].SetOrderDrinkTemperature(temperature);
        }

        //設定加料
        public void AddOrderDrinkAddition(int orderDrinkNumber, string name, int price)
        {
            DrinkAddition drinkAddition = new DrinkAddition(name, price);
            _order[orderDrinkNumber].AddOrderDrinkAddition(drinkAddition);
        }

        //取得飲料名稱
        public string GetOrderDrinkName(int orderDrinkNumber)
        {
            return _order[orderDrinkNumber].GetDrinkName();
        }

        //取得飲料價錢
        public int GetOrderDrinkPrice(int orderDrinkNumber)
        {
            return _order[orderDrinkNumber].GetDrinkPrice();
        }

        //取得點單飲料加料
        public string GetOrderDrinkAddition(int orderDrinkNumber)
        {
            return _order[orderDrinkNumber].GetDrinkAddition();
        }

        //取得點單飲料甜度
        public string GetOrderDrinkSugar(int orderDrinkNumber)
        {
            switch (_order[orderDrinkNumber].GetDrinkSugar())
            {
                case Sugar.NormalSugar:
                    return NORMAL_SUGAR;
                case Sugar.HalfSugar:
                    return HALF_SUGAR;
                case Sugar.LessSugar:
                    return LESS_SUGAR;
                case Sugar.NoSugar:
                    return NO_SUGAR;
                default:
                    return "";
            }
        }

        //取得點單飲料溫度
        public string GetOrderDrinkTemperature(int orderDrinkNumber)
        {
            switch (_order[orderDrinkNumber].GetDrinkTemperature())
            {
                case Temperature.NormalIce:
                    return NORMAL_ICE;
                case Temperature.LessIce:
                    return LESS_ICE;
                case Temperature.NoIce:
                    return NO_ICE;
                case Temperature.Hot:
                    return HOT;
                default:
                    return "";
            }
        }

        //判斷加料是否以選擇
        public bool IsOrderDrinkAdditionSelect(int orderDrinkNumber, string additionName)
        {
            return _order[orderDrinkNumber].IsAdditionSelect(additionName);
        }

        //判斷甜度溫度是否已設定
        public bool IsOrderDrinkSugarTemperatureSet(int orderDrinkNumber)
        {
            return _order[orderDrinkNumber].IsSugarTemperatureSet();
        }

        //取得點單飲料數量
        public int GetOrderCount()
        {
            return _order.Count();
        }

        //刪除點單飲料
        public void RemoveOrderDrink(int drinkNumber)
        {
            _order.RemoveAt(drinkNumber);
        }

        //設定結帳時間
        public void SetCheckOutTime(DateTime checkOutTime)
        {
            _orderTime = checkOutTime;
        }

        //取得結帳時間
        public String GetCheckOutTime()
        {
            return _orderTime.ToString();
        }

        //取得總價格
        public int GetTotalPrice()
        {
            int totalPrice = 0;
            for (int i = 0; i < _order.Count(); i++)
                totalPrice += _order[i].GetDrinkPrice();
            return totalPrice;
        }
    }
}
