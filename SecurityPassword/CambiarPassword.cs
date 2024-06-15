using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drogueria_proyecto.SecurityPassword
{
    public partial class CambiarPassword : Form
    {
        public CambiarPassword()
        {
            InitializeComponent();
        }

        private void btnCambiarPass_Click(object sender, EventArgs e)
        {
            string username = txbUsuario.Text; // Obtener el nombre de usuario ingresado
            string password = txbActual.Text; // Obtener la contraseña actual ingresada
            string newPassword = txbNPass.Text; // Obtener la nueva contraseña ingresada
            string confirmNewPassword =txbConfirmarPass.Text; // Obtener la confirmación de la nueva contraseña

            // Verificar que la nueva contraseña y su confirmación coincidan
            if (newPassword != confirmNewPassword)
            {
                MessageBox.Show("Las contraseñas nuevas no coinciden. Por favor, verifique.");
                return; // Salir del método sin cambiar la contraseña
            }

            // Verificar si el usuario y la contraseña coinciden en la base de datos
            bool usuarioValido = VerificarUsuario(username, password);

            if (usuarioValido)
            {
                // Cambiar la contraseña en la base de datos
                CambiarContrasena(username, newPassword);
                MessageBox.Show("Contraseña cambiada exitosamente.");
            }
            else
            {
                MessageBox.Show("El usuario o la contraseña actual son incorrectos.");
            }
        }

        private bool VerificarUsuario(string username, string password)
        {
            bool usuarioValido = false;

            // Aquí deberías realizar la consulta a la base de datos para verificar el usuario y la contraseña
            // Asumiendo que tienes una conexión establecida y un SqlCommand configurado

            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-4FPC8J0\\MSSQLSERVER01;Initial Catalog = DROGUERIA; Integrated Security = True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Empleado WHERE username = @username AND password = @password", con);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    usuarioValido = true;
                }
            }

            return usuarioValido;
        }

        // Función para cambiar la contraseña en la base de datos
        private void CambiarContrasena(string username, string newPassword)
        {
            // Aquí deberías actualizar la contraseña en la base de datos
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-4FPC8J0\\MSSQLSERVER01;Initial Catalog = DROGUERIA; Integrated Security = True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Empleado SET password = @newPassword WHERE username = @username", con);
                cmd.Parameters.AddWithValue("@newPassword", newPassword);
                cmd.Parameters.AddWithValue("@username", username);

                cmd.ExecuteNonQuery();
            }
        }

        private void CambiarPassword_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Login Login = new Login();
            Login.Show();
            this.Hide();
        }
    }
}
