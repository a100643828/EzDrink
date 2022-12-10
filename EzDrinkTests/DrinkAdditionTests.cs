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
    public class DrinkAdditionTests
    {
        DrinkAddition _drinkAdditiontest = new DrinkAddition("香蕉", 15);
        [TestMethod()]
        public void DrinkAdditionTest()
        {
            _drinkAdditiontest = new DrinkAddition("布丁", 10);
            Assert.AreEqual("布丁", _drinkAdditiontest.GetAdditionName());
            Assert.AreEqual(10, _drinkAdditiontest.GetAdditionPrice());
        }

        [TestMethod()]
        public void GetAdditionNameTest()
        {
            Assert.AreEqual("香蕉", _drinkAdditiontest.GetAdditionName());
        }

        [TestMethod()]
        public void GetAdditionPriceTest()
        {
            Assert.AreEqual(15, _drinkAdditiontest.GetAdditionPrice());
        }
    }
}