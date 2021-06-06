using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVCProject1.Controllers;
using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace MVCProject1Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_the_expected_value()
        {
            //arrange
            ProductsController c = new ProductsController();
           
            // act
              var outcome  = c.calculateDiscount(5000, 10);
            int expected = 4500;
            //assert 

            Assert.AreEqual(expected , outcome);

        }




        [TestMethod]
        public void percentage_test()
        {
            //arrange
            ProductsController c2 = new ProductsController();

            // act
            var outcome2 = c2.percentage(5 ,0);
            var expected2 = 10;
            //assert 

            Assert.AreEqual(expected2, outcome2);

        }


        [TestMethod]
        public void percentage_test2()
        {
            //arrange
            ProductsController c2 = new ProductsController();

            // act
            var outcome2 = c2.percentage(5, 50);
            var expected2 = 10;
            //assert 

            Assert.AreEqual(expected2, outcome2);

        }

















    }
}
