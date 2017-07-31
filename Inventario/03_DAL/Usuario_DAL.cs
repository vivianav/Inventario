using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Inventario._03_DAL
{
    public class Usuario_DAL
    {
        DataTable dt = new DataTable();
        public DataTable ReadUsuario ()
        {
            Connection objcon = new Connection();
            if (ConnectionState.Closed == objcon.conDAL.State)
            {
                objcon.conDAL.Open();
            }
            SqlCommand cmd = new SqlCommand("Select * from usuarios", objcon.conDAL);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load((rd));
                return dt;

            }
            catch
            {
                throw;
            }
           
        }
    }
}
