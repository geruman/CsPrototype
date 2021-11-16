using Microsoft.VisualStudio.TestTools.UnitTesting;
using CsPrototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsPrototype.Tests
{
    [TestClass()]
    public class SheepTests
    {
        [TestMethod()]
        public void CloneTest()
        {
            Sheep sheep = new Sheep("Dolly","Purple");
            Assert.AreEqual("Dolly", sheep.Name);
            Sheep clone = sheep.Clone();
            Assert.AreEqual("Dolly Clone", clone.Name);
        }
    }
}