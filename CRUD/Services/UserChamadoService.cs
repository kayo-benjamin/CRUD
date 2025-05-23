using System;
using System.Collections.Generic;
using System.Data;
using CRUD.Helpers;
using CRUD.Models;
using Npgsql;
using static CRUD.Constants.Constants;

namespace CRUD.Services
{
    public class UserChamadoService
    {
        private readonly string connectionString = DatabaseSettings.ConnectionUrl;

        public void CreateUserChamado(UserChamado userChamado)
        {
            using (var conn = new NpgsqlConnection(this.connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(@"
                    INSERT INTO chamados (
                    cham_data, cham_data_fechamento,
                    cham_detalhe, cham_status, atendente_id,
                    usu_id, cat_id, pri_id
                    ) VALUES (
                    @cham_data, @cham_data_fechamento,
                    @cham_detalhe, @cham_status, @atendente_id,
                    @usu_id, @cat_id, @pri_id
                    );", conn))
                {
                    cmd.Parameters.AddWithValue("cham_id", userChamado.ChamId);
                    cmd.Parameters.AddWithValue("cham_data", userChamado.ChamData);
                    cmd.Parameters.AddWithValue("cham_data_fechamento", userChamado.ChamDataFechamento);
                    cmd.Parameters.AddWithValue("cham_detalhe", userChamado.ChamDetalhe);
                    cmd.Parameters.AddWithValue("cham_status", userChamado.ChamStatus);
                    cmd.Parameters.AddWithValue("atendente_id", userChamado.AtendenteId);
                    cmd.Parameters.AddWithValue("usu_id", userChamado.UsuId);
                    cmd.Parameters.AddWithValue("cat_id", userChamado.CatId);
                    cmd.Parameters.AddWithValue("pri_id", userChamado.PriId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<UserChamado> GetAllUserChamados()
        {
            var userChamados = new List<UserChamado>();
            using (var conn = new NpgsqlConnection(this.connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT * FROM chamados;", conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            userChamados.Add(new UserChamado
                            {
                                ChamId = reader.GetInt32(reader.GetOrdinal("cham_id")),
                                ChamData = reader.GetDateTime(reader.GetOrdinal("cham_data")),
                                ChamDataFechamento = reader.GetDateTime(reader.GetOrdinal("cham_data_fechamento")),
                                ChamDetalhe = reader.GetString(reader.GetOrdinal("cham_detalhe")),
                                ChamStatus = reader.GetString(reader.GetOrdinal("cham_status")),
                                AtendenteId = reader.GetInt32(reader.GetOrdinal("atendente_id")),
                                UsuId = reader.GetInt32(reader.GetOrdinal("usu_id")),
                                CatId = reader.GetInt32(reader.GetOrdinal("cat_id")),
                                PriId = reader.GetInt32(reader.GetOrdinal("pri_id"))
                            });
                        }
                    }
                }
            }
            return userChamados;
        }

        public void UpdateUserChamado(UserChamado userChamado)
        {
            using (var conn = new NpgsqlConnection(this.connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(@"
                    UPDATE chamados SET 
                        cham_data = @cham_data,
                        cham_data_fechamento = @cham_data_fechamento,
                        cham_detalhe = @cham_detalhe,
                        cham_status = @cham_status,
                        atendente_id = @atendente_id,
                        usu_id = @usu_id,
                        cat_id = @cat_id,
                        pri_id = @pri_id
                    WHERE cham_id = @cham_id;", conn))
                {
                    cmd.Parameters.AddWithValue("cham_id", userChamado.ChamId);
                    cmd.Parameters.AddWithValue("cham_data", userChamado.ChamData);
                    cmd.Parameters.AddWithValue("cham_data_fechamento", userChamado.ChamDataFechamento);
                    cmd.Parameters.AddWithValue("cham_detalhe", userChamado.ChamDetalhe);
                    cmd.Parameters.AddWithValue("cham_status", userChamado.ChamStatus);
                    cmd.Parameters.AddWithValue("atendente_id", userChamado.AtendenteId);
                    cmd.Parameters.AddWithValue("usu_id", userChamado.UsuId);
                    cmd.Parameters.AddWithValue("cat_id", userChamado.CatId);
                    cmd.Parameters.AddWithValue("pri_id", userChamado.PriId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteUserChamado(int chamId)
        {
            using (var conn = new NpgsqlConnection(this.connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("DELETE FROM chamados WHERE cham_id = @cham_id;", conn))
                {
                    cmd.Parameters.AddWithValue("cham_id", chamId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
