using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionData
{
    public class VentaData
    {
        public static void AltaVenta(Venta venta)
        {
            string connectionString = @"Server=ESCRITORIO;DataBase=SistemaGestion;Trusted_Connection=True";

            string query = "INSERT INTO Venta (Comentarios, IdUsuario) VALUES( @Comentarios, @IdUsuario); INSERT into ProductoVendido (Stock, IdProducto, IdVenta) values (@Stock,@IdProducto, (select max(Id) from Venta))";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand comando = new SqlCommand(query, connection))
                    {
                        comando.Parameters.Add(new SqlParameter("Comentarios", SqlDbType.VarChar) { Value = venta.Comentarios });
                        comando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.Int) { Value = venta.Usuario.Id });
                        comando.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = 2 });
                        comando.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.Int) { Value = 5 });

                        comando.ExecuteNonQuery();
                    }

                    //string query2 = "select max(Id) from Venta";
                    //int id = 0;
                    //using (SqlCommand comando2 = new SqlCommand(query, connection))  // Conecta BD
                    //{
                    //    using (SqlDataReader dr = comando2.ExecuteReader())
                    //    {  // Ejetular consulta
                    //        if (dr.HasRows)           // hay Registros? 
                    //        {
                    //            dr.Read();
                    //            id = Convert.ToInt32(dr["Id"]);
                    //        }
                    //    }

                    //}
                    
                                connection.Close();
                };

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static List<Venta> ListarVentas()
        {

            List<Venta> lista = new List<Venta>();

            string connectionString = @"Server=ESCRITORIO; DataBase=SistemaGestion;Trusted_Connection=True";

            string query = "SELECT venta.Id as idV, Comentarios,usuario.Id as idU, Nombre, Apellido FROM [SistemaGestion].[dbo].[Venta] as venta Inner Join Usuario as usuario on venta.IdUsuario = usuario.Id ";

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
                                    var venta = new Venta();
                                    venta.Id = Convert.ToInt32(dr["idV"]);
                                    venta.Comentarios = dr["Comentarios"].ToString();
                                    usuario.Id = Convert.ToInt32(dr["idU"]);
                                    usuario.Nombre = dr["Nombre"].ToString();
                                    usuario.Apellido = dr["apellido"].ToString();
                                    venta.Usuario = usuario;

                                    lista.Add(venta);
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

        //public static void crearUsuario(Usuario usuario)
        //{
        //    string connectionString = @"Server=ESCRITORIO;DataBase=SistemaGestion;Trusted_Connection=True";

        //    string query = "INSERT INTO Usuario (Nombre, Apellido, NombreUsuario, Contraseña, Mail)" +
        //        "VALUES(@Nombre,@Apellido,@NombreUsuario, @Contraseña, @Mail)";
        //    try
        //    {
        //        using (SqlConnection connection = new SqlConnection(connectionString))
        //        {
        //            connection.Open();
        //            using (SqlCommand comando = new SqlCommand(query, connection))
        //            {
        //                comando.Parameters.Add(new SqlParameter("Nombre", SqlDbType.VarChar) { Value = usuario.Nombre });
        //                comando.Parameters.Add(new SqlParameter("Apellido", SqlDbType.VarChar) { Value = usuario.Apellido });
        //                comando.Parameters.Add(new SqlParameter("NombreUsuario", SqlDbType.VarChar) { Value = usuario.NombreUsuario });
        //                comando.Parameters.Add(new SqlParameter("Contraseña", SqlDbType.VarChar) { Value = usuario.Contraseña });
        //                comando.Parameters.Add(new SqlParameter("Mail", SqlDbType.VarChar) { Value = usuario.Mail });

        //                comando.ExecuteNonQuery();
        //            }
        //            connection.Close();
        //        };

        //    }
        //    catch (Exception ex)
        //    {

        //        throw;
        //    }
        //}

    }
}
