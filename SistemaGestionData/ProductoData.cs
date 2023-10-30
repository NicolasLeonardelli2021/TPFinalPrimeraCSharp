using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionData
{
    public class ProductoData
    {

        public static List<Producto> ListarProducto()
        {

            List<Producto> lista = new List<Producto>();

            string connectionString = @"Server=ESCRITORIO; DataBase=SistemaGestion;Trusted_Connection=True";

            string query = "SELECT Id, Descripciones ,Costo,PrecioVenta, Stock, IdUsuario FROM SistemaGestion.dbo.Producto";

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
                                    var producto = new Producto();
                                    producto.Id = Convert.ToInt32(dr["Id"]);
                                    producto.Descripciones = dr["Descripciones"].ToString();
                                    producto.Costo = Convert.ToDecimal(dr["Costo"]);
                                    producto.PrecioVenta = Convert.ToDecimal(dr["PrecioVenta"]);
                                    producto.Stock = Convert.ToInt32(dr["Stock"]);
                                    producto.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);

                                    lista.Add(producto);
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

        public static void crearProducto(Producto producto)
        {
            string connectionString = @"Server=ESCRITORIO;DataBase=SistemaGestion;Trusted_Connection=True";

            string query = "INSERT INTO Producto (Descripciones, Costo, PrecioVenta, Stock, IdUsuario)" +
                "VALUES(@Descripciones,@Costo,@PrecioVenta, @Stock, @IdUsuario)";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand comando = new SqlCommand(query, connection))
                    {
                        comando.Parameters.Add(new SqlParameter("Descripciones", SqlDbType.VarChar) { Value = producto.Descripciones });
                        comando.Parameters.Add(new SqlParameter("Costo", SqlDbType.Decimal) { Value = producto.Costo });
                        comando.Parameters.Add(new SqlParameter("PrecioVenta", SqlDbType.Decimal) { Value = producto.PrecioVenta });
                        comando.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = producto.Stock });
                        comando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.Int) { Value = producto.IdUsuario });

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

        public static void ModificarProducto(Producto producto)
        {
            string connectionString = @"Server=ESCRITORIO;DataBase=SistemaGestion;Trusted_Connection=True";

            string query = "UPDATE Producto SET Descripciones = @Descripciones, Costo = @Costo,PrecioVenta = @PrecioVenta,  Stock = @Stock" + " " +
                "WHERE Id = @Id";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand comando = new SqlCommand(query, connection))
                    {
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.VarChar) { Value = producto.Id });
                        comando.Parameters.Add(new SqlParameter("Descripciones", SqlDbType.VarChar) { Value = producto.Descripciones });
                        comando.Parameters.Add(new SqlParameter("Costo", SqlDbType.Decimal) { Value = producto.Costo });
                        comando.Parameters.Add(new SqlParameter("PrecioVenta", SqlDbType.Decimal) { Value = producto.PrecioVenta });
                        comando.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = producto.Stock });
                        //comando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.BigInt) { Value = producto.IdUsuario });

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

        public static void EliminarProducto(int id)
        {
            string connectionString = @"Server=ESCRITORIO;DataBase=SistemaGestion;Trusted_Connection=True";

            string query = "DELETE FROM Producto WHERE Id = @Id";

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
