using System;
//using FiguryLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        /*[DataTestMethod]
        [DataRow(3, 4, 5)]
        [DataRow(2, 3, 4)]
        [DataRow(1, 1, 1)]



        [TestMethod]
        public void ConstruktorPoprawneDaneTrojkatUtworzony(double a, double b, double c)
        {

            //AAA - trzy a
            //Arrange
            //Act
            //Assert

            //Act 
            Trojkat t = new Trojkat(a, b, c);

            //Assert 
            Assert.AreEqual(a, t.A);
            Assert.AreEqual(b, t.B);
            Assert.AreEqual(c, t.C);

        }


        [TestMethod]
        public void ConstruktorDefaultPoprawnie()
        {
            //Arrange
            //Act
            Trojkat t = new Trojkat();

            //Assert
            Assert.AreEqual(1, t.A);
            Assert.AreEqual(1, t.B);
            Assert.AreEqual(1, t.C);
        }

        [DataTestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [DataRow(-1, 1, 1)]
        [DataRow(1, -1, 1)]
        [DataRow(1, 1, -1)]
        public void ConstruktorParametry_ArgumentOutOfRangeException(double a, double b, double c)
        {
            Trojkat t = new Trojkat(a, b, c);
        }

        [DataTestMethod]
        [ExpectedException(typeof(ArgumentException))]
        [DataRow(1, 1, 100)]
        [DataRow(100, 1, 1)]
        [DataRow(1, 100, 1)]
        public void ConstructorNieSpelnionyWarunekTrojkota_ArgumentExcepcion(double a, double b, double c)
        {
            Trojkat t = new Trojkat(a, b, c);
        }



        [DataTestMethod]
        [DataRow(1, 1, 1, 3)]
        [DataRow(3, 4, 5, 12)]
        public void PropertyObwod_Poprawnie(double a, double b, double c, double wynik)
        {
            //Act
            var t = new Trojkat(a, b, c);


            //Assert
            Assert.AreEqual(wynik, t.Obwód,0.01); // to nie zawsze bezie działać. Musimu zaokrąglić 0.01


        }

        [DataTestMethod]
        [DataRow(1, 2, 3, 16)]
        [DataRow(2, 3, 2, 7)]
        public void PropertyPole_Poprawnie(double a, double b, double c, double pole)
        {
            //Act
            var t = new Trojkat(a, b, c);

            //Assert
            Assert.AreEqual(pole, t.Pole, 0.01);  //*/
        }
    }

