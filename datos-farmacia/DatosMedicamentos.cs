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
                orden = "select m.Codigo, m.nombre, m.laboratorio, m.unidad, i.cantidad, i.Fecha_Vencimiento" +
                         " from Medicamentos m, inventario i " +
                         "where i.Codigo = m.Codigo and  m.Nombre like '%" + (cual) + "%'";
            else
                orden = "select m.Id, m.Codigo, m.Nombre, m.Laboratorio, m.Fecha_Vencimiento, m.Unidad, i.Cantidad" +
                         " from Medicamentos m, Inventario i " +
                         "where i.Codigo = m.Codigo";

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

        public DataSet consultarFecha(int meses)
        {
            string orden = string.Empty;
            if (meses == 0)
                orden = "select m.Id, m.Codigo, m.Nombre, m.Laboratorio, m.Fecha_Vencimiento, m.Unidad, i.Cantidad" +
                         " from Medicamentos m, Inventario i " +
                         "where i.Codigo = m.Codigo";
            else
                orden = "select m.Codigo, m.nombre, m.laboratorio, m.unidad, i.cantidad, i.Fecha_Vencimiento" +
                         " from Medicamentos m, inventario i " +
                         "where i.Codigo = m.Codigo and Fecha_Vencimiento BETWEEN getdate() AND dateadd(month,"+ +meses + ", getdate())";

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