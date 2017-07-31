using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Inventario._03_DAL
{
    public class Connection
    {
        public SqlConnection conDAL = new SqlConnection("Data Source=VIVIANA-DESKTOP\\SQLEXPRESS;Initial Catalog=inventario;Integrated Security=True");

    }
}
