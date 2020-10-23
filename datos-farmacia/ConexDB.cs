using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos_farmacia
{
    public class ConexDb
    {
        public SqlConnection conexion;
        public string cadenaConexion = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog = clases_farmacia.DataContext; Integrated Security = True;";

        #region CONSTRUCTOR
        public ConexDb()
        {
            conexion = new SqlConnection(cadenaConexion);
        }
        #endregion

        #region MÉTODOS
        public void AbrirConexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Broken || conexion.State == ConnectionState.Closed)
                    conexion.Open();
            }
            catch (Exception e)
            {
                throw new Exception("Error al abrir conexión", e);
            }
        }

        public void CerrarConexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Error al cerrar conexión", e);
            }
        }
    }
    #endregion
}