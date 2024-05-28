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
    public partial class fr_Vendedor_menu : Form
    {
        public fr_Vendedor_menu()
        {
            InitializeComponent();
        }

        private void fr_Vendedor_menu_Load(object sender, EventArgs e)
        {
   
        }

        private void timerg_Tick(object sender, EventArgs e)
        {

        }

        private void btn_salir_v_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void btnProductos_v_Click(object sender, EventArgs e)
        {
            fr_Vendedor_menu.ActiveForm.Hide();
            fr_Productos_vendedor fr_Productos_Vendedor =new fr_Productos_vendedor();
            fr_Productos_Vendedor.Show();
            
        }

        private void timerV_Tick(object sender, EventArgs e)
        {
            lblHora_v.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha_v.Text = DateTime.Now.ToLongDateString();

        }
    }
}
