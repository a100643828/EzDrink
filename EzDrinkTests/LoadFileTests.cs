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
    public class LoadFileTests
    {
        LoadFile _loadFile = new LoadFile();
        [TestMethod()]
        public void GetLoadFilePathTest()
        {
            Assert.IsNotNull(_loadFile.TestGetLoadFilePath("./text.txt"));
            Assert.IsNull(_loadFile.TestGetLoadFilePath(""));
        }

        [TestMethod()]
        public void GetDrinkAndPriceTest()
        {
            Assert.IsNotNull(_loadFile.TestGetLoadFilePath("./drinks.txt"));
            Assert.IsNull(_loadFile.TestGetLoadFilePath(""));
        }

        [TestMethod()]
        public void GetAdditionAndPriceTest()
        {
            Assert.IsNotNull(_loadFile.TestGetLoadFilePath("./additions.txt"));
            Assert.IsNull(_loadFile.TestGetLoadFilePath(""));
        }

        [TestMethod()]
        public void TestGetLoadFilePathTest()
        {
            Assert.IsNotNull(_loadFile.TestGetLoadFilePath("./text.txt"));
            Assert.IsNull(_loadFile.TestGetLoadFilePath(""));
        }
    }
}