using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucTapNhom_Bai1
{
    public class Connection_Query
    {
        string ConnectionString = @"Data Source = DESKTOP-CJ93CIP;Initial Catalog = ThucTapNhom_1;Integrated Security = True";
        protected SqlConnection con = new SqlConnection( @"Data Source = DESKTOP-CJ93CIP;Initial Catalog = ThucTapNhom_1;Integrated Security = True");
        public void OpenConnection()
        {
            con.Open();
        }
        public string GetCon()
        {
            return this.ConnectionString;
        }
        public SqlConnection GetConn()
        {
            return this.con;
        }
        public void CloseConnection()
        {
            this.con.Close();
        }
        public bool ExecuteQueries(string Query)
        {
            try
            {
                OpenConnection();
                SqlCommand commandAddNV = new SqlCommand(Query, con);
                commandAddNV.ExecuteNonQuery();
                CloseConnection();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public SqlDataReader DataReader(string Query)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        public object ShowDatainGridView(string Query)
        {
            SqlDataAdapter da = new SqlDataAdapter(Query, ConnectionString);
            DataSet ds = new DataSet();
            da.Fill(ds);
            object dataum = ds.Tables[0];
            return dataum;
        }
        
    }
}
