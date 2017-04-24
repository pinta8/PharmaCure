using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Data_Layer
{
    public class DBCon
    {
        public SqlConnection Connection = new SqlConnection("Data Source=31.147.204.119\\PISERVER,1433;Initial Catalog=17003_DB;User ID=17003_User;Password=dDkG8AAT");

        public SqlConnection GetCon()
        {
            if (Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }
            return Connection;
        }

        public int IzvrsiUpit(SqlCommand Command)
        {
            int rows = -1;
            Command.Connection = GetCon();
            try
            {
                rows = Command.ExecuteNonQuery();
            }
            catch
            {

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
        public object DohvatiVrijednost(SqlCommand Command)
        {
            Command.Connection = GetCon();
            object obj = -1;
            obj = Command.ExecuteScalar();
            Connection.Close();
            return obj;
        }

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
