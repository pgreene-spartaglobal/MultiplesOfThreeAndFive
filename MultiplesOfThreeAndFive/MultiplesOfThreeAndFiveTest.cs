using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MultiplesThreeAndFive;

namespace MultiplesOfThreeAndFive.Test
{
    [TestFixture]
    class MultiplesOfThreeAndFiveTest
    {
        MultiplesOfThreeAndFiveClass mtf = new MultiplesOfThreeAndFiveClass();

        [Test]
        public void TestMultiplesOfThreeAndFive()
        {
            Assert.AreEqual(23, mtf.SumMultiplesOfThreeAndFive(10));
        }
    }
}
