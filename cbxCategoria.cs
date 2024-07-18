using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drogueria_proyecto
{
    internal class cbxCategoria
    {
        cls_Conexion clsConexion1 = new cls_Conexion();

        public DataTable CargarCombo()
        {

            SqlCommand cmd = new SqlCommand("SP_CARGARCOMBOBOX", clsConexion1.sconexion);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
    }
}
