using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmaCure
{
    public partial class FrmKolicine : Form
    {
        public FrmKolicine()
        {
            InitializeComponent();
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            FrmMain m = new FrmMain();
            m.Show();
            this.Close();
        }

        private void poslovnicaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.poslovnicaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._17003_DBDataSet);
        }

        private void FrmKolicine_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_17003_DBDataSet.Lijekovi' table. You can move, or remove it, as needed.
            this.lijekoviTableAdapter.Fill(this._17003_DBDataSet.Lijekovi);
            // TODO: This line of code loads data into the '_17003_DBDataSet.Dostupnost' table. You can move, or remove it, as needed.
            this.dostupnostTableAdapter.Fill(this._17003_DBDataSet.Dostupnost);
            // TODO: This line of code loads data into the '_17003_DBDataSet.Poslovnica' table. You can move, or remove it, as needed.
            this.poslovnicaTableAdapter.Fill(this._17003_DBDataSet.Poslovnica);
        }
    }
}
