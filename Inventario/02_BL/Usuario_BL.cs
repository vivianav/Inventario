using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Inventario._03_DAL;


namespace Inventario._02_BL
{
    public class Usuario_BL
    {
        public DataTable GetUsuario()
        {
            try
            {
                Usuario_DAL objetoDAL = new Usuario_DAL();
                return objetoDAL.ReadUsuario();

          
            }
            catch
            {

                throw;
            }
        }

    }
}
