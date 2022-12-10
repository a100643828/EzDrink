using Microsoft.VisualStudio.TestTools.UnitTesting;
using EzDrink;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzDrink.Tests
{
    [TestClass()]
    public class DrinkTests
    {
        Drink _drinktest=new Drink("紅茶", 25);
        [TestMethod()]
        public void DrinkTest()
        {
            _drinktest = new Drink("綠茶", 45);
            Assert.AreEqual("綠茶", _drinktest.GetDrinkName());
            Assert.AreEqual(45, _drinktest.GetDrinkPrice());
        }

        [TestMethod()]
        public void GetDrinkNameTest()
        {
            Assert.AreEqual("紅茶", _drinktest.GetDrinkName());
        }

        [TestMethod()]
        public void GetDrinkPriceTest()
        {
            Assert.AreEqual(25, _drinktest.GetDrinkPrice());
        }

        [TestMethod()]
        public void AddToDrinkPriceTest()
        {
            _drinktest.AddToDrinkPrice(10);
            Assert.AreEqual(35, _drinktest.GetDrinkPrice());
        }
    }
}