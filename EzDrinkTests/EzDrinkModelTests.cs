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
    public class EzDrinkModelTests
    {
        EzDrinkModel _ezDrinkModelTest = new EzDrinkModel();
        [TestMethod()]
        public void IsSetDrinkFromFileOKTest()
        {
            LoadFile _loadFile = new LoadFile();
            Assert.IsNotNull(_loadFile.TestGetLoadFilePath("./drinks.txt"));
            Assert.IsNull(_loadFile.TestGetLoadFilePath(""));
        }

        [TestMethod()]
        public void IsSetAdditionFromFileOKTest()
        {
            LoadFile _loadFile = new LoadFile();
            Assert.IsNotNull(_loadFile.TestGetLoadFilePath("./additions.txt"));
            Assert.IsNull(_loadFile.TestGetLoadFilePath(""));
        }

        [TestMethod()]
        public void AddDrinkTest()
        {
            Assert.AreEqual(0, _ezDrinkModelTest.GetDrinksList().Count());
            _ezDrinkModelTest.AddDrink(new Drink("紅茶", 25));
            Assert.AreEqual(1, _ezDrinkModelTest.GetDrinksList().Count());
        }

        [TestMethod()]
        public void AddAdditionTest()
        {
            Assert.AreEqual(0, _ezDrinkModelTest.GetDrinkAdditionsList().Count());
            _ezDrinkModelTest.AddAddition(new DrinkAddition("珍珠", 5));
            Assert.AreEqual(1, _ezDrinkModelTest.GetDrinkAdditionsList().Count());
        }

        [TestMethod()]
        public void SetDrinkTest()
        {
            _ezDrinkModelTest.GetDrinksList().Add(new Drink("紅茶", 25));
            Assert.AreEqual("紅茶", _ezDrinkModelTest.GetDrinksList()[0].GetDrinkName());
            _ezDrinkModelTest.SetDrink(0, "綠茶", 25);
            Assert.AreEqual("綠茶", _ezDrinkModelTest.GetDrinksList()[0].GetDrinkName());
        }

        [TestMethod()]
        public void SetAdditionTest()
        {
            _ezDrinkModelTest.GetDrinkAdditionsList().Add(new DrinkAddition("珍珠", 5));
            Assert.AreEqual("珍珠", _ezDrinkModelTest.GetDrinkAdditionsList()[0].GetAdditionName());
            _ezDrinkModelTest.SetAddition(0, "椰果", 10);
            Assert.AreEqual("椰果", _ezDrinkModelTest.GetDrinkAdditionsList()[0].GetAdditionName());
            Assert.AreEqual(10, _ezDrinkModelTest.GetDrinkAdditionsList()[0].GetAdditionPrice());
        }

        [TestMethod()]
        public void AddDrinkToOrdersTest()
        {
            Assert.AreEqual(0, _ezDrinkModelTest.GetNowOrders().GetOrderCount());
            _ezDrinkModelTest.AddDrinkToOrders("紅茶", 25);
            Assert.AreEqual(1, _ezDrinkModelTest.GetNowOrders().GetOrderCount());
        }

        [TestMethod()]
        public void AddAdditionToOrdersDrinkTest()
        {
            _ezDrinkModelTest.AddDrinkToOrders("紅茶", 25);
            Assert.AreEqual("", _ezDrinkModelTest.GetNowOrders().GetOrderDrinkAddition(0));
            _ezDrinkModelTest.AddAdditionToOrdersDrink(0, "珍珠", 5);
            Assert.AreEqual("珍珠", _ezDrinkModelTest.GetNowOrders().GetOrderDrinkAddition(0));
        }

        [TestMethod()]
        public void SetOrdersDrinkSugarTest()
        {
            _ezDrinkModelTest.AddDrinkToOrders("紅茶", 25);
            _ezDrinkModelTest.SetOrdersDrinkSugar(0, "正常");
            Assert.AreEqual("正常", _ezDrinkModelTest.GetNowOrders().GetOrderDrinkSugar(0));
        }

        [TestMethod()]
        public void SetOrdersDrinkTemperatureTest()
        {
            _ezDrinkModelTest.AddDrinkToOrders("紅茶", 25);
            _ezDrinkModelTest.SetOrdersDrinkTemperature(0, "去冰");
            Assert.AreEqual("去冰", _ezDrinkModelTest.GetNowOrders().GetOrderDrinkTemperature(0));
        }

        [TestMethod()]
        public void GetTotalPriceTest()
        {
            Assert.AreEqual(0, _ezDrinkModelTest.GetTotalPrice());
            _ezDrinkModelTest.AddDrinkToOrders("紅茶", 25);
            Assert.AreEqual(25, _ezDrinkModelTest.GetTotalPrice());
        }

        [TestMethod()]
        public void DeleteOrdersDrinkTest()
        {
            _ezDrinkModelTest.AddDrinkToOrders("紅茶", 25);
            Assert.AreEqual(1, _ezDrinkModelTest.GetNowOrders().GetOrderCount());
            _ezDrinkModelTest.DeleteOrdersDrink(0);
            Assert.AreEqual(0, _ezDrinkModelTest.GetNowOrders().GetOrderCount());
        }

        [TestMethod()]
        public void DeleteDrinkTest()
        {
            _ezDrinkModelTest.AddDrink(new Drink("紅茶", 25));
            Assert.AreEqual(1, _ezDrinkModelTest.GetDrinksList().Count());
            _ezDrinkModelTest.DeleteDrink(0);
            Assert.AreEqual(0, _ezDrinkModelTest.GetDrinksList().Count());
        }

        [TestMethod()]
        public void DeleteAdditionTest()
        {
            _ezDrinkModelTest.AddAddition(new DrinkAddition("珍珠", 5));
            Assert.AreEqual(1, _ezDrinkModelTest.GetDrinkAdditionsList().Count());
            _ezDrinkModelTest.DeleteAddition(0);
            Assert.AreEqual(0, _ezDrinkModelTest.GetDrinkAdditionsList().Count());
        }

        [TestMethod()]
        public void IsOrdersDrinkAdditionSelectTest()
        {
            _ezDrinkModelTest.AddDrinkToOrders("紅茶", 25);
            _ezDrinkModelTest.AddAdditionToOrdersDrink(0, "珍珠", 5);
            Assert.IsFalse(_ezDrinkModelTest.IsOrdersDrinkAdditionSelect(0, "椰果"));
            Assert.IsTrue(_ezDrinkModelTest.IsOrdersDrinkAdditionSelect(0, "珍珠"));
        }

        [TestMethod()]
        public void IsOrdersCompleteTest()
        {
            Assert.IsFalse(_ezDrinkModelTest.IsOrdersComplete());
            _ezDrinkModelTest.AddDrinkToOrders("紅茶", 25);
            _ezDrinkModelTest.SetOrdersDrinkSugar(0, "正常");
            _ezDrinkModelTest.SetOrdersDrinkTemperature(0, "正常");
            Assert.IsTrue(_ezDrinkModelTest.IsOrdersComplete());
        }

        [TestMethod()]
        public void IsDrinkHaveTest()
        {
            Assert.IsFalse(_ezDrinkModelTest.IsDrinkHave("紅茶"));
            _ezDrinkModelTest.AddDrink(new Drink("紅茶", 25));
            Assert.IsTrue(_ezDrinkModelTest.IsDrinkHave("紅茶"));
        }

        [TestMethod()]
        public void IsAdditionHaveTest()
        {
            Assert.IsFalse(_ezDrinkModelTest.IsAdditionHave("珍珠"));
            _ezDrinkModelTest.AddAddition(new DrinkAddition("珍珠", 5));
            Assert.IsTrue(_ezDrinkModelTest.IsAdditionHave("珍珠"));
        }

        [TestMethod()]
        public void CheckOutTest()
        {
            Assert.AreEqual(0, _ezDrinkModelTest.GetOrdersList().Count());
            _ezDrinkModelTest.CheckOut();
            Assert.AreEqual(1, _ezDrinkModelTest.GetOrdersList().Count());
        }

        [TestMethod()]
        public void GetDrinkAdditionsListTest()
        {
            List<DrinkAddition> _additions = new List<DrinkAddition>();
            _additions.Add(new DrinkAddition("珍珠", 5));
            _ezDrinkModelTest.AddAddition(new DrinkAddition("珍珠", 5));
            Assert.AreEqual(_additions[0].GetAdditionName(), _ezDrinkModelTest.GetDrinkAdditionsList()[0].GetAdditionName());
            Assert.AreEqual(_additions[0].GetAdditionPrice(), _ezDrinkModelTest.GetDrinkAdditionsList()[0].GetAdditionPrice());
            Assert.AreEqual(_additions.Count(), _ezDrinkModelTest.GetDrinkAdditionsList().Count());
        }

        [TestMethod()]
        public void GetDrinksListTest()
        {
            List<Drink> _drinks = new List<Drink>();
            _drinks.Add(new Drink("紅茶", 25));
            _ezDrinkModelTest.AddDrink(new Drink("紅茶", 25));
            Assert.AreEqual(_drinks[0].GetDrinkName(), _ezDrinkModelTest.GetDrinksList()[0].GetDrinkName());
            Assert.AreEqual(_drinks[0].GetDrinkPrice(), _ezDrinkModelTest.GetDrinksList()[0].GetDrinkPrice());
            Assert.AreEqual(_drinks.Count(), _ezDrinkModelTest.GetDrinksList().Count());
        }

        [TestMethod()]
        public void GetNowOrdersTest()
        {
            Orders _orders = new Orders();
            _orders.AddOrderDrink("紅茶", 25);
            _ezDrinkModelTest.AddDrinkToOrders("紅茶", 25);
            Assert.AreEqual(_orders.GetOrderDrinkName(0), _ezDrinkModelTest.GetNowOrders().GetOrderDrinkName(0));
            Assert.AreEqual(_orders.GetOrderDrinkPrice(0), _ezDrinkModelTest.GetNowOrders().GetOrderDrinkPrice(0));
            Assert.AreEqual(_orders.GetOrderCount(), _ezDrinkModelTest.GetNowOrders().GetOrderCount());
        }

        [TestMethod()]
        public void GetOrdersListTest()
        {
            List<Orders> _orders = new List<Orders>();
            Orders _order = new Orders();
            _order.AddOrderDrink("紅茶", 25);
            _orders.Add(_order);
            _ezDrinkModelTest.AddDrinkToOrders("紅茶", 25);
            _ezDrinkModelTest.CheckOut();
            Assert.AreEqual(_orders[0].GetOrderDrinkName(0), _ezDrinkModelTest.GetOrdersList()[0].GetOrderDrinkName(0));
            Assert.AreEqual(_orders[0].GetOrderDrinkPrice(0), _ezDrinkModelTest.GetOrdersList()[0].GetOrderDrinkPrice(0));
            Assert.AreEqual(_orders.Count(), _ezDrinkModelTest.GetOrdersList().Count());
        }

        [TestMethod()]
        public void GetTotalOrdersPriceTest()
        {
            _ezDrinkModelTest.AddDrinkToOrders("紅茶", 25);
            _ezDrinkModelTest.CheckOut();
            _ezDrinkModelTest.AddDrinkToOrders("綠茶", 25);
            _ezDrinkModelTest.CheckOut();
            Assert.AreEqual(2, _ezDrinkModelTest.GetOrdersList().Count());
            Assert.AreEqual(50, _ezDrinkModelTest.GetTotalOrdersPrice());
        }

        [TestMethod()]
        public void ResetNowOrdersTest()
        {
            _ezDrinkModelTest.AddDrinkToOrders("紅茶", 25);
            Assert.AreEqual(1, _ezDrinkModelTest.GetNowOrders().GetOrderCount());
            _ezDrinkModelTest.ResetNowOrders();
            Assert.AreEqual(0, _ezDrinkModelTest.GetNowOrders().GetOrderCount());
        }
    }
}