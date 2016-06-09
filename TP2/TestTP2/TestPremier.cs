using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using TP2;

namespace TestTP2
{
    [TestClass]
    public class TestPremier
    {
        [TestMethod]
        public void TestVersionUn()
        {
            bool resultat = Premiers.EstPremier(101);
            bool attendu = true;
            Assert.AreEqual(attendu, resultat, "resultat incorrect");
            Assert.IsTrue(Premiers.EstPremier(101));
        }

        [TestMethod]
        public void TestVersionDeux()
        {
            Assert.IsFalse(Premiers.EstPremier(1), "resultat incorrect");
            Assert.IsFalse(Premiers.EstPremier(0), "resultat incorrect");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestVersionTrois()
        // test pour vérifier qu'une exception est bien levée        
        {
            bool resultat = Premiers.EstPremier(-1);
        }

        [TestMethod]
        public void TestVersionQuatre()
        // test pour vérifier qu'aucune exception est levée 
        // si l'entier est naturel
        {
            try
            {
                bool resultat = Premiers.EstPremier(5);
                Assert.Fail();
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is AssertFailedException);
            }

        }

        [TestMethod]
        public void TestVersionCinq()
        // encore une autre façon de tester
        {
            try
            {
                bool resultat = Premiers.EstPremier(-5);
                Assert.Fail("Pas d'exception lancée");
            }
            catch (Exception ex)
            {
                // on vérifie l'exception
                StringAssert.Contains(ex.Message, "entier non naturel");
            }

        }


    }
}
