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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void cb_cargo_login_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        
        private void button1_Click(object sender, EventArgs e)
        {

          //  int tipousuario;
            int tipologin = 0;
           
            

             //   tipousuario = 1;
                cls_Conexion BD = new cls_Conexion();
                BD.abrir();

                SqlCommand cmd = new SqlCommand("SELECT codigo_tipo, username, password FROM Empleado WHERE username=@usuario AND password=@pas", BD.sconexion);

                cmd.Parameters.AddWithValue("usuario", textUsuario.Text.ToString());
                cmd.Parameters.AddWithValue("pas", textContrasena.Text.ToString());
                SqlDataReader sda;

                sda = cmd.ExecuteReader();
                if (sda.Read() == true)
                {
                  
                    tipologin = Convert.ToInt32(sda[0]);
                    if(tipologin == 1)
                {
                    MessageBox.Show("Usuario Encontrado");
                    Login.ActiveForm.Hide();
                    fr_menu_gerente Gerenteform = new fr_menu_gerente();
                    Gerenteform.Show();
                }
                    if (tipologin == 2)
                {   
                     MessageBox.Show("Usuario Encontrado");
                     Login.ActiveForm.Hide();
                     Fr_Administrador Administradorform = new Fr_Administrador();
                     Administradorform.Show();
                }
                if (tipologin == 3)
                {
                    MessageBox.Show("Usuario Encontrado");
                    Login.ActiveForm.Hide();
                    fr_Vendedor_menu Vendedorform = new fr_Vendedor_menu();
                    Vendedorform.Show();

                }
                    

                }
                else
                {
                    MessageBox.Show("Usuario No Encontrado");
                }
                BD.cerrar();

            errorP_usuario_login.Clear();
            errorP_pas_login.Clear();

            }
        

        //Metodo para ocultar la contraseña o mostrarla mediante un checkbox

        private void checkBox_contra_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_contra.Checked == true)
            {
                textContrasena.PasswordChar = '\0';
            }
            else
            {
                textContrasena.PasswordChar = '*';

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        Class1 validaciones = new Class1();

        private void textUsuario_TextChanged(object sender, EventArgs e)
        {
            if (validaciones.validarlogin (textUsuario.Text, "El nombre de usuario no permite caracteres especiales"))
            {
                errorP_usuario_login.SetError(textUsuario, "El nombre de usuario no permite caracteres especiales");
                textUsuario.Text = "";

            }
            //else if(validaciones.validarEmpty(textUsuario.Text, "El nombre de usuario no puede estar vacio"))
            //{
            //    errorP_usuario_login.SetError(textUsuario, "El nombre de usuario no puede estar vacio");

            //}
        }

        private void textContrasena_TextChanged(object sender, EventArgs e)
        {
            if (validaciones.validarlogin(textContrasena.Text, "La password no permite caracteres especiales"))
            {
                errorP_pas_login.SetError(textContrasena, "La password no permite caracteres especiales");
                textContrasena.Text = "";

            }
            //else if (validaciones.validarEmpty(textContrasena.Text, "La password no puede estar vacio"))
            //{
            //    errorP_pas_login.SetError(textContrasena, "La password no puede estar vacio");

            //}

        }

        private void BtnSecurityPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Crear una instancia del nuevo formulario
            SecurityForm SForm = new SecurityForm();
            

            // Mostrar el nuevo formulario
            SForm.Show();

            // Ocultar el formulario actual

            // Opcional: puedes cerrar el formulario actual si ya no lo necesitas
            // this.Close();
        }
    }


}

   