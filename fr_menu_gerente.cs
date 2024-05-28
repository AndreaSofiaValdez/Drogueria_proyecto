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
    public partial class fr_menu_gerente : Form
    {
        
        Fr_gerente_inventario fr_Gerente_Inventario = new Fr_gerente_inventario();
        Login FrmLogin = new Login();

        public void cargar()
        {
            Console.WriteLine("Text");
        }

        public fr_menu_gerente()
        {
            InitializeComponent();
        }

        //Mostar la fecha y la hora actual
        private void timerg_Tick(object sender, EventArgs e)
        {
            labelhorag.Text =DateTime.Now.ToString("HH:mm:ss");
            labelfechag.Text = DateTime.Now.ToLongDateString();

        }

        //Boton para abrir y crear la instancia del formulario de clientes
        private void button_menug_cli_Click(object sender, EventArgs e)
        {
            fr_menu_gerente.ActiveForm.Hide();
            Fr_gerente_cliente fr_Gerente_Cliente = new Fr_gerente_cliente();
            fr_Gerente_Cliente.Show();

        }

        //Boton para abrir y crear la instancia del formulario de inventario
        private void button_menug_inv_Click(object sender, EventArgs e)
        {
            fr_menu_gerente.ActiveForm.Hide();
            Fr_gerente_inventario fr_Gerente_Inventario = new Fr_gerente_inventario();
            fr_Gerente_Inventario.Show();
        }

        //Boton para abrir y crear la instancia del formulario de proveedores
        private void button_menug_prov_Click(object sender, EventArgs e)
        {
            fr_menu_gerente.ActiveForm.Hide();
            Fr_gerente_proveedores fr_Gerente_Proveedores = new Fr_gerente_proveedores();
            fr_Gerente_Proveedores.Show();

        }

        //Boton para cerrar salir del sistema 
        private void button_menug_salir_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
            
        }

        private void fr_menu_gerente_Load(object sender, EventArgs e)
        {
            
           
        }

        private void fr_menu_gerente_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void labelhorag_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fr_menu_gerente.ActiveForm.Hide();
            menuReporte menuReporte = new menuReporte();
            menuReporte.Show();
        }

        private void labelfechag_Click(object sender, EventArgs e)
        {

        }
    }
}
