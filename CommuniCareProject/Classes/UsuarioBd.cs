using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace CommuniCareProject.Classes
{
    public class UsuarioBd
    {
        private static string conexao = "Data Source= boalihack.database.windows.net;Integrated Security = true; Initial Catalog = boali_hack; uid=boali_admin;Password=hackathon@123;Trusted_Connection=False;Encrypt=True; ";

        public void PerfilIncluir(Usuario usuarios)
        {
            string sql = "INSERT INTO usuario(cnpj, nome, data_abertura, rua, numero, complemento, cep, bairro, municipio, uf) VALUES(@cnpj, @nome, @data, @rua, @numero, @complemento, @cep, @bairro, @municipio, @uf)";
            using (var cn = new SqlConnection(conexao))
            {
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@cnpj", usuarios.CNPJ);
                        cmd.Parameters.AddWithValue("@nome", usuarios.Nome);
                        cmd.Parameters.AddWithValue("@data", DateTime.Now.ToString());
                        cmd.Parameters.AddWithValue("@rua", usuarios.Rua);
                        cmd.Parameters.AddWithValue("@numero", usuarios.Numero);
                        cmd.Parameters.AddWithValue("@complemento", usuarios.Complemento);
                        cmd.Parameters.AddWithValue("@cep", usuarios.Cep);
                        cmd.Parameters.AddWithValue("@bairro", usuarios.Bairro);
                        cmd.Parameters.AddWithValue("@municipio", usuarios.Municipio);
                        cmd.Parameters.AddWithValue("@uf", usuarios.Uf);
                        cn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        string erro = "Erro: " + ex.ToString();
                    }
                }

            }
        }

        public static List<Usuario> ListaUsuario()
        {
            string sql = "select * from usuario";
            var lista = new List<Usuario>();

            using (var cn = new SqlConnection(conexao))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    using (var dr = cmd.ExecuteReader())
                    {
                        try
                        {
                            while (dr.Read())
                            {
                                var usuario = new Usuario
                                {
                                    CNPJ = dr["cnpj"].ToString(),
                                    Nome = dr["nome"].ToString(),
                                    Rua = dr["rua"].ToString()
                                };
                                lista.Add(usuario);
                            }
                        }

                        catch (Exception ex)
                        {
                            string erro = "Erro: " + ex.ToString();
                        }
                    }
                }
            }
            return lista;
        }
    }
}
