using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos_farmacia
{
    public class DatosMedicamentos : ConexDb
    {
        public DataSet consultarMedicamento(string cual)
        {
            string orden = string.Empty;
            if (cual != "todos")
                orden = "select m.Id, m.Codigo, m.Nombre, m.Laboratorio, m.Fecha_Vencimiento, m.Unidad, i.Cantidad" +
                         " from Medicamentos m, Inventario i " +
                         "where m.Nombre = '" + (cual) +"'";
            else
                orden = "select m.Id, m.Codigo, m.Nombre, m.Laboratorio, m.Fecha_Vencimiento, m.Unidad, i.Cantidad" +
                         " from Medicamentos m, Inventario i ";

            SqlCommand cmd = new SqlCommand(orden, conexion);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                AbrirConexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar registros", e);
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }
            return ds;
        }
    }
}
