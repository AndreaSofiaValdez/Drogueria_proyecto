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
    public partial class buscarproveedorad : Form
    {
        fr_Producto_Admin administradorform = new fr_Producto_Admin();
        public buscarproveedorad()
        {
            InitializeComponent();
        }

        private void buscarproveedorad_Load(object sender, EventArgs e)
        {
            // esta línea de código carga datos en la tabla 'dROGUERIADataSet8.Proveedor' 
            this.proveedorTableAdapter.Fill(this.dROGUERIADataSet8.Proveedor);
            cls_Conexion conexion = new cls_Conexion();
            conexion.cargarDatos(dataGridView1, "Proveedor");
        }

        private void buscarproveedorad_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
      

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            fr_Producto_Admin administradorform = new fr_Producto_Admin();
            Console.WriteLine(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            administradorform.txt_provinv_ad.Text = id;
            administradorform.Show();
            this.Close();
        }
    }
}
