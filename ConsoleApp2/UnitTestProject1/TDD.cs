using System;
using ConsoleApp2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class TDD
    {
        [TestMethod]
        public void Tranformando52EmRomano()            
        {
            var programa = new Programa();
            string a = programa.NumeroIndoArabicos(52);
            Assert.AreEqual(a , "LII");
        }
        [TestMethod]
        public void Tranformando0EmRomano()
        {
            var programa = new Programa();
            string a = programa.NumeroIndoArabicos(0);
            Assert.AreEqual(a, "Este numero não existe");
        }

        [TestMethod]
        public void Tranformando752EmRomano()
        {
            var programa = new Programa();
            string a = programa.NumeroIndoArabicos(752);
            Assert.AreEqual(a, "DCCLII");
        }

        [TestMethod]
        public void Tranformando7EmRomano()
        {
            var programa = new Programa();
            string a = programa.NumeroIndoArabicos(7);
            Assert.AreEqual(a, "VII");
        }

        [TestMethod]
        public void Tranformando1797EmRomano()
        {
            var programa = new Programa();
            string a = programa.NumeroIndoArabicos(1797);
            Assert.AreEqual(a, "MDCCXCVII");
        }

        [TestMethod]
        public void Tranformando1000EmRomano()
        {
            var programa = new Programa();
            string a = programa.NumeroIndoArabicos(1000);
            Assert.AreEqual(a, "M");
        }

        [TestMethod]
        public void Tranformando700EmRomano()
        {
            var programa = new Programa();
            string a = programa.NumeroIndoArabicos(700);
            Assert.AreEqual(a, "DCC");
        }
        [TestMethod]
        public void Tranformando90EmRomano()
        {
            var programa = new Programa();
            string a = programa.NumeroIndoArabicos(90);
            Assert.AreEqual(a, "XC");
        }
        [TestMethod]
        public void TranformandoXEmIndoArabico()
        {
            var programa = new Programa();
            int a = programa.NumeroRomano("X");
            Assert.AreEqual(a, 10);
        }
        [TestMethod]
        public void TranformandoXIIEmIndoArabico()
        {
            var programa = new Programa();
            int a = programa.NumeroRomano("XII");
            Assert.AreEqual(a, 12);
        }
        [TestMethod]
        public void TranformandoCMXLmIndoArabico()
        {
            var programa = new Programa();
            int a = programa.NumeroRomano("CMXL");
            Assert.AreEqual(a, 940);
        }
        [TestMethod]
        public void TranformandoMDCCXCVIIEmIndoArabico()
        {
            var programa = new Programa();
            int a = programa.NumeroRomano("MDCCXCVII");
            Assert.AreEqual(a, 1797);
        }
    }

}
