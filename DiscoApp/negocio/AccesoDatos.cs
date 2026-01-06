using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace negocio
{
    public class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
        public SqlDataReader Lector   // con este podemos leer el lector desde afuera
        {
            get { return lector; }
        }
        public AccesoDatos()
        {
            conexion = new SqlConnection("server = .\\SQLEXPRESS ; database= DISCOS_DB ; integrated security = true");
            comando = new SqlCommand();
        }

        public void SetConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta; 
        }

        //para ejecutar consultas de no lectura
        public void ejecutarConsulta()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void ejecutarLectura () // Solo sirve para consultas de lectura
        {
            comando.Connection = conexion; 
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex ; 
            }
        }

        public void cerrarConexion()
        {
            if (lector != null)
                lector.Close();   // Cerramos primero el lector , si es que hemos hecho una lectura
            conexion.Close();     // Cerramos la conexion de la BD
        }

    }
}
