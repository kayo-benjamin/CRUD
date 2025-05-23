using System;
using System.Collections.Generic;
using System.Data;
using Npgsql;
using CRUD.Constants;
using static CRUD.Constants.Constants;

namespace CRUD.Helpers
{
    internal class DatabaseHelper
    {
        private static string connectionString = DatabaseSettings.ConnectionUrl;

        public static bool IsConnected { get; private set; }
        public static string DatabaseName { get; private set; }
        public static string PostgreSqlVersion { get; private set; }
        public static string DatabaseSize { get; private set; }
        public static int ActiveConnections { get; private set; }

        public static bool TestConnection()
        {
            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    // Atualiza as propriedades da conexão
                    IsConnected = true;
                    DatabaseName = conn.Database;
                    PostgreSqlVersion = conn.PostgreSqlVersion.ToString();

                    // Recupera informações adicionais
                    DatabaseSize = GetDatabaseSize(conn);
                    ActiveConnections = GetActiveConnections(conn);

                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao conectar: {ex.Message}");
                IsConnected = false;
                return false;
            }
        }

        private static string GetDatabaseSize(NpgsqlConnection conn)
        {
            try
            {
                using (var cmd = new NpgsqlCommand("SELECT pg_size_pretty(pg_database_size(current_database()))", conn))
                {
                    return cmd.ExecuteScalar()?.ToString() ?? "Desconhecido";
                }
            }
            catch
            {
                return "Erro ao obter tamanho";
            }
        }

        private static int GetActiveConnections(NpgsqlConnection conn)
        {
            try
            {
                using (var cmd = new NpgsqlCommand("SELECT COUNT(*) FROM pg_stat_activity WHERE state = 'active'", conn))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch
            {
                return -1; // Indica erro ao obter conexões
            }
        }
    }
}
