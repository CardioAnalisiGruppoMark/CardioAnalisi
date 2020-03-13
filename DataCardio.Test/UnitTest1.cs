using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataCardio_test
{
    [TestClass]
    public class Cardio_test
    {
        [TestMethod]
        public void TestCalcoloBattitiMassimiCardiaci()
        {
            double risultato = DataCardio.CalcoloBattitiMassimiCardiaci(16);
            Assert.AreEqual(204,risultato);
        }
        
        [TestMethod]BattitiMassimiPalestra()
        {
            double risultato = DataCardio.CalcoloBattitiMassimiPalestra(16);
            Assert.AreEqual(183.6, risultato); 
        }

        [TestMethod]
        public void TestCalcoloBattitiMinimiinPalestra()
        {
            double risultato = DataCardio.CalcoloBattitiMinimiinPalestra(16);
            Assert.AreEqual(142.8,risultato);
        }

        [TestMethod]
        public void TestBattiti_Riposo()
        {
            string risultato = DataCardio.Battiti_Riposo(101);
            Assert.AreEqual("Tachicardia", risultato);
        }
    }
