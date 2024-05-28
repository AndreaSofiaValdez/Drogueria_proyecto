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
    public partial class buscarproveedor : Form
    {
        Fr_gerente_inventario gerenteform = new Fr_gerente_inventario();
        public buscarproveedor()
        {
            InitializeComponent();
        }
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void buscarproveedor_Load(object sender, EventArgs e)
        {
            // esta línea de código carga datos en la tabla 'dROGUERIADataSet9.Proveedor' 
            this.proveedorTableAdapter.Fill(this.dROGUERIADataSet9.Proveedor);
            cls_Conexion conexion = new cls_Conexion();
            conexion.cargarDatos(dataGridView1, "Proveedor");
         }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            
            gerenteform.txt_gr_provinv.Text = id;
            gerenteform.Show();
            this.Close();

        }
    }
}
