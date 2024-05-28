using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drogueria_proyecto
{
    public partial class Fr_Administrador : Form
    {
        
        Login FrmLogin = new Login();

        public void cargar()
        {
            Console.WriteLine("Text");
        }

        public Fr_Administrador()
        {
            InitializeComponent();
        }

        private void Fr_Administrador_Load(object sender, EventArgs e)
        {

        }

        private void horafecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToShortTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            Fr_Administrador.ActiveForm.Hide();
            Fr_Empleado_Admin fr_Empleado_Admin = new Fr_Empleado_Admin();
            fr_Empleado_Admin.Show();

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Fr_Administrador.ActiveForm.Hide();
            Fr_Cliente_Admin fr_Cliente_Admin = new Fr_Cliente_Admin();
            fr_Cliente_Admin.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            Fr_Administrador.ActiveForm.Hide();
            fr_Producto_Admin fr_Producto_Admin = new fr_Producto_Admin();
            fr_Producto_Admin.Show();
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            Fr_Administrador.ActiveForm.Hide();
            Fr_Factura_Admin fr_Factura_Admin = new Fr_Factura_Admin();
            fr_Factura_Admin.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }
    }
}
