using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace negocio
{
    public  class DiscoNegocio
    {
        public List<Disco> Listar()
        {
                List<Disco> Lista = new List<Disco>();
                SqlConnection conexion = new SqlConnection(); //Establecemos conexion 
                SqlCommand comando = new SqlCommand(); // Para realizar acciones en la base de datos
                SqlDataReader lector;
            try
            {
                conexion.ConnectionString = "server = .\\SQLEXPRESS ; database= DISCOS_DB ; integrated security = true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT D.Titulo, D.CantidadCanciones, D.UrlImagenTapa , E.Descripcion Genero, T.Descripcion Tipo FROM DISCOS D, ESTILOS E, TIPOSEDICION T WHERE D.IdEstilo = E.Id AND D.IdTipoEdicion = T.Id";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader(); 

                while (lector.Read())
                {
                    Disco aux = new Disco();
                    aux.Titulo = (string)lector["Titulo"];
                    aux.CantidadCanciones = (int)lector["CantidadCanciones"];
                    aux.UrlImagen = (string)lector["UrlImagenTapa"];
                    aux.Tipo = new Edicion();
                    aux.Tipo.TipoEdicion = (string)lector["Tipo"];
                    aux.Descripcion = new Estilo();
                    aux.Descripcion.Descripcion = (string)lector["Genero"];

                    Lista.Add(aux);
                }

                conexion.Close();
                return Lista;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }

        }

        public void agregarDisco(Disco nuevo)
        {
            AccesoDatos datos = new AccesoDatos(); //Con este objeto nos conectamos a la BD

            try
            {
                datos.SetConsulta("INSERT INTO DISCOS (TITULO, CantidadCanciones, UrlImagenTapa ) values (' " +nuevo.Titulo + " ',"+ nuevo.CantidadCanciones  + " , ' " + nuevo.UrlImagen +" ') ");  //insertamos la consulta
                datos.ejecutarConsulta();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void modificarDisco(Disco modificar)
        {

        }

    }
}
