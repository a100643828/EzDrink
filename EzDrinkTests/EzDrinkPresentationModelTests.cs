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
    public class EzDrinkPresentationModelTests
    {
        EzDrinkPresentationModel _ezPModel;
        EzDrinkModel _ezmodel;
        [TestInitialize()]
        public void Initialize()
        {
            _ezmodel = new EzDrinkModel();
            _ezmodel.AddDrink(new Drink("紅茶", 25));
            _ezmodel.AddAddition(new DrinkAddition("珍珠", 5));
            _ezmodel.AddDrinkToOrders("紅茶", 25);
            _ezmodel.AddAdditionToOrdersDrink(0, "珍珠", 5);
            _ezmodel.SetOrdersDrinkSugar(0, "半糖");
            _ezmodel.SetOrdersDrinkTemperature(0, "去冰");
            _ezPModel = new EzDrinkPresentationModel(_ezmodel);
        }
        [TestMethod()]
        public void EzDrinkPresentationModelTest()
        {
            
        }

        [TestMethod()]
        public void IsAdditionButtonAbleTest()
        {
            Assert.IsFalse(_ezPModel.IsAdditionButtonAble(0, "珍珠"));
            Assert.IsTrue(_ezPModel.IsAdditionButtonAble(0, "椰果"));
        }

        [TestMethod()]
        public void ClickNewDrinkButtonTest()
        {
            _ezPModel.ClickNewDrinkButton("", "");
            Assert.IsFalse(_ezPModel.ClickNewDrinkButton("紅茶", "25"));
            Assert.IsTrue(_ezPModel.ClickNewDrinkButton("綠茶", "25"));
        }

        [TestMethod()]
        public void GetNewDrinkButtonStateTest()
        {
            Assert.AreEqual("新增", _ezPModel.GetNewDrinkButtonState());
            _ezPModel.ClickNewDrinkButton("", "");
            Assert.AreEqual("確定", _ezPModel.GetNewDrinkButtonState());
        }

        [TestMethod()]
        public void GetNewDrinkFromFileStateTest()
        {
            Assert.AreEqual("從檔案匯入", _ezPModel.GetNewDrinkFromFileState());
            _ezPModel.ClickNewDrinkButton("", "");
            Assert.AreEqual("取消", _ezPModel.GetNewDrinkFromFileState());
        }

        [TestMethod()]
        public void GetNewDrinkNamePriceStateTest()
        {
            Assert.IsFalse(_ezPModel.GetNewDrinkNamePriceState());
            _ezPModel.ClickNewDrinkButton("", "");
            Assert.IsTrue(_ezPModel.GetNewDrinkNamePriceState());
        }

        [TestMethod()]
        public void ClickNewDrinkFormFileEventTest()
        {
            
        }

        [TestMethod()]
        public void ClickNewAdditionButtonTest()
        {
            _ezPModel.ClickNewAdditionButton("", "");
            Assert.IsFalse(_ezPModel.ClickNewAdditionButton("珍珠", "5"));
            Assert.IsTrue(_ezPModel.ClickNewAdditionButton("椰果", "5"));
        }

        [TestMethod()]
        public void GetNewAdditionButtonStateTest()
        {
            Assert.AreEqual("新增", _ezPModel.GetNewAdditionButtonState());
            _ezPModel.ClickNewAdditionButton("", "");
            Assert.AreEqual("確定", _ezPModel.GetNewAdditionButtonState());
        }

        [TestMethod()]
        public void GetNewAdditionFromFileStateTest()
        {
            Assert.AreEqual("從檔案匯入", _ezPModel.GetNewAdditionFromFileState());
            _ezPModel.ClickNewAdditionButton("", "");
            Assert.AreEqual("取消", _ezPModel.GetNewAdditionFromFileState());
        }

        [TestMethod()]
        public void GetNewAdditionNamePriceStateTest()
        {
            Assert.IsFalse(_ezPModel.GetNewAdditionNamePriceState());
            _ezPModel.ClickNewAdditionButton("", "");
            Assert.IsTrue(_ezPModel.GetNewAdditionNamePriceState());
        }

        [TestMethod()]
        public void ClickNewAdditionFormFileEventTest()
        {
            
        }
    }
}