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

            if (cual != string.Empty)
                orden = "select m.Codigo, m.Nombre, m.Laboratorio, m.Unidad, i.Cantidad, i.Fecha_Vencimiento" +
                         " from Medicamentos m, inventario i " +
                         "where i.Codigo = m.Codigo and  m.Nombre like '%" + (cual) + "%' " +
                         "order by m.nombre";
            else
                orden = "select m.Codigo, m.Nombre, m.Laboratorio, m.Unidad, i.Cantidad, i.Fecha_Vencimiento" +
                         " from Medicamentos m, Inventario i " +
                         "where i.Codigo = m.Codigo " +
                          "order by m.nombre";

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

        public DataSet consultarLaboratorio(string cual)
        {
            string orden = string.Empty;

            if (cual != string.Empty)
                orden = "select m.Codigo, m.Nombre, m.Laboratorio, m.Unidad, i.Cantidad, i.Fecha_Vencimiento" +
                         " from Medicamentos m, inventario i " +
                         "where i.Codigo = m.Codigo and  m.Laboratorio like '%" + (cual) + "%' " +
                         "order by m.Laboratorio";
            else
                orden = "select m.Codigo, m.Nombre, m.Laboratorio, m.Unidad, i.Cantidad, i.Fecha_Vencimiento" +
                         " from Medicamentos m, Inventario i " +
                         "where i.Codigo = m.Codigo " +
                          "order by m.nombre";

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

        public DataSet consultarVencimiento(int tiempo)
        {
            string orden = string.Empty;
            switch (tiempo)
            {
                case 0:
                    orden = "select m.Codigo, m.nombre, m.laboratorio, m.unidad, i.cantidad, i.Fecha_Vencimiento" +
                         " from Medicamentos m, Inventario i " +
                         "where i.Codigo = m.Codigo " +
                         "order by i.Fecha_Vencimiento asc";
                    break;
                case 1:
                    orden = "select m.Codigo, m.nombre, m.laboratorio, m.unidad, i.cantidad, i.Fecha_Vencimiento" +
                          " from Medicamentos m, inventario i " +
                          "where i.Codigo = m.Codigo and Fecha_Vencimiento BETWEEN dateadd(month," + -6 + ", getdate()) AND  getdate() " +
                          "order by i.Fecha_Vencimiento asc";
                    break;
                case 2:
                    orden = "select m.Codigo, m.nombre, m.laboratorio, m.unidad, i.cantidad, i.Fecha_Vencimiento" +
                          " from Medicamentos m, inventario i " +
                          "where i.Codigo = m.Codigo and Fecha_Vencimiento BETWEEN getdate() AND dateadd(week," + +1 + ", getdate()) " +
                          "order by i.Fecha_Vencimiento asc";
                    break;
                case 3:
                    orden = "select m.Codigo, m.nombre, m.laboratorio, m.unidad, i.cantidad, i.Fecha_Vencimiento" +
                          " from Medicamentos m, inventario i " +
                          "where i.Codigo = m.Codigo and Fecha_Vencimiento BETWEEN getdate() AND dateadd(month," + +1 + ", getdate()) " +
                          "order by i.Fecha_Vencimiento asc";
                    break;
                case 4:
                    orden = "select m.Codigo, m.nombre, m.laboratorio, m.unidad, i.cantidad, i.Fecha_Vencimiento" +
                          " from Medicamentos m, inventario i " +
                          "where i.Codigo = m.Codigo and Fecha_Vencimiento BETWEEN getdate() AND dateadd(yy, datediff(yy, 0, getdate()) + 1, -1) " +
                          "order by i.Fecha_Vencimiento asc";
                    break;
            }

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

        public DataSet consultarCodigo(string codigo)
        {
            string orden = string.Empty;

            if (codigo == string.Empty)
                orden = "select m.Codigo, m.Nombre, m.Laboratorio, m.Unidad, i.Cantidad, i.Fecha_Vencimiento" +
                         " from Medicamentos m, inventario i " +
                         "where i.Codigo = m.Codigo " +
                         "order by m.nombre";
            else
                orden = "select m.Codigo, m.Nombre, m.Laboratorio, m.Unidad, i.Cantidad, i.Fecha_Vencimiento" +
                         " from Medicamentos m, Inventario i " +
                         "where i.Codigo = m.Codigo and m.Codigo like '%" + codigo + "%' " +
                          "order by m.nombre";

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