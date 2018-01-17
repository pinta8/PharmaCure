using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PharmaCureTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        ///<summary>
        ///Vraća 
        ///</summary>
        public void TestVratiZadnjiID()
        {
            CrtajGraf.FrmKolicine testFrmKolicine = new CrtajGraf.FrmKolicine();
            int id=testFrmKolicine.VratiZadnjiID();
            Assert.IsTrue(id > 0, "ID mora biti veći od 0!");
        }
        [TestMethod]
        public void TestStanjeUpit()
        {
            PharmaCure.FrmRezervacijaPopis frmRezervacijaPopis = new PharmaCure.FrmRezervacijaPopis();
            int stanje= frmRezervacijaPopis.TestStanje();
            Assert.IsTrue(stanje > 0, "Stanje mora biti veći od 0!");
        }
        [TestMethod]
        [ExpectedException(typeof(System.Data.SqlClient.SqlException))]
        public void TestPostojeciLijekRezervacija()
        {
            PharmaCure.FrmRezervacijaLijek frmRezervacijaLijek = new PharmaCure.FrmRezervacijaLijek();
            frmRezervacijaLijek.UnesiLijek(1, 26, 5);
        }

        [TestMethod]
        [ExpectedException(typeof(System.Data.SqlClient.SqlException))]
        public void TestNePostojeciLijekRezervacija()
        {
            PharmaCure.FrmRezervacijaLijek frmRezervacijaLijek = new PharmaCure.FrmRezervacijaLijek();
            frmRezervacijaLijek.UnesiLijek(1, 999, 5);
        }
    }
}
