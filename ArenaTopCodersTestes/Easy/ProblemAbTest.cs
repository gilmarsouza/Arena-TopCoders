using System;
using System.Text;
using System.Collections.Generic;
using ArenaTopCoders.Easy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArenaTopCodersTestes.Easy
{
    /// <summary>
    /// Summary description for ProblemAb
    /// </summary>
    [TestClass]
    public class ProblemAbTest
    {
        private ProblemAb problemAb;

        public ProblemAbTest()
        {
            problemAb = new ProblemAb();
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void ValidaStringComUmParValido()
        {
            var resultado = problemAb.RetornaNumeroParesValidos("AB");
            Assert.AreEqual(resultado,1);
        }

        [TestMethod]
        public void ValidaStringSemNenhumParValido()
        {
            var resultado = problemAb.RetornaNumeroParesValidos("BB");
            Assert.AreEqual(resultado, 0);
        }

        [TestMethod]
        public void ValidaStringComDoisParesValidos()
        {
            var resultado = problemAb.RetornaNumeroParesValidos("ABBA");
            Assert.AreEqual(resultado, 2);
        }

        [TestMethod]
        public void ValidaStringComDozeParesValidos()
        {
            var resultado = problemAb.RetornaNumeroParesValidos("BAABBABAAB");
            Assert.AreEqual(resultado, 12);
        }

        [TestMethod]
        public void DevolveStringVaziaNumeroSuperiorAoMelhorCaso()
        {
            var cadeia = problemAb.CriaString(9, 21);
            Assert.AreEqual(cadeia,"");           
        }

        [TestMethod]
        public void DevolveStringDeSeisCaracteresComOMaximoDeParesValidos()
        {
            var cadeia = problemAb.CriaString(6, 9);
            var resultado = problemAb.RetornaNumeroParesValidos(cadeia);
            Assert.AreEqual(resultado, 9);
        }

        [TestMethod]
        public void DevolveStringDeSeteCaracteresComOMaximoDeParesValidos()
        {
            var cadeia = problemAb.CriaString(7, 12);
            var resultado = problemAb.RetornaNumeroParesValidos(cadeia);
            Assert.AreEqual(resultado, 12);
        }

        [TestMethod]
        public void DevolveStringDeSeteCaracteresComQuatroParesValidos()
        {
            var cadeia = problemAb.CriaString(7, 4);
            var resultado = problemAb.RetornaNumeroParesValidos(cadeia);
            Assert.AreEqual(resultado, 4);
        }

        [TestMethod]
        public void DevolveStringDeVinteCaracteresComQuizeParesValidos()
        {
            var cadeia = problemAb.CriaString(20, 15);
            var resultado = problemAb.RetornaNumeroParesValidos(cadeia);
            Assert.AreEqual(resultado, 15);
        }

        [TestMethod]
        public void DevolveStringDeSeisCaracteresComOitoParesValidos()
        {
            var cadeia = problemAb.CriaString(6, 8);
            var resultado = problemAb.RetornaNumeroParesValidos(cadeia);
            Assert.AreEqual(resultado, 8);
        }

        [TestMethod]
        public void DevolveStringDeNoveCaracteresComQuatorzeParesValidos()
        {
            var cadeia = problemAb.CriaString(9, 14);
            var resultado = problemAb.RetornaNumeroParesValidos(cadeia);
            Assert.AreEqual(resultado, 14);
        }

        [TestMethod]
        public void DevolveStringDeSeisCaracteresComSeteParesValidos()
        {
            var cadeia = problemAb.CriaString(6, 7);
            var resultado = problemAb.RetornaNumeroParesValidos(cadeia);
            Assert.AreEqual(resultado, 7);
        }

        [TestMethod]
        public void DevolveStringDeNoveCaracteresComQuizeParesValidos()
        {
            var cadeia = problemAb.CriaString(9, 15);
            var resultado = problemAb.RetornaNumeroParesValidos(cadeia);
            Assert.AreEqual(resultado, 15);
        }


    }
}
