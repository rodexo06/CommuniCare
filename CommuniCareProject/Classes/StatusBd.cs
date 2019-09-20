using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace CommuniCareProject.Classes
{
    public class StatusBd
    {
        private static string conexao = "Data Source= boalihack.database.windows.net;Integrated Security = true; Initial Catalog = boali_hack; uid=boali_admin;Password=hackathon@123;Trusted_Connection=False;Encrypt=True; ";
        public static List<Status> StatusAlimentacao()
        {
            string sql = "select * From status";
            var lista = new List<Status>();
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
                                var t = new Status
                                {
                                    IdStatus = Convert.ToInt32(dr["id"]),
                                    Descricao = Convert.ToString(dr["descricao"]),
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