using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Data_Layer
{
    public class DBCon
    {
        //connection na bazu r17003
        public SqlConnection Connection = new SqlConnection("Data Source=31.147.204.119\\PISERVER,1433;Initial Catalog=17003_DB;User ID=17003_User;Password=dDkG8AAT");

        public SqlConnection GetCon()
        {
            if (Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }
            return Connection;
        }
        //funkcija za izvrsavanje upita
        public int IzvrsiUpit(SqlCommand Command)
        {
            int rows = -1;
            Command.Connection = GetCon();
            try
            {
                rows = Command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Connection.Close();
            return rows;
        }
        public int Izvrsi(SqlCommand Command)
        {
            int rows = -1;
            using (Connection)
            {
                using (Command)
                {
                    try
                    {
                        Command.Connection = GetCon();
                        rows = Command.ExecuteNonQuery();
                    }

                    finally
                    {
                        Connection.Close();
                    }
                }
            }
            return rows;
        }
        //funkcija za vraćanje jedne vrijednosti iz baze
        public object DohvatiVrijednost(SqlCommand Command)
        {
            Command.Connection = GetCon();
            object obj = -1;
            obj = Command.ExecuteScalar();
            Connection.Close();
            return obj;
        }
        //funkcija za vraćanje tablice iz baze
        public DataTable DohvatiDT(SqlCommand Command)
        {
            Command.Connection = GetCon();
            SqlDataReader sdr;
            DataTable dt = new DataTable();
            sdr = Command.ExecuteReader();
            dt.Load(sdr);
            Connection.Close();
            return dt;
        }
    }
}
