using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            //Arrange

            Opearations opearations = new Opearations();
            int x = 5;
            int y = 120;


            int z = 2;
            int quvvet = 3;
            int netice = 8;


            string ad1 = "qli";
            string gozlenilen = "ila";

            //Act
            int y1 = opearations.factorial(x);
            int y2 = opearations.power(z, quvvet);
            string yoxlanmali = opearations.tesrAd(ad1);

            //Assert

            Assert.AreEqual(y, y1);
            Assert.AreEqual(y2, netice);
          
            Assert.AreEqual(yoxlanmali, gozlenilen);



        }
    }
}
