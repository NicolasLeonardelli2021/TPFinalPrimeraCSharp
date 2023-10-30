using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionEntities;

namespace SistemaGestionData
{
    public class UsuarioData
    {
        public static List<Usuario> ListarUsuarios()
        {

            List<Usuario> lista = new List<Usuario>();

            string connectionString = @"Server=ESCRITORIO; DataBase=SistemaGestion;Trusted_Connection=True";

            string query = "SELECT Id,Nombre,Apellido,NombreUsuario,Contraseña,Mail FROM SistemaGestion.dbo.Usuario";

            try
            {
                using (SqlConnection connexion = new SqlConnection(connectionString))
                {
                    connexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, connexion))  // Conecta BD
                    {
                        using (SqlDataReader dr = comando.ExecuteReader())
                        {  // Ejetular consulta
                            if (dr.HasRows)           // hay Registros? 
                            {
                                while (dr.Read())     // Leelos
                                {                      // Mapea todos los registros
                                    var usuario = new Usuario();
                                    usuario.Id = Convert.ToInt32(dr["Id"]);
                                    usuario.Nombre = dr["Nombre"].ToString();
                                    usuario.Apellido = dr["Apellido"].ToString();
                                    usuario.NombreUsuario = dr["NombreUsuario"].ToString();
                                    usuario.Contraseña = dr["contraseña"].ToString();
                                    usuario.Mail = dr["Mail"].ToString();

                                    lista.Add(usuario);
                                }
                            }
                        }
                    }

                    // Opcional
                    connexion.Close();
                }

                return lista;
            }
            catch (Exception ex)

            {
                return null;
            }

        }

        public static void crearUsuario(Usuario usuario)
        {
            string connectionString = @"Server=ESCRITORIO;DataBase=SistemaGestion;Trusted_Connection=True";

            string query = "INSERT INTO Usuario (Nombre, Apellido, NombreUsuario, Contraseña, Mail)" +
                "VALUES(@Nombre,@Apellido,@NombreUsuario, @Contraseña, @Mail)";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand comando = new SqlCommand(query, connection))
                    {
                        comando.Parameters.Add(new SqlParameter("Nombre", SqlDbType.VarChar) { Value = usuario.Nombre });
                        comando.Parameters.Add(new SqlParameter("Apellido", SqlDbType.VarChar) { Value = usuario.Apellido });
                        comando.Parameters.Add(new SqlParameter("NombreUsuario", SqlDbType.VarChar) { Value = usuario.NombreUsuario });
                        comando.Parameters.Add(new SqlParameter("Contraseña", SqlDbType.VarChar) { Value = usuario.Contraseña });
                        comando.Parameters.Add(new SqlParameter("Mail", SqlDbType.VarChar) { Value = usuario.Mail });

                        comando.ExecuteNonQuery();
                    }
                    connection.Close();
                };

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static void ModificarUsuario(Usuario usuario)
        {
            string connectionString = @"Server=ESCRITORIO;DataBase=SistemaGestion;Trusted_Connection=True";

            string query = "UPDATE Usuario SET Nombre = @Nombre, Apellido = @Apellido,NombreUsuario = @NombreUsuario,  Contraseña = @Contraseña, Mail = @Mail " + " " +
                "WHERE Id = @Id";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand comando = new SqlCommand(query, connection))
                    {
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.VarChar) { Value = usuario.Id });
                        comando.Parameters.Add(new SqlParameter("Nombre", SqlDbType.VarChar) { Value = usuario.Nombre });
                        comando.Parameters.Add(new SqlParameter("apellido", SqlDbType.VarChar) { Value = usuario.Apellido });
                        comando.Parameters.Add(new SqlParameter("NombreUsuario", SqlDbType.VarChar) { Value = usuario.NombreUsuario });
                        comando.Parameters.Add(new SqlParameter("contraseña", SqlDbType.VarChar) { Value = usuario.Contraseña });
                        comando.Parameters.Add(new SqlParameter("Mail", SqlDbType.VarChar) { Value = usuario.Mail });

                        comando.ExecuteNonQuery();
                    }
                    connection.Close();
                };
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        public static void EliminarUsuario(int id)
        {
            string connectionString = @"Server=ESCRITORIO;DataBase=SistemaGestion;Trusted_Connection=True";

            string query = "DELETE FROM Usuario WHERE Id = @Id";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand comando = new SqlCommand(query, connection))
                    {
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.VarChar) { Value = id });

                        comando.ExecuteNonQuery();
                    }
                    connection.Close();
                };
            }
            catch (Exception ex)
            {

                throw;
            }


        }

    }
}
                   



