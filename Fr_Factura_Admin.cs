using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Drogueria_proyecto
{
    public partial class Fr_Factura_Admin : Form
    {
        public Fr_Factura_Admin()
        {
            InitializeComponent();
        }

        private void cargarDGV()
        {
            cls_Conexion BD = new cls_Conexion();
            BD.abrir();

            SqlCommand cmd = new SqlCommand("SELECT * FROM DataGridViewFactura", BD.sconexion);


            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv_administrador_factura.DataSource = dt;
            BD.cerrar();
        }

        private void Fr_Factura_Admin_Load(object sender, EventArgs e)
        {
            
            // TODO: esta línea de código carga datos en la tabla 'dROGUERIADataSet15.cbx_Empleado' Puede moverla o quitarla según sea necesario.
            this.cbx_EmpleadoTableAdapter.Fill(this.dROGUERIADataSet15.cbx_Empleado);
            // TODO: esta línea de código carga datos en la tabla 'cbx_cliente.Cliente' Puede moverla o quitarla según sea necesario.
            //this.cbx_ClienteTableAdapter.Fill(this.dROGUERIADataSet15.cbx_Cliente);
            // TODO: esta línea de código carga datos en la tabla 'cbx_cliente.Cliente' Puede moverla o quitarla según sea necesario.
            //this.cbx_ProductoTableAdapter.Fill(this.dROGUERIADataSet15.cbx_Producto);


            cbx_producto_fact.SelectedIndex = -1;
            cargarDGV();
            
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Fr_Administrador fr_Administrador = new Fr_Administrador();
            fr_Administrador.Show();
        }

        private void FrmLector_Load(object sender, EventArgs e)
        {
            cls_Conexion clsConexion1 = new cls_Conexion();
            clsConexion1.cargarDatos(dgv_administrador_factura);
        }
        int i;

        private void dgv_administrador_factura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
           
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           // try
           // {
                if (txt_cantidad_gr.Text == string.Empty || txt_precio_gr.Text == string.Empty || dgvdetalle.Rows.Count < 1)
                {
                    MessageBox.Show("Error... No puede insertar datos en blanco o debe ingresar un producto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {


                    Decimal subtotal=0;
                    foreach(DataGridViewRow dgvrow in dgvdetalle.Rows)
                    {
                        subtotal = subtotal + Convert.ToDecimal(dgvrow.Cells[3].Value);

                    }
                    

                    cls_Conexion BD = new cls_Conexion();
                    BD.abrir();
                    SqlCommand agregar = new SqlCommand("insert into Factura values (@codigo_cliente, @codigo_empleado, @subtotal)", BD.sconexion);

                    agregar.Parameters.AddWithValue("@codigo_cliente",cbx_cliente_fact.SelectedValue.ToString());
                    agregar.Parameters.AddWithValue("@codigo_empleado", cbx_empleado_fact.SelectedValue.ToString());
                    agregar.Parameters.AddWithValue("@subtotal", subtotal.ToString());
                    agregar.ExecuteNonQuery();

                  
                    int idmaxfactura = 0;
                    String consulta = "select max(codigo_factura) from Factura";
                    SqlDataReader recuperar;
                    SqlCommand ejecutar = new SqlCommand();
                    ejecutar = new SqlCommand(consulta, BD.sconexion);
                    recuperar = ejecutar.ExecuteReader();
                    if (recuperar.Read() == true)
                    {
                        idmaxfactura = Convert.ToInt32(recuperar[0]);  
                    }
                recuperar.Close();

                    foreach (DataGridViewRow registros in dgvdetalle.Rows)
                    {
                  
                    decimal subtotal1 = Convert.ToDecimal(registros.Cells[2].Value) * Convert.ToDecimal(registros.Cells[1].Value);
                        SqlCommand insertard =new SqlCommand( "insert into Detalle_Factura values (@codigo_factura, @codigo_producto, @cantidad, @precio_producto, @subtotal)",BD.sconexion);
                        insertard.Parameters.Clear();
                        insertard.Parameters.AddWithValue("@codigo_factura", idmaxfactura.ToString());
                        insertard.Parameters.AddWithValue("@codigo_producto", registros.Cells[0].Value.ToString());
                        insertard.Parameters.AddWithValue("@cantidad", registros.Cells[1].Value.ToString());
                        insertard.Parameters.AddWithValue("@precio_producto", registros.Cells[2].Value.ToString());
                        insertard.Parameters.AddWithValue("@subtotal", subtotal1.ToString());
                        insertard.ExecuteNonQuery();
                    
                        String consulta1 = "select existencia_producto from Producto where codigo_producto=" + registros.Cells[0].Value.ToString();
                        SqlDataReader recuperar1;
                        SqlCommand ejecutar1= new SqlCommand();
                        ejecutar1 = new SqlCommand(consulta1, BD.sconexion);
                        recuperar1 = ejecutar1.ExecuteReader();
                        int stock=0;
                        if (recuperar1.Read() == true) {
                            stock = Convert.ToInt32(recuperar1[0]);
                        }
                        else
                        {
                            System.Console.WriteLine("No encontrado");
                        }


                        recuperar1.Close();

                        stock = stock - Convert.ToInt32(registros.Cells[1].Value);


                        String actualizar1 = "update Producto set existencia_producto=@stock where codigo_producto=@codproducto";
                        SqlCommand ejactualizar1 = new SqlCommand(actualizar1, BD.sconexion);
                        ejactualizar1.Parameters.Clear();
                        ejactualizar1.Parameters.AddWithValue("@codproducto", registros.Cells[0].Value.ToString());
                        ejactualizar1.Parameters.AddWithValue("@stock", stock);
                        ejactualizar1.ExecuteNonQuery();
                    }

                    BD.cerrar();
                    txt_cantidad_gr.Clear();
                    cbx_producto_fact.SelectedIndex = -1;
                    cbx_empleado_fact.SelectedIndex = -1;
                    txt_IdFactura_gr.Clear();
                    cbx_cliente_fact.SelectedIndex = -1;
                    txt_precio_gr.Clear();
                    this.txt_IdFactura_gr.Focus();
                    this.Close();
                   
                }
               
               
           // }
         //   catch
           //    {
             //  MessageBox.Show("Error...El codigo ya existe en la base de datos");
             //  }

            errorP_cantfact_ad.Clear();
            errorP_preciofact_ad.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_IdFactura_gr.Text == string.Empty || txt_cantidad_gr.Text == string.Empty || txt_precio_gr.Text == string.Empty)
                {
                    MessageBox.Show("Error... No puede modificar datos en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    cls_Conexion BD = new cls_Conexion();
                    BD.abrir();
                    SqlCommand modificar = new SqlCommand("update Factura set codigo_cliente=@codigo_cliente," +
                        "codigo_empleado=@codigo_empleado, subtotal=@subtotal where codigo_factura=@codigo_factura", BD.sconexion);
                    modificar.Parameters.AddWithValue("@codigo_factura", txt_IdFactura_gr.Text);
                  
                    modificar.Parameters.AddWithValue("@codigo_cliente", cbx_cliente_fact.SelectedValue.ToString());
                    modificar.Parameters.AddWithValue("@codigo_empleado", cbx_empleado_fact.SelectedValue.ToString());
                    modificar.Parameters.AddWithValue("@codigo_factura", txt_IdFactura_gr.Text);
                    modificar.Parameters.AddWithValue("@precio_producto", txt_precio_gr.Text);


                    modificar.ExecuteNonQuery();
                    BD.cerrar();
                    txt_cantidad_gr.Clear();
                    cbx_producto_fact.SelectedIndex = -1;
                    cbx_empleado_fact.SelectedIndex = -1;
                    txt_IdFactura_gr.Clear();
                    cbx_cliente_fact.SelectedIndex = -1;
                    txt_precio_gr.Clear();

                    this.txt_IdFactura_gr.Focus();
                    cls_Conexion clsConexion1 = new cls_Conexion();
                    clsConexion1.cargarDatos(dgv_administrador_factura, "Factura");
                }
            }
            catch
            {
                MessageBox.Show("Error...El codigo ya existe en la base de datos");
            }
            errorP_cantfact_ad.Clear();
            errorP_preciofact_ad.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_IdFactura_gr.Text == string.Empty || txt_cantidad_gr.Text == string.Empty || txt_precio_gr.Text == string.Empty)
                {
                    MessageBox.Show("Error... No puede eliminar datos en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    cls_Conexion BD = new cls_Conexion();
                    BD.abrir();
                    SqlCommand eliminar = new SqlCommand("delete from Factura where codigo_factura=@codigo_factura", BD.sconexion);
                    eliminar.Parameters.AddWithValue("@codigo_factura", Convert.ToInt32(txt_IdFactura_gr.Text));



                    eliminar.ExecuteNonQuery();
                    BD.cerrar();
                    txt_cantidad_gr.Clear();
                    cbx_producto_fact.SelectedIndex = -1;
                    cbx_empleado_fact.SelectedIndex = -1;
                    txt_IdFactura_gr.Clear();
                    cbx_cliente_fact.SelectedIndex = -1;
                    txt_precio_gr.Clear();

                    this.txt_IdFactura_gr.Focus();
                    cls_Conexion clsConexion1 = new cls_Conexion();
                    clsConexion1.cargarDatos(dgv_administrador_factura, "Factura");
                }
            }
            catch
            {
                MessageBox.Show("Error...El codigo ya existe en la base de datos");
            }
        }

        private void dgv_administrador_factura_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        Class1 validaciones = new Class1();
        private object cbx_ClienteTableAdapter;
        private object cbx_ProductoTableAdapter;

        private void txt_cantidad_gr_TextChanged(object sender, EventArgs e)
        {
            if (validaciones.validarNumeros(txt_cantidad_gr.Text, "La cantidad solo debe contener numeros"))
            {
                errorP_cantfact_ad.SetError(txt_cantidad_gr, "La cantidad solo debe contener numeros");
                txt_cantidad_gr.Text = "";
            }
        }

        private void txt_precio_gr_TextChanged(object sender, EventArgs e)
        {
               
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cantidaddisponible = 0;
            cls_Conexion BD = new cls_Conexion();
            BD.abrir();
            String consulta = "select existencia_producto from Producto where codigo_producto=" + cbx_producto_fact.SelectedValue.ToString();
            SqlDataReader recuperar;
            SqlCommand ejecutar= new SqlCommand();
            ejecutar = new SqlCommand(consulta, BD.sconexion);
            recuperar = ejecutar.ExecuteReader();
            if(recuperar.Read() == true){
                cantidaddisponible = Convert.ToInt32(recuperar[0]);
            }


            else{
                System.Console.WriteLine("No se encontro ese producto");
            }

              
            if (cantidaddisponible > Convert.ToInt32(txt_cantidad_gr.Text))
            {
                decimal subtotal = Convert.ToDecimal(txt_precio_gr.Text) * Convert.ToDecimal(txt_cantidad_gr.Text);
                dgvdetalle.Rows.Add(cbx_producto_fact.SelectedValue.ToString(), txt_cantidad_gr.Text, txt_precio_gr.Text, subtotal.ToString());
            }

            else
            {
                MessageBox.Show("La cantidad de producto que quiere comprar no esta disponible", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



            BD.cerrar();
           




        }

        private void cbx_producto_fact_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_producto_fact.SelectedValue != null)
            {

            cls_Conexion BD = new cls_Conexion();
            BD.abrir();
            String consulta = "select precio_producto, existencia_producto from Producto where codigo_producto=" + cbx_producto_fact.SelectedValue.ToString();
            SqlDataReader recuperar;
            SqlCommand ejecutar = new SqlCommand();
            ejecutar = new SqlCommand(consulta, BD.sconexion);
            recuperar = ejecutar.ExecuteReader();
            if (recuperar.Read() == true)
            {
               
                txt_precio_gr.Text = recuperar[0].ToString();
            }
            BD.cerrar();
            }
        }

        private void dgv_administrador_factura_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_IdFactura_gr.Text = dgv_administrador_factura.CurrentRow.Cells[0].Value.ToString();
            cbx_cliente_fact.SelectedValue = dgv_administrador_factura.CurrentRow.Cells[1].Value.ToString();
            cbx_empleado_fact.SelectedValue = dgv_administrador_factura.CurrentRow.Cells[3].Value.ToString();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbx_cliente_fact_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbx_empleado_fact_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
