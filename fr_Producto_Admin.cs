﻿using System;
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
    public partial class fr_Producto_Admin : Form
    {
        public fr_Producto_Admin()
        {
            InitializeComponent();
        }
        public void cargartxtproveedor(string id)
        {
            txt_provinv_ad.Text = id;
        }
        public string ProveedorID
        {
            get { return txt_provinv_ad.Text; }
            set { txt_provinv_ad.Text = value; }
        }

        cbxCategoria cat = new cbxCategoria();

        private void fr_Producto_Admin_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dROGUERIADataSet20.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter1.Fill(this.dROGUERIADataSet20.Producto);
            // TODO: esta línea de código carga datos en la tabla 'dROGUERIADataSet4.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.dROGUERIADataSet4.Producto);
            //cls_Conexion BD = new cls_Conexion();
            //BD.abrir();

            //SqlCommand cmd = new SqlCommand("SELECT * FROM Producto", BD.sconexion);


            //SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //dgv_prod_ad.DataSource = dt;
            //BD.cerrar();

            comboProdCat_ad.DataSource = cat.CargarCombo();
            comboProdCat_ad.DisplayMember = "descripcion_categoria";
            comboProdCat_ad.ValueMember = "codigo_categoria";
        }

        private void dvg_administrador_producto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dvg_administrador_producto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codinv_ad.Text = dgv_prod_ad.CurrentRow.Cells[0].Value.ToString();
            txt_Nom_ad.Text = dgv_prod_ad.CurrentRow.Cells[1].Value.ToString();
            txt_desinv_ad.Text = dgv_prod_ad.CurrentRow.Cells[2].Value.ToString();
            comboProdCat_ad.Text = dgv_prod_ad.CurrentRow.Cells[3].Value.ToString();
            txt_provinv_ad.Text = dgv_prod_ad.CurrentRow.Cells[4].Value.ToString();
            txt_exisinv_ad.Text = dgv_prod_ad.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_codinv_ad.Text == string.Empty || comboProdCat_ad.Text == string.Empty || txt_desinv_ad.Text == string.Empty || txt_Nom_ad.Text == string.Empty || txt_provinv_ad.Text == string.Empty)
                {
                    MessageBox.Show("Error... No puede insertar datos en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    cls_Conexion BD = new cls_Conexion();
                    BD.abrir();
                    SqlCommand agregar = new SqlCommand("insert into Producto values (@nombre_producto, @descripcion_producto ,@categoria_producto, @proveedor_producto, " +
                        "@existencia, @precio_producto)", BD.sconexion);
                    agregar.Parameters.AddWithValue("@nombre_producto", txt_Nom_ad.Text);
                    agregar.Parameters.AddWithValue("@descripcion_producto", txt_desinv_ad.Text);
                    agregar.Parameters.AddWithValue("@categoria_producto", comboProdCat_ad.Text);
                    agregar.Parameters.AddWithValue("@proveedor_producto", txt_provinv_ad.Text);
                    agregar.Parameters.AddWithValue("@existencia", txt_exisinv_ad.Text);
                    agregar.Parameters.AddWithValue("@precio_producto", textBox8.Text);


                    agregar.ExecuteNonQuery();
                    BD.cerrar();
                    txt_codinv_ad.Clear();
                    txt_exisinv_ad.Clear();
                    comboProdCat_ad.Text = string.Empty;
                    txt_desinv_ad.Clear();
                    txt_Nom_ad.Clear();
                    txt_provinv_ad.Clear();
                    textBox8.Clear();

                    this.txt_Nom_ad.Focus();
                    cls_Conexion clsConexion1 = new cls_Conexion();
                    clsConexion1.cargarDatos(dgv_prod_ad, "Producto");
                }
            }
            catch
            {
                MessageBox.Show("Error...El codigo ya existe en la base de datos");
            }

            errorP_catpro_ad.Clear();
            errorP_despro_ad.Clear();
            errorP_existpro_ad.Clear();
            errorP_nombpro_ad.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
             try
                {
                if (txt_exisinv_ad.Text == string.Empty || comboProdCat_ad.Text == string.Empty || txt_desinv_ad.Text == string.Empty || txt_Nom_ad.Text == string.Empty || txt_provinv_ad.Text == string.Empty)
                {
                    MessageBox.Show("Error... No puede modificar datos en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    cls_Conexion BD = new cls_Conexion();
                    BD.abrir();
                    SqlCommand modificar = new SqlCommand("update Producto set nombre_producto=@nombre_producto,descripcion_producto=@descripcion_producto,categoria_producto=@categoria_producto," +
                    "proveedor_producto=@proveedor_producto, existencia_producto=@existencia where codigo_producto=@codigo_producto", BD.sconexion);
                    modificar.Parameters.AddWithValue("@codigo_producto", txt_codinv_ad.Text);
                    modificar.Parameters.AddWithValue("@nombre_producto", txt_Nom_ad.Text);
                    modificar.Parameters.AddWithValue("@descripcion_producto", txt_desinv_ad.Text);
                    modificar.Parameters.AddWithValue("@categoria_producto", comboProdCat_ad.Text);
                    modificar.Parameters.AddWithValue("@proveedor_producto", txt_provinv_ad.Text);
                    modificar.Parameters.AddWithValue("@existencia", txt_exisinv_ad.Text);


                    modificar.ExecuteNonQuery();
                    BD.cerrar();
                    txt_codinv_ad.Clear();
                    txt_exisinv_ad.Clear();
                    comboProdCat_ad.Text = String.Empty;
                    txt_desinv_ad.Clear();
                    txt_Nom_ad.Clear();
                    txt_provinv_ad.Clear();

                    this.txt_Nom_ad.Focus();
                    cls_Conexion clsConexion1 = new cls_Conexion();
                    clsConexion1.cargarDatos(dgv_prod_ad, "Producto");
                }
             }
            catch
               {
                 MessageBox.Show("Error...El codigo ya existe en la base de datos");
               }
            errorP_catpro_ad.Clear();
            errorP_despro_ad.Clear();
            errorP_existpro_ad.Clear();
            errorP_nombpro_ad.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_exisinv_ad.Text == string.Empty || comboProdCat_ad.Text == string.Empty || txt_desinv_ad.Text == string.Empty || txt_Nom_ad.Text == string.Empty || txt_provinv_ad.Text == string.Empty)
                {
                    MessageBox.Show("Error... No puede eliminar datos en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    cls_Conexion BD = new cls_Conexion();
                    BD.abrir();
                    SqlCommand eliminar = new SqlCommand("delete from Producto where codigo_producto=@codigo_producto", BD.sconexion);
                    eliminar.Parameters.AddWithValue("@codigo_producto", txt_codinv_ad.Text);


                    eliminar.ExecuteNonQuery();
                    BD.cerrar();
                    txt_codinv_ad.Clear();
                    txt_exisinv_ad.Clear();
                    comboProdCat_ad.Text = String.Empty;
                    txt_desinv_ad.Clear();
                    txt_Nom_ad.Clear();
                    txt_provinv_ad.Clear();

                    this.txt_Nom_ad.Focus();
                    cls_Conexion clsConexion1 = new cls_Conexion();
                    clsConexion1.cargarDatos(dgv_prod_ad, "Producto");
                }
            }
            catch
            {
                MessageBox.Show("Error...El codigo ya existe en la base de datos");
            }
        }

        private void btnBuscarad_Click(object sender, EventArgs e)
        {
            buscarproveedorad buscarprov = new buscarproveedorad();
            buscarprov.Owner = this; // Establece el formulario actual como el propietario
            buscarprov.ShowDialog();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Fr_Administrador fr_Administrador = new Fr_Administrador();
            fr_Administrador.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        Class1 validaciones = new Class1();

        private void txt_Nom_ad_TextChanged(object sender, EventArgs e)
        {
            if (validaciones.validarLetras(txt_Nom_ad.Text, "El nombre no permite caracteres especiales"))
            {
                errorP_nombpro_ad.SetError(txt_Nom_ad, "El nombre no permite caracteres especiales");
                txt_Nom_ad.Text = "";

            }
        }

       

        private void txt_exisinv_ad_TextChanged(object sender, EventArgs e)
        {
            if (validaciones.validarNumeros(txt_exisinv_ad.Text, "La existencia solo debe contener números"))
            {
                errorP_existpro_ad.SetError(txt_exisinv_ad, " La existencia solo debe contener numeros");
                txt_exisinv_ad.Text = "";

            }
        }

        private void txt_desinv_ad_TextChanged(object sender, EventArgs e)
        {
            if (validaciones.validarLetras(txt_desinv_ad.Text, "La descripcion no permite caracteres especiales ni números"))
            {
                errorP_despro_ad.SetError(txt_desinv_ad, "La descripcion no permite caracteres especiales ni números");
                txt_desinv_ad.Text = "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (validaciones.validarprecio(textBox8.Text, "El precio no permite caracteres especiales ni letras"))
            {
                errorP_despro_ad.SetError(textBox8, "El precio no permite caracteres especiales ni letras");
                textBox8.Text = "";
            }

        }

        private void txt_codinv_ad_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_prod_ad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

