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
    public class OrdersTests
    {
        Orders _orderstest = new Orders();
        [TestInitialize()]
        public void Initialize()
        {
            _orderstest.AddOrderDrink("綠茶", 25);
        }
        [TestMethod()]

        public void AddOrderDrinkTest()
        {
            Assert.IsTrue(_orderstest.GetOrderCount() == 1);
            _orderstest.AddOrderDrink("紅茶", 25);
            Assert.IsTrue(_orderstest.GetOrderCount() == 2);
        }

        [TestMethod()]
        public void SetOrderDrinkSugarTest()
        {
            _orderstest.SetOrderDrinkSugar(0, Sugar.NormalSugar);
            Assert.AreEqual("正常", _orderstest.GetOrderDrinkSugar(0));
        }

        [TestMethod()]
        public void SetOrderDrinkTemperatureTest()
        {
            _orderstest.SetOrderDrinkTemperature(0, Temperature.LessIce);
            Assert.AreEqual("少冰", _orderstest.GetOrderDrinkTemperature(0));
        }

        [TestMethod()]
        public void AddOrderDrinkAdditionTest()
        {
            _orderstest.AddOrderDrinkAddition(0, "珍珠", 5);
            Assert.AreEqual("珍珠", _orderstest.GetOrderDrinkAddition(0));
        }

        [TestMethod()]
        public void GetOrderDrinkNameTest()
        {
            Assert.AreEqual("綠茶", _orderstest.GetOrderDrinkName(0));
        }

        [TestMethod()]
        public void GetOrderDrinkPriceTest()
        {
            Assert.AreEqual(25, _orderstest.GetOrderDrinkPrice(0));
        }

        [TestMethod()]
        public void GetOrderDrinkAdditionTest()
        {
            _orderstest.AddOrderDrinkAddition(0, "布丁", 10);
            Assert.AreEqual("布丁", _orderstest.GetOrderDrinkAddition(0));
        }

        [TestMethod()]
        public void GetOrderDrinkSugarTest()
        {
            _orderstest.SetOrderDrinkSugar(0, Sugar.HalfSugar);
            Assert.AreEqual("半糖", _orderstest.GetOrderDrinkSugar(0));
        }

        [TestMethod()]
        public void GetOrderDrinkTemperatureTest()
        {
            _orderstest.SetOrderDrinkTemperature(0, Temperature.NoIce);
            Assert.AreEqual("去冰", _orderstest.GetOrderDrinkTemperature(0));
        }

        [TestMethod()]
        public void IsOrderDrinkAdditionSelectTest()
        {
            Assert.IsFalse(_orderstest.IsOrderDrinkAdditionSelect(0, "珍珠"));
            _orderstest.AddOrderDrinkAddition(0, "珍珠", 5);
            Assert.IsTrue(_orderstest.IsOrderDrinkAdditionSelect(0, "珍珠"));
        }

        [TestMethod()]
        public void IsOrderDrinkSugarTemperatureSetTest()
        {
            Assert.IsFalse(_orderstest.IsOrderDrinkSugarTemperatureSet(0));
            _orderstest.SetOrderDrinkSugar(0, Sugar.HalfSugar);
            _orderstest.SetOrderDrinkTemperature(0, Temperature.Hot);
            Assert.IsTrue(_orderstest.IsOrderDrinkSugarTemperatureSet(0));
        }

        [TestMethod()]
        public void GetOrderCountTest()
        {
            Assert.AreEqual(1, _orderstest.GetOrderCount());
        }

        [TestMethod()]
        public void RemoveOrderDrinkTest()
        {
            Assert.AreEqual(1, _orderstest.GetOrderCount());
            _orderstest.RemoveOrderDrink(0);
            Assert.AreEqual(0, _orderstest.GetOrderCount());
        }

        [TestMethod()]
        public void SetCheckOutTimeTest()
        {
            DateTime nowtime = DateTime.Now;
            string nowtimeString = nowtime.ToString();
            _orderstest.SetCheckOutTime(nowtime);
            Assert.AreEqual(nowtimeString, _orderstest.GetCheckOutTime());
        }

        [TestMethod()]
        public void GetTotalPriceTest()
        {
            _orderstest.AddOrderDrink("紅茶", 25);
            _orderstest.AddOrderDrink("阿薩姆奶茶", 35);
            Assert.AreEqual(85, _orderstest.GetTotalPrice());
        }
    }
}