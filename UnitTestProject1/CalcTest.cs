using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Modulzaro.Test
{
    [TestClass]
    public class CalcTest
    {
        [TestMethod]
        public void NoLangauages()
        {
            var sum = Calc.NumberOfLanguages(new Language[0]);
            Assert.AreEqual(0, sum);
        }
    }
}
