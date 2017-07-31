using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventario._02_BL;

namespace Inventario._01_PL
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Usuario_BL objetoUsuarioBL = new Usuario_BL();
            dgvMostrar.DataSource = objetoUsuarioBL.GetUsuario();

        }
    }
}
