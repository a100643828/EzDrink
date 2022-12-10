using Microsoft.VisualStudio.TestTools.UnitTesting;
using EzDrink;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EzDrink.Tests
{
    [TestClass()]
    public class OrderTests
    {
        Order _ordertest;
        [TestInitialize()]
        public void Initialize()
        {
            _ordertest = new Order("奶茶", 30);
            _ordertest.SetOrderDrinkTemperature(Temperature.Hot);
            _ordertest.SetOrderDrinkSugar(Sugar.NoSugar);
            _ordertest.AddOrderDrinkAddition(new DrinkAddition("珍珠", 5));
        }
        [TestMethod()]
        public void OrderTest()
        {
            _ordertest = new Order("紅茶", 25);
            Assert.AreEqual("紅茶", _ordertest.GetDrinkName());
            Assert.AreEqual(25, _ordertest.GetDrinkPrice());
        }

        [TestMethod()]
        public void SetOrderDrinkSugarTest()
        {
            Sugar sugar = Sugar.NoSugar;
            _ordertest.SetOrderDrinkSugar(sugar);
            Assert.AreEqual(Sugar.NoSugar, _ordertest.GetDrinkSugar());
        }

        [TestMethod()]
        public void SetOrderDrinkTemperatureTest()
        {
            Temperature temperature = Temperature.Hot;
            _ordertest.SetOrderDrinkTemperature(temperature);
            Assert.AreEqual(Temperature.Hot, _ordertest.GetDrinkTemperature());
        }

        [TestMethod()]
        public void AddOrderDrinkAdditionTest()
        {
            DrinkAddition drinkaddition = new DrinkAddition("椰果", 5);
            _ordertest.AddOrderDrinkAddition(drinkaddition);
            Assert.IsTrue(_ordertest.IsAdditionSelect("椰果"));
            Assert.AreEqual("珍珠、椰果", _ordertest.GetDrinkAddition());
        }

        [TestMethod()]
        public void GetDrinkNameTest()
        {
            Assert.AreEqual("奶茶", _ordertest.GetDrinkName());
        }

        [TestMethod()]
        public void GetDrinkPriceTest()
        {
            Assert.AreEqual(35, _ordertest.GetDrinkPrice());
        }

        [TestMethod()]
        public void GetDrinkAdditionTest()
        {
            Assert.AreEqual("珍珠", _ordertest.GetDrinkAddition());
        }

        [TestMethod()]
        public void GetDrinkSugarTest()
        {
            Assert.AreEqual(Sugar.NoSugar, _ordertest.GetDrinkSugar());
        }

        [TestMethod()]
        public void GetDrinkTemperatureTest()
        {
            Assert.AreEqual(Temperature.Hot, _ordertest.GetDrinkTemperature());
        }

        [TestMethod()]
        public void IsAdditionSelectTest()
        {
            Assert.IsFalse(_ordertest.IsAdditionSelect("布丁"));
            Assert.IsTrue(_ordertest.IsAdditionSelect("珍珠"));
        }

        [TestMethod()]
        public void IsSugarTemperatureSetTest()
        {
            Assert.IsTrue(_ordertest.IsSugarTemperatureSet());
        }
    }
}