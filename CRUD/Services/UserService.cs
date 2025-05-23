using System;
using System.Collections.Generic;
using System.Data;
using CRUD.Helpers;
using CRUD.Models;
using Npgsql;
using static CRUD.Constants.Constants;

namespace CRUD.Services
{
    public class UserService
    {
        private readonly string connectionString = DatabaseSettings.ConnectionUrl;
        public void CreateUser(User user)
        {
            using (var conn = new NpgsqlConnection(this.connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(@"
                    INSERT INTO users (usu_nome, usu_email, usu_senha, tipo_id, usu_cpf, usu_telefone, usu_endereco, usu_datanasc, usu_sexo, usu_status) 
                    VALUES (@nome, @email, @senha, @tipoId, @cpf, @telefone, @endereco, @dataNascimento, @sexo, @status);", conn))
                {
                    cmd.Parameters.AddWithValue("nome", user.Nome);
                    cmd.Parameters.AddWithValue("email", user.Email);
                    cmd.Parameters.AddWithValue("senha", user.Senha);
                    cmd.Parameters.AddWithValue("tipoId", user.TipoId);
                    cmd.Parameters.AddWithValue("cpf", user.CPF);
                    cmd.Parameters.AddWithValue("telefone", user.Telefone);
                    cmd.Parameters.AddWithValue("endereco", user.Endereco);
                    cmd.Parameters.AddWithValue("dataNascimento", user.DataNascimento);
                    cmd.Parameters.AddWithValue("sexo", user.Sexo);
                    cmd.Parameters.AddWithValue("status", user.Status);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public List<User> GetAllUsers()
        {
            var users = new List<User>();
            using (var conn = new NpgsqlConnection(this.connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT usu_id, usu_nome, usu_senha, usu_email, usu_cpf, usu_telefone, usu_endereco, usu_datanasc, usu_sexo, usu_status, tipo_id FROM usuarios;", conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            users.Add(new User
                            {
                                Id = reader.GetInt32(0),
                                Nome = reader.GetString(1),
                                Senha = reader.GetString(2),
                                Email = reader.GetString(3),
                                CPF = reader.GetString(4),
                                Telefone = reader.GetString(5),
                                Endereco = reader.GetString(6),
                                DataNascimento = reader.GetDateTime(7),
                                Sexo = reader.GetString(8),
                                Status = reader.IsDBNull(9) ? null : reader.GetString(9),
                                TipoId = reader.GetInt32(10)
                            });
                        }
                    }
                }
            }
            return users;
        }
    }
}
