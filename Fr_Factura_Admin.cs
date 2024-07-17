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
using Microsoft.Reporting.Map.WebForms.BingMaps;
using System.Windows.Markup;
using System.Data.SqlClient;

namespace Drogueria_proyecto
{
    public partial class Fr_Factura_Admin : Form
    {
        public Fr_Factura_Admin()
        {
            InitializeComponent();
        }
        private void Fr_Factura_Admin_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source = localhost; Initial Catalog = DROGUERIA; Integrated Security = True");
            SqlCommand cmd = new SqlCommand("Select codigo_empleado, nombre_empleado from Empleado", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable table1 = new DataTable();
            da.Fill(table1);


            cboxEmp.DataSource = table1;
            cboxEmp.DisplayMember = "nombre_empleado";
            cboxEmp.ValueMember = "codigo_empleado";
            //////////////////////
            SqlCommand cmds = new SqlCommand("Select codigo_cliente, nombre_cliente from Cliente", conn);
            SqlDataAdapter das = new SqlDataAdapter();
            das.SelectCommand = cmds;
            DataTable table2 = new DataTable();
            das.Fill(table2);


            cboxCliente.DataSource = table2;
            cboxCliente.DisplayMember = "nombre_cliente";
            cboxCliente.ValueMember = "codigo_cliente";
            //////////////////////
            SqlCommand cmdss = new SqlCommand("Select codigo_producto, nombre_producto from Producto", conn);
            SqlDataAdapter dass = new SqlDataAdapter();
            dass.SelectCommand = cmdss;
            DataTable table3 = new DataTable();
            dass.Fill(table3);


            cboxProducto.DataSource = table3;
            cboxProducto.DisplayMember = "nombre_producto";
            cboxProducto.ValueMember = "codigo_producto";

            conn.Close();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Fr_Administrador fr_Administrador = new Fr_Administrador();
            fr_Administrador.Show();
        }








        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public static decimal GetProductPrice(string productName)
        {
            decimal price = 0;



            using (SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=DROGUERIA;Integrated Security=True"))
            {
                connection.Open();

                string sql = "SELECT precio_producto FROM Producto WHERE nombre_producto = @nombre_producto";
                SqlCommand command = new SqlCommand(sql, connection);

                command.Parameters.AddWithValue("@nombre_producto", productName);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        price = Convert.ToDecimal(reader["precio_producto"]);
                    }
                    else
                    {

                        Console.WriteLine("Producto no encontrado!");
                    }
                }
            }

            return price;
        }
        private void cboxProducto_SelectedValueChanged(object sender, EventArgs e)
        {
            //SqlConnection testp = new SqlConnection("Data Source = localhost; Initial Catalog = DROGUERIA; Integrated Security = True");
            //  testp.Open();

            //  SqlCommand testpp = new SqlCommand("Select precio_producto from Producto where nombre_producto = @nombre_producto", testp);
            //  testpp.Parameters.AddWithValue("@nombre_producto", cboxProducto);
            //  SqlDataReader testppp = testpp.ExecuteReader();
            //  while (testppp.Read())
            //  {
            //      txtPrecio.Text = testppp.GetValue(0).ToString();
            //  }

        }

        private void cboxProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxProducto.SelectedIndex != -1) // Check if an item is selected
            {
                {
                    if (cboxProducto.SelectedIndex != -1)
                    {
                        string productName = cboxProducto.SelectedItem.ToString();

                        decimal price = GetProductPrice(productName);
                        if (price > 0)
                        {
                            txtPrecio.Text = price.ToString();
                        }
                        else
                        {
                            txtPrecio.Text = "Precio no encontrado!";
                        }
                    }
                }
            }
        }
    }
}
