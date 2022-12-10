using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzDrink
{
    public class Drink
    {
        string _name;
        int _price = 0;

        //新增飲料
        public Drink(string name, int price)
        {
            _name = name;
            _price = price;
        }

        //取得飲料名稱
        public string GetDrinkName()
        {
            return _name;
        }

        //取得飲料價格
        public int GetDrinkPrice()
        {
            return _price;
        }

        //設定飲料價格
        public void AddToDrinkPrice(int price)
        {
            _price += price;
        }

    }
}
