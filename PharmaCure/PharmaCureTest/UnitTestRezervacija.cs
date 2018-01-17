using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PharmaCureTest
{
    [TestClass]
    public class UnitTest1
    {
        ///<summary>
        ///Testiranje upita za odabir zadnjeg id-a koji je u tablici Rezervacija
        ///</summary>
        [TestMethod]
        public void TestUpitVratiZadnjiID()
        {
            CrtajGraf.FrmKolicine testFrmKolicine = new CrtajGraf.FrmKolicine();
            int id=testFrmKolicine.VratiZadnjiID();
            Assert.IsTrue(id > 0, "ID mora biti veći od 0!");
        }
        /// <summary>
        /// Testiranje upita koji dohvaća sve rezervacije koje nisu arhivirane.
        /// </summary>
        [TestMethod]
        public void TestStanjeUpit()
        {
            PharmaCure.FrmRezervacijaPopis frmRezervacijaPopis = new PharmaCure.FrmRezervacijaPopis();
            int stanje= frmRezervacijaPopis.TestStanje();
            Assert.IsTrue(stanje > 0, "Stanje mora biti veći od 0!");
        }
        /// <summary>
        /// Testiranje lijeka koji je već unešen u rezervaciju.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(System.Data.SqlClient.SqlException))]
        public void TestPostojeciLijekRezervacija()
        {
            PharmaCure.FrmRezervacijaLijek frmRezervacijaLijek = new PharmaCure.FrmRezervacijaLijek();
            frmRezervacijaLijek.UnesiLijek(1, 26, 5);
        }
        /// <summary>
        /// Unos lijeka u rezervaciju koja ne postoji.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(System.Data.SqlClient.SqlException))]
        public void TestNePostojeciLijekRezervacija()
        {
            PharmaCure.FrmRezervacijaLijek frmRezervacijaLijek = new PharmaCure.FrmRezervacijaLijek();
            frmRezervacijaLijek.UnesiLijek(1, 999, 5);
        }
    }
}
