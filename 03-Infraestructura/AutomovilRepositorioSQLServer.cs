using _02_Dominio;
using _02_Dominio.Repositorio;
using _02_Dominio.ValueObject;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Infraestructura
{
    public class AutomovilRepositorioSQLServer : AutomovilRepositorio
    {
        String connectionString = "Data Source=DESKTOP-EPPOF00\\SQLEXPRESS;Initial Catalog=Automovil;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";


 
        public void grabar(Automovil automovil)
        {
            using (SqlConnection conexion = new SqlConnection(this.connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand("INSERT INTO Automovil (patente, marca, modelo, precio) VALUES (@patente, @marca, @modelo, @precio)", conexion))
                {
                    comando.Parameters.Add("@patente", System.Data.SqlDbType.VarChar).Value = automovil.Id();
                    comando.Parameters.Add("@marca", System.Data.SqlDbType.VarChar).Value =   automovil.Marca();
                    comando.Parameters.Add("@modelo", System.Data.SqlDbType.VarChar).Value = automovil.Modelo();
                    comando.Parameters.Add("@precio", System.Data.SqlDbType.Float).Value = automovil.Precio();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public List<Automovil> obtenerTodos()
        {
            List<Automovil> automoviles = new List<Automovil>();
            using (SqlConnection conexion = new SqlConnection(this.connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand("SELECT patente, marca, modelo, precio FROM Automovil", conexion))
                {
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            String patente = reader.GetString(0);
                            String marca = reader.GetString(1);
                            String modelo = reader.GetString(2);
                            int precio = reader.GetInt32(3);
                            Automovil automovil = new Automovil(patente, marca, modelo, precio);
                            automoviles.Add(automovil);
                        }
                    }
                }
            }

            return automoviles;
        }



        public void EliminarAutomovil(string patente)
        {
            using (SqlConnection conexion = new SqlConnection(this.connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand("DELETE FROM Automovil WHERE patente =@Id", conexion))
                {
                    comando.Parameters.AddWithValue("@id", patente);
                    comando.ExecuteNonQuery();

                }
            }
        }

        public void ActualizarAutomovil(string patente, string marca, string modelo, int precio)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand command = new SqlCommand("UPDATE Automovil SET Marca = @marca, Modelo = @modelo, Precio = @precio WHERE Patente = @patente", conexion))
                {
                    command.Parameters.AddWithValue("@marca", marca);
                    command.Parameters.AddWithValue("@modelo", modelo);
                    command.Parameters.AddWithValue("@precio", precio);
                    command.Parameters.AddWithValue("@patente", patente);
                    command.ExecuteNonQuery();
                }


            }

        }
    }
}
