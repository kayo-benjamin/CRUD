using System;
using System.Collections.Generic;
using System.Data;
using CRUD.Helpers;
using CRUD.Models;
using Npgsql;
using static CRUD.Constants.Constants;

namespace CRUD.Services
{
    public class CargoService
    {
        private readonly string connectionString = DatabaseSettings.ConnectionUrl;

        public bool CreateCargo(Cargo cargo)
        {
            try
            {
                using (var connection = new NpgsqlConnection(this.connectionString))
                {
                    connection.Open();
                    using (var cmd = new NpgsqlCommand(@"
                        INSERT INTO tipo_usuario (tipo_nome)
                        VALUES (@tipo_nome);
                    ", connection))
                    {
                        cmd.Parameters.AddWithValue("tipo_nome", cargo.TipoNome);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao criar cargo: {ex.Message}");
                return false;
            }
        }
        public List<Cargo> GetCargoList()
        {
            var cargos = new List<Cargo>();
            using (var conn = new NpgsqlConnection(this.connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("" +
                    "SELECT tipo_id, tipo_nome " +
                    "FROM tipo_usuario;", conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cargos.Add(new Cargo 
                            {
                                Id = reader.GetInt32(0),
                                TipoNome = reader.GetString(1),
                            });
                        }
                    }
                }
            }
            return cargos;
        }
    }
}
