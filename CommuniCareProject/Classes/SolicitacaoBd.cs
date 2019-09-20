using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI.WebControls;

namespace CommuniCareProject.Classes
{
    public class SolicitacaoBd
    {
        string Login;
        private static string conexao = "Data Source= boalihack.database.windows.net;Integrated Security = true; Initial Catalog = boali_hack; uid=boali_admin;Password=hackathon@123;Trusted_Connection=False;Encrypt=True; ";

        public static List<TipoSolicitacao> TipoSolcitacaoListar()
        {
            string sql = "select id_tipo, descricao From tipo_solicitacao";
            var lista = new List<TipoSolicitacao>();
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
                                var t = new TipoSolicitacao
                                {
                                    IdTipo = Convert.ToInt32(dr["id_tipo"]),
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

        public static void TipoSolcitacaoReceber(int index)
        {
            using (var cn = new SqlConnection(conexao))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand(conexao, cn))
                {
                    try
                    {

                    }
                    catch (Exception ex)
                    {
                        string erro = "Erro: " + ex.ToString();
                    }
                }

            }
        }

        public static List<AreaSolicitacao> AreaSolcitacaoListar()
        {
            string sql = "select * From area_solicitacao";
            var lista = new List<AreaSolicitacao>();
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
                                var t = new AreaSolicitacao
                                {
                                    Id = Convert.ToInt32(dr["id_area"]),
                                    NomeArea = Convert.ToString(dr["nome_solicitacao"]),
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

        public static void AreaSolcitacaoReceber(int index)
        {
            using (var cn = new SqlConnection(conexao))
            {
                using (SqlCommand cmd = new SqlCommand(conexao, cn))
                {
                    try
                    {

                    }
                    catch (Exception ex)
                    {
                        string erro = "Erro: " + ex.ToString();
                    }
                }

            }
        }

        //public static List<Solicitacao> SolicitacaoAlimentacaonatNATH()
        //{
        //    string sqllida = "SELECT * FROM solicitacao WHERE usuario = @login";
        //    string sqlrecebida = "SELECT * FROM solicitacao WHERE usuario = @login or id_area = @login";
        //    var lista = new List<Solicitacao>();
        //    using (var cn = new SqlConnection(conexao))
        //    {
        //        cn.Open();
        //        string trocar = "teste";
        //        using (SqlCommand cmdlida = new SqlCommand(sqllida, cn))
        //        {
        //            cmdlida.Parameters.AddWithValue("@login", trocar);
        //            //cn.Open();
        //            var reader = cmdlida.ExecuteReader();
        //            if (reader != null)
        //            {
        //                using(var dr = cmdlida.ExecuteReader())
        //                {
        //                    while (dr.Read())
        //                    {
        //                        var t = new Solicitacao
        //                        {
        //                            IdTipo = Convert.ToInt32(dr["id_tipo"]),
        //                            Descricao = Convert.ToString(dr["descricao"]),
        //                            Usuario = Convert.ToString(dr["usuario"]),
        //                            DataHora = Convert.ToString(dr["data_hora"]),
        //                            Status = Convert.ToInt32(dr["status"]),
        //                            IdResposta = Convert.ToInt32(dr["id_resposta"]),
        //                            IdTicket = Convert.ToInt32(dr["id_ticket"]),
        //                            IdArea = Convert.ToInt32(dr["id_area"]),
        //                        };
        //                        lista.Add(t);
        //                    }
        //                }
        //            }
        //            else
        //            {

        //                using (SqlCommand cmdrecebida = new SqlCommand(sqlrecebida, cn))
        //                {
        //                    try
        //                    {
        //                        using (var dr = cmdrecebida.ExecuteReader())
        //                        {
        //                            while (dr.Read())
        //                            {
        //                                var t = new Solicitacao
        //                                {
        //                                    IdTipo = Convert.ToInt32(dr["id_tipo"]),
        //                                    Descricao = Convert.ToString(dr["descricao"]),
        //                                    Usuario = Convert.ToString(dr["usuario"]),
        //                                    DataHora = Convert.ToString(dr["data_hora"]),
        //                                    Status = Convert.ToInt32(dr["status"]),
        //                                    IdResposta = Convert.ToInt32(dr["id_resposta"]),
        //                                    IdTicket = Convert.ToInt32(dr["id_ticket"]),
        //                                    IdArea = Convert.ToInt32(dr["id_area"]),
        //                                };
        //                                lista.Add(t);
        //                            }
        //                        }
        //                    }
        //                    catch (Exception ex)
        //                    {
        //                        string erro = "Erro: " + ex.ToString();
        //                    }
        //                }
        //            }
        //        }
        //        //lista.GroupBy(u => u.IdTicket).Select(s => s.ToList()).ToList();
        //    }
        //    return lista;
        // }


        //public static List<Solicitacao> SolicitacaoAlimentacao()
        //{
        //    string sql = "select distinct(id_ticket), id_area, id_tipo, descricao, usuario, data_hora,	status,	id_resposta, id_alteracao from solicitacao where id_alteracao = '1' order by id_ticket desc";
        //    var lista = new List<Solicitacao>();
        //    using (var cn = new SqlConnection(conexao))
        //    {
        //        cn.Open();
        //        using (SqlCommand cmdlida = new SqlCommand(sqllida, cn))
        //        {
        //            cmdlida.Parameters.AddWithValue("@login", login);
        //            cn.Open();
        //            var reader = cmdlida.ExecuteReader();
        //            if (reader != null)
        //            {
        //                using(var dr = cmdlida.ExecuteReader())
        //                {
        //                    while (dr.Read())
        //                    {
        //                        var t = new Solicitacao
        //                        {
        //                            IdTipo = Convert.ToInt32(dr["id_tipo"]),
        //                            Descricao = Convert.ToString(dr["descricao"]),
        //                            Usuario = Convert.ToString(dr["usuario"]),
        //                            DataHora = Convert.ToString(dr["data_hora"]),
        //                            Status = Convert.ToInt32(dr["status"]),
        //                            IdResposta = Convert.ToInt32(dr["id_resposta"]),
        //                            IdTicket = Convert.ToInt32(dr["id_ticket"]),
        //                            IdArea = Convert.ToInt32(dr["id_area"]),
        //                        };
        //                        lista.Add(t);
        //                    }
        //                }
        //            }
        //            else
        //            {

        //                using (SqlCommand cmdrecebida = new SqlCommand(sqlrecebida, cn))
        //                {
        //                    try
        //                    {
        //                        using (var dr = cmdrecebida.ExecuteReader())
        //                        {
        //                            while (dr.Read())
        //                            {
        //                                var t = new Solicitacao
        //                                {
        //                                    IdTipo = Convert.ToInt32(dr["id_tipo"]),
        //                                    Descricao = Convert.ToString(dr["descricao"]),
        //                                    Usuario = Convert.ToString(dr["usuario"]),
        //                                    DataHora = Convert.ToString(dr["data_hora"]),
        //                                    Status = Convert.ToInt32(dr["status"]),
        //                                    IdResposta = Convert.ToInt32(dr["id_resposta"]),
        //                                    IdTicket = Convert.ToInt32(dr["id_ticket"]),
        //                                    IdArea = Convert.ToInt32(dr["id_area"]),
        //                                };
        //                                lista.Add(t);
        //                            }
        //                        }
        //                    }
        //                    catch (Exception ex)
        //                    {
        //                        string erro = "Erro: " + ex.ToString();
        //                    }
        //                }
        //            }
        //        }
        //        //lista.GroupBy(u => u.IdTicket).Select(s => s.ToList()).ToList();
        //    }
        //    return lista;
        //}

        //public static List<Solicitacao> SolicitacaoAlimentacao()
        //{
        //    string sql = "select * From solicitacao order by id_ticket desc";
        //    var lista = new List<Solicitacao>();
        //    using (var cn = new SqlConnection(conexao))
        //    {
        //        cn.Open();
        //        using (SqlCommand cmd = new SqlCommand(sql, cn))
        //        {
        //            try
        //            {
        //                using (var dr = cmd.ExecuteReader())
        //                {
        //                    while (dr.Read())
        //                    {
        //                        var t = new Solicitacao
        //                        {
        //                            IdTipo = Convert.ToInt32(dr["id_tipo"]),
        //                            IdArea = Convert.ToInt32(dr["id_Area"]),
        //                            IdSolicitacao = Convert.ToInt32(dr["id_ticket"]),
        //                            Descricao = Convert.ToString(dr["descricao"]),
        //                            Usuario = Convert.ToString(dr["usuario"]),
        //                            DataHora = Convert.ToString(dr["data_hora"]),
        //                            Status = Convert.ToInt32(dr["status"]),
        //                        };
        //                        lista.Add(t);
        //                    }
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                string erro = "Erro: " + ex.ToString();
        //            }
        //        }
        //    }
        //    return lista;
        //}

        public static List<Solicitacao> SolicitacaoAlimentacao(string login)
        {
            var lista = new List<Solicitacao>();

            if (VoltarTipo(login) == 1)
            {
                using (var cn = new SqlConnection(conexao))
                {
                    cn.Open();
                    string sql = "select * From solicitacao order by id_ticket desc";
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        try
                        {
                            cmd.Parameters.AddWithValue("@idlogin", login);
                            using (var dr = cmd.ExecuteReader())
                            {
                                while (dr.Read())
                                {
                                    var t = new Solicitacao
                                    {
                                        IdTipo = Convert.ToInt32(dr["id_tipo"]),
                                        IdArea = Convert.ToInt32(dr["id_Area"]),
                                        IdSolicitacao = Convert.ToInt32(dr["id_ticket"]),
                                        Descricao = Convert.ToString(dr["descricao"]),
                                        Usuario = Convert.ToString(dr["usuario"]),
                                        DataHora = Convert.ToString(dr["data_hora"]),
                                        Status = Convert.ToInt32(dr["status"]),
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
            }
            if (VoltarTipo(login) == 2)
            {
                using (var cn = new SqlConnection(conexao))
                {
                    cn.Open();
                    string sql = "select * From solicitacao where id_area = @idlogin order by id_ticket desc";
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        try
                        {
                            cmd.Parameters.AddWithValue("@idlogin", VoltarIdArea(login));
                            using (var dr = cmd.ExecuteReader())
                            {
                                while (dr.Read())
                                {
                                    var t = new Solicitacao
                                    {
                                        IdTipo = Convert.ToInt32(dr["id_tipo"]),
                                        IdArea = Convert.ToInt32(dr["id_Area"]),
                                        IdSolicitacao = Convert.ToInt32(dr["id_ticket"]),
                                        Descricao = Convert.ToString(dr["descricao"]),
                                        Usuario = Convert.ToString(dr["usuario"]),
                                        DataHora = Convert.ToString(dr["data_hora"]),
                                        Status = Convert.ToInt32(dr["status"]),
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
            }
            if (VoltarTipo(login) == 3)
            {
                using (var cn = new SqlConnection(conexao))
                {
                    cn.Open();
                    string sql = "select * From solicitacao where usuario = @idlogin order by id_ticket desc";
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        try
                        {
                            cmd.Parameters.AddWithValue("@idlogin", login);
                            using (var dr = cmd.ExecuteReader())
                            {
                                while (dr.Read())
                                {
                                    var t = new Solicitacao
                                    {
                                        IdTipo = Convert.ToInt32(dr["id_tipo"]),
                                        IdArea = Convert.ToInt32(dr["id_Area"]),
                                        IdSolicitacao = Convert.ToInt32(dr["id_ticket"]),
                                        Descricao = Convert.ToString(dr["descricao"]),
                                        Usuario = Convert.ToString(dr["usuario"]),
                                        DataHora = Convert.ToString(dr["data_hora"]),
                                        Status = Convert.ToInt32(dr["status"]),
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
            }

            return lista;
        }
        public static List<Solicitacao> ChamadaData()
        {
            string sql = "select id_ticket, id_alteracao, data_hora From solicitacao";
            var lista = new List<Solicitacao>();
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
                                var t = new Solicitacao
                                {
                                    IdAlteracao= Convert.ToInt32(dr["id_area"]),
                                    DataHora = Convert.ToString(dr["data_hora"]),
                                    IdTicket = Convert.ToInt32(dr["id_ticket"]),
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

        public static int VoltarTipo(string login)
        {
            string sql = "select id_tipo From perfil Where id_login = @idlogin";
            int idtipo;
            using (var cn = new SqlConnection(conexao))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                        cmd.Parameters.AddWithValue("@idlogin", login);
                        var dr = cmd.ExecuteReader();
                        dr.Read();
                    idtipo = Convert.ToInt32(dr["id_tipo"]);
                }
            }
            return idtipo;
        }
        public static void SolicitacaoIncluir(Solicitacao solicitacao)
        {
            string sql = "INSERT INTO solicitacao(id_area, id_tipo, descricao, usuario, data_hora, status) VALUES(@id_area, @id_tipo, @descricao, @usuario, @data_hora, @status)";
            using (var cn = new SqlConnection(conexao))
            {
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@id_area", solicitacao.IdArea);
                        cmd.Parameters.AddWithValue("@id_tipo", solicitacao.IdSolicitacao);
                        cmd.Parameters.AddWithValue("@descricao", solicitacao.Descricao);
                        cmd.Parameters.AddWithValue("@usuario", solicitacao.Usuario);
                        cmd.Parameters.AddWithValue("@status", "1");
                        cmd.Parameters.AddWithValue("@data_hora", DateTime.Now.ToString());
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

        public bool contemLetras(string texto)
        {
            if (texto.Where(c => char.IsLetter(c)).Count() > 0)
                return true;
            else
                return false;
        }

        public bool contemNumeros(string texto)
        {
            if (texto.Where(c => char.IsNumber(c)).Count() > 0)
                return true;
            else
                return false;
        }

        public void verifica(string texto)
        {
            if (this.contemLetras(texto) && this.contemNumeros(texto))
            {
                //Contem Letras e Números
            }
            else if (this.contemLetras(texto))
            {
                //Contem somente letras
            }
            else if (this.contemNumeros(texto))
            {
                //Contem somente numeros
            }
        }

        public static int VoltarIdArea(string login)
        {
            string sql = "select id_area From area_solicitacao Where nome_solicitacao = @idlogin";
            int idarea;
            using (var cn = new SqlConnection(conexao))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@idlogin", login);
                    var dr = cmd.ExecuteReader();
                    dr.Read();
                    idarea = Convert.ToInt32(dr["id_area"]);
                }
            }
            return idarea;
        }

        //public static void ImportarArquivo(FileUpload imagemFileUpload)
        //{
        //    if (imagemFileUpload.HasFile)
        //    {
        //        string pastaGravarEmVirtual = "\Content\assets\images";
        //        string pastaGravarEmFisico = MapPath(pastaGravarEmVirtual);
        //        string arquivo = Path.GetFileName(imagemFileUpload.FileName);
        //        string caminhoCompletoFisco =
        //        Path.Combine(pastaGravarEmFisico, arquivo);
        //        string caminhoCompletoVirtual =
        //       string.Format("{0}/{1}",pastaGravarEmVirtual,arquivo );
        //        imagemFileUpload.SaveAs(caminhoCompletoFisco);
        //        fotoImage.ImageUrl = caminhoCompletoVirtual;
        //        mensagemLabel.Text = "Arquivo gravado com sucesso";
        //    }
        //    else
        //    {
        //        mensagemLabel.Text = "Nenhum arquivo enviado.";
        //    }
        //}

        public static List<Solicitacao> FiltrarArea(int area)
        {
            var lista = new List<Solicitacao>();
            {
                using (var cn = new SqlConnection(conexao))
                {
                    cn.Open();
                    string sql = "select * From solicitacao where id_Area = @id_Area order by id_ticket desc";
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        try
                        {
                            cmd.Parameters.AddWithValue("@id_Area", area);
                            using (var dr = cmd.ExecuteReader())
                            {
                                while (dr.Read())
                                {
                                    var t = new Solicitacao
                                    {
                                        IdTipo = Convert.ToInt32(dr["id_tipo"]),
                                        IdArea = Convert.ToInt32(dr["id_Area"]),
                                        IdSolicitacao = Convert.ToInt32(dr["id_ticket"]),
                                        Descricao = Convert.ToString(dr["descricao"]),
                                        Usuario = Convert.ToString(dr["usuario"]),
                                        DataHora = Convert.ToString(dr["data_hora"]),
                                        Status = Convert.ToInt32(dr["status"]),
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
            }
            return lista;
        }

        public static List<Solicitacao> FiltrarTipo(int tipo)
        {
            var lista = new List<Solicitacao>();
            {
                using (var cn = new SqlConnection(conexao))
                {
                    cn.Open();
                    string sql = "select * From solicitacao where id_tipo = @id_tipo order by id_ticket desc";
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        try
                        {
                            cmd.Parameters.AddWithValue("@id_tipo", tipo);
                            using (var dr = cmd.ExecuteReader())
                            {
                                while (dr.Read())
                                {
                                    var t = new Solicitacao
                                    {
                                        IdTipo = Convert.ToInt32(dr["id_tipo"]),
                                        IdArea = Convert.ToInt32(dr["id_Area"]),
                                        IdSolicitacao = Convert.ToInt32(dr["id_ticket"]),
                                        Descricao = Convert.ToString(dr["descricao"]),
                                        Usuario = Convert.ToString(dr["usuario"]),
                                        DataHora = Convert.ToString(dr["data_hora"]),
                                        Status = Convert.ToInt32(dr["status"]),
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
            }

            return lista;
        }

        public static List<Solicitacao> FiltrarDataAtual(DateTime ultimadata)
        {
            var lista = new List<Solicitacao>();
            {
                using (var cn = new SqlConnection(conexao))
                {
                    cn.Open();
                    string sql = "select * From solicitacao where data = @data order by id_ticket desc";
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        try
                        {
                            cmd.Parameters.AddWithValue("@data", ultimadata);
                            using (var dr = cmd.ExecuteReader())
                            {
                                while (dr.Read())
                                {
                                    var t = new Solicitacao
                                    {
                                        IdTipo = Convert.ToInt32(dr["id_tipo"]),
                                        IdArea = Convert.ToInt32(dr["id_Area"]),
                                        IdSolicitacao = Convert.ToInt32(dr["id_ticket"]),
                                        Descricao = Convert.ToString(dr["descricao"]),
                                        Usuario = Convert.ToString(dr["usuario"]),
                                        DataHora = Convert.ToString(dr["data_hora"]),
                                        Status = Convert.ToInt32(dr["status"]),
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
            }

            return lista;
        }



    }
}