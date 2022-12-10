using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzDrink
{
    public class Order
    {
        Drink _drink;
        Sugar _sugar;
        Temperature _temperature;
        List<DrinkAddition> _drinkAddition = new List<DrinkAddition>();

        //設定點單飲料
        public Order(string name, int price)
        {
            _drink = new Drink(name, price);
        }

        //設定甜度
        public void SetOrderDrinkSugar(Sugar sugar)
        {
            _sugar = sugar;
        }

        //設定溫度
        public void SetOrderDrinkTemperature(Temperature temperature)
        {
            _temperature = temperature;
        }

        //設定加料
        public void AddOrderDrinkAddition(DrinkAddition drinkAddition)
        {
            _drinkAddition.Add(drinkAddition);
            _drink.AddToDrinkPrice(drinkAddition.GetAdditionPrice());
        }

        //取得飲料名稱
        public string GetDrinkName()
        {
            return _drink.GetDrinkName();
        }

        //取得飲料價錢
        public int GetDrinkPrice()
        {
            return _drink.GetDrinkPrice();
        }

        //取得點單飲料加料
        public string GetDrinkAddition()
        {
            const string DOT = "、";
            string addition = "";
            for (int i = 0; i < _drinkAddition.Count(); i++)
            {
                if (i != _drinkAddition.Count() - 1)
                    addition = addition + _drinkAddition[i].GetAdditionName() + DOT;
                else
                    addition = addition + _drinkAddition[i].GetAdditionName();
            }
            return addition;
        }

        //取得點單飲料甜度
        public Sugar GetDrinkSugar()
        {
            return _sugar;
        }

        //取得點單飲料溫度
        public Temperature GetDrinkTemperature()
        {
            return _temperature;
        }

        //判斷加料是否以選擇
        public bool IsAdditionSelect(string additionName)
        {
            for (int i = 0; i < _drinkAddition.Count(); i++)
            {
                if (_drinkAddition[i].GetAdditionName() == additionName)
                    return true;
            }
            return false;
        }

        //判斷甜度溫度是否已設定
        public bool IsSugarTemperatureSet()
        {
            if (_sugar == Sugar.Default || _temperature == Temperature.Default)
                return false;
            else
                return true;
        }
    }
}
