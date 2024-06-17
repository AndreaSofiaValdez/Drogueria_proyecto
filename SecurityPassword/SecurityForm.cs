using Drogueria_proyecto.SecurityPassword;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Se agrego el campo de correo a la base de datos revicen que este actualizada 
namespace Drogueria_proyecto
{
    public partial class SecurityForm : Form
    {
        public SecurityForm()
        {
            InitializeComponent();
        }

        private void SecurityForm_Load(object sender, EventArgs e)
        {
           
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            var user = new NrecuperarPassword();
            var result = user.recoverPassword(txbCorreo.Text);
            MessageBox.Show(result, "Resultado de la Recuperación de Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);




        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            CambiarPassword CP = new CambiarPassword();
            CP.Show();
            this.Hide();
        }
    }
}
