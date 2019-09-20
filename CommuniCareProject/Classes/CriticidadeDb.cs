using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace CommuniCareProject.Classes
{
    public class CriticidadeDb
    {
        private static string conexao = "Data Source= boalihack.database.windows.net;Integrated Security = true; Initial Catalog = boali_hack; uid=boali_admin;Password=hackathon@123;Trusted_Connection=False;Encrypt=True; ";
        public static List<Criticidade> StatusAlimentacao()
        {
            string sql = "select * From criticidade";
            var lista = new List<Criticidade>();
            using (var cn = new SqlConnection(conexao))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    try
                    {
                        using (var dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                var t = new Criticidade
                                {
                                    IdCriticidade = Convert.ToInt32(dr["id"]),
                                    DescricaoCriticidade = Convert.ToString(dr["descricao"]),
                                    HoraCriticidade = Convert.ToInt32(dr["tempo"]),
                                };
                                lista.Add(t);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        string erro = "Erro: " + ex.ToString();
                    }
                }
            }
            return lista;
        }
    }
}