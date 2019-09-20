using System;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Net.Mail;

namespace CommuniCareProject.Classes
{
    public class PerfilBd
    {
        private static string conexao = "Data Source= boalihack.database.windows.net;Integrated Security = true; Initial Catalog = boali_hack; uid=boali_admin;Password=hackathon@123;Trusted_Connection=False;Encrypt=True; ";

        //public void PerfilIncluir(Perfil perfil)
        //{
        //    string sql = "INSERT INTO tb_perfil(descricao, cria_usuario) VALUES(@descricao, @cria)";
        //    using (var cn = new SqlConnection(conexao))
        //    {
        //        using (SqlCommand cmd = new SqlCommand(sql, cn))
        //        {
        //            try
        //            {
        //                cmd.Parameters.AddWithValue("@descricao", perfil.Descricao);
        //                cmd.Parameters.AddWithValue("@cria", perfil.CriarUsuario);
        //                cn.Open();
        //                cmd.ExecuteNonQuery();
        //            }
        //            catch (Exception ex)
        //            {
        //                string erro = "Erro: " + ex.ToString();
        //            }
        //        }
        //    }
        //}
        public static Boolean LoginValidacao(string login, string senha)
        {
            Boolean loginpassou = false;
            string sql = "SELECT id_perfil, * FROM perfil WHERE id_login = @login AND senha=@senha";
            using (var cn = new SqlConnection(conexao))
            {
                cn.Open();
                
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@login", login);
                        cmd.Parameters.AddWithValue("@senha", senha);   
                        var reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                loginpassou = true;
                            }
                        }
                        else
                        {
                            loginpassou = false;
                        }

                    }
                    catch (Exception ex)
                    {
                        string erro = "Erro: " + ex.ToString();
                    }
                }
            }
            return loginpassou;
        }

        private static DataTable ExecutaSelect()
        {
            throw new NotImplementedException();
        }

        public static int GetIdPerfil(string login)
        {
            int IdPerfil;
            string sql = "SELECT id_perfil, * FROM perfil WHERE id_login = @login";

            using (var cn = new SqlConnection(conexao))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@idlogin", login);
                    var dr = cmd.ExecuteReader();
                    dr.Read();
                    IdPerfil = Convert.ToInt32(dr["id_perfil"]);
                }
            }
            return IdPerfil;
        }

        public static string GetEmail(string login)
        {
            int Email;
            string sql = "SELECT email FROM usuario WHERE cnpj = @login";

            using (var cn = new SqlConnection(conexao))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@idlogin", login);
                    var dr = cmd.ExecuteReader();
                    dr.Read();
                    Email = Convert.ToInt32(dr["email"]);
                }
            }
            return Email;
        }

        // SetCriptografia(GetIdPerfil(login))
        public static string SetCriptografia(int id)
        {
            string iddatetime, criptografia;
            iddatetime = id.ToString() + DateTime.Now.ToString();
            criptografia = Criptografar(iddatetime);
            return criptografia;
        }

        public static string Criptografar(string crip)
        {
            string palavra, encrypt = "";
            int ASCII = 0, ASCIIC = 0;

            palavra = crip;

            for (int i = 0; i < palavra.Length; i++)
            {
                ASCII = Convert.ToInt32(palavra[i]);
                if (ASCII == 32)
                {
                    //  .
                    ASCIIC = ASCII + 9;
                    encrypt += Char.ConvertFromUtf32(ASCIIC);
                } // +9
                if (ASCII == 33)
                {
                    //  .
                    ASCIIC = ASCII + 9;
                    encrypt += Char.ConvertFromUtf32(ASCIIC);
                } // +9
                if (ASCII == 34)
                {
                    //  .
                    ASCIIC = ASCII + 9;
                    encrypt += Char.ConvertFromUtf32(ASCIIC);
                } // +9
                if (ASCII == 35)
                {
                    //  .
                    ASCIIC = ASCII + 9;
                    encrypt += Char.ConvertFromUtf32(ASCIIC);
                } // +9
                if (ASCII == 36)
                {
                    //  .
                    ASCIIC = ASCII + 9;
                    encrypt += Char.ConvertFromUtf32(ASCIIC);
                } // +9
                if (ASCII == 37)
                {
                    //  .
                    ASCIIC = ASCII + 9;
                    encrypt += Char.ConvertFromUtf32(ASCIIC);
                } // +9
                if (ASCII == 38)
                {
                    //  .
                    ASCIIC = ASCII + 9;
                    encrypt += Char.ConvertFromUtf32(ASCIIC);
                } // +9
                if (ASCII == 39)
                {
                    //  .
                    ASCIIC = ASCII + 9;
                    encrypt += Char.ConvertFromUtf32(ASCIIC);
                } // +9
                if (ASCII == 40)
                {
                    //  .
                    ASCIIC = ASCII + 9;
                    encrypt += Char.ConvertFromUtf32(ASCIIC);
                } // +9
                if (ASCII == 41)
                {
                    //  .
                    ASCIIC = ASCII + 9;
                    encrypt += Char.ConvertFromUtf32(ASCIIC);
                } // +9
                if (ASCII == 42)
                {
                    //  .
                    ASCIIC = ASCII + 9;
                    encrypt += Char.ConvertFromUtf32(ASCIIC);
                } // +9
                if (ASCII == 43)
                {
                    //  .
                    ASCIIC = ASCII + 9;
                    encrypt += Char.ConvertFromUtf32(ASCIIC);
                } // +9
                if (ASCII == 44)
                {
                    //  .
                    ASCIIC = ASCII + 9;
                    encrypt += Char.ConvertFromUtf32(ASCIIC);
                } // +9
                if (ASCII == 45)
                {
                    //  .
                    ASCIIC = ASCII + 9;
                    encrypt += Char.ConvertFromUtf32(ASCIIC);
                } // +9
                if (ASCII == 46)
                {
                    //  .
                    ASCIIC = ASCII + 9;
                    encrypt += Char.ConvertFromUtf32(ASCIIC);
                } // +9
                if (ASCII == 47)
                {
                    //  .
                    ASCIIC = ASCII + 9;
                    encrypt += Char.ConvertFromUtf32(ASCIIC);
                } // +9
                if (ASCII >= 48 && ASCII <= 64)
                {
                    // 0, 1 ,2, 3, 4, 5, 6, 7, 8, 9, :, ;, <, = , >, ?, @.
                    ASCIIC = ASCII + 51;
                    encrypt += Char.ConvertFromUtf32(ASCIIC);
                } // + 51                     
                if (ASCII >= 65 && ASCII <= 76)
                {
                    // A, B ,C , D, E, F, G, H, I, J, K, L.
                    ASCIIC = ASCII + 2;
                    encrypt += Char.ConvertFromUtf32(ASCIIC);
                } // + 2
                if (ASCII >= 77 && ASCII <= 90)
                {
                    // M, N, O, P, Q, R, S, T, U, V, X, Y, Z.
                    ASCIIC = ASCII + 8;
                    encrypt += Char.ConvertFromUtf32(ASCIIC);
                } // +8
                if (ASCII >= 91 && ASCII <= 96)
                {
                    // [, \, ], ^, _,  .
                    ASCIIC = ASCII - 12;
                    encrypt += Char.ConvertFromUtf32(ASCIIC);
                } // -12
                if (ASCII >= 97 && ASCII <= 107)
                {
                    //a, b, c, d, e, f, g, h, i, j, k.
                    ASCIIC = ASCII + 19;
                    encrypt += Char.ConvertFromUtf32(ASCIIC);
                } // +19
                if (ASCII >= 108 && ASCII <= 117)
                {
                    // l, m, n, o, p, q, r, s, t, u.
                    ASCIIC = ASCII - 51;
                    encrypt += Char.ConvertFromUtf32(ASCIIC);
                } // -51
                if (ASCII >= 118 && ASCII <= 126)
                {
                    // v, x, y, z, {.
                    ASCIIC = ASCII - 86;
                    encrypt += Char.ConvertFromUtf32(ASCIIC);
                } // -86
            }

            return crip = encrypt;
        }

        public static string Descriptografar(string crip)
        {
            string palavra, encrypt = "";
            int ASCII = 0, ASCIIC = 0;

            palavra = crip;

            for (int i = 0; i < palavra.Length; i++)

            {
                ASCII = Convert.ToInt32(palavra[i]);
                if (ASCII == 41)
                {
                    ASCIIC = ASCII - 9;
                    encrypt += Char.ConvertFromUtf32(ASCIIC);
                } // -9 
                if (ASCII == 42)
                {
                    ASCIIC = ASCII - 9;
                    encrypt += Char.ConvertFromUtf32(ASCIIC);
                } // -9 
                if (ASCII == 43)
                {
                    ASCIIC = ASCII - 9;
                    encrypt += Char.ConvertFromUtf32(ASCIIC);
                } // -9 
                if (ASCII == 44)
                {
                    ASCIIC = ASCII - 9;
                    encrypt += Char.ConvertFromUtf32(ASCIIC);
                } // -9 
                if (ASCII == 45)
                {
                    ASCIIC = ASCII - 9;
                    encrypt += Char.ConvertFromUtf32(ASCIIC);
                } // -9 
                if (ASCII == 46)
                {
                    ASCIIC = ASCII - 9;
                    encrypt += Char.ConvertFromUtf32(ASCIIC);
                } // -9 
                if (ASCII == 47)
                {
                    ASCIIC = ASCII - 9;
                    encrypt += Char.ConvertFromUtf32(ASCIIC);
                } // -9 
                if (ASCII == 48)
                {
                    ASCIIC = ASCII - 9;
                    encrypt += Char.ConvertFromUtf32(ASCIIC);
                } // -9 
                if (ASCII == 49)
                {
                    ASCIIC = ASCII - 9;
                    encrypt += Char.ConvertFromUtf32(ASCIIC);
                } // -9
                if (ASCII == 50)
                {
                    ASCIIC = ASCII - 9;
                    encrypt += Char.ConvertFromUtf32(ASCIIC);
                } // -9 
                if (ASCII == 51)
                {
                    ASCIIC = ASCII - 9;
                    encrypt += Char.ConvertFromUtf32(ASCIIC);
                } // -9 
                if (ASCII == 52)
                {
                    ASCIIC = ASCII - 9;
                    encrypt += Char.ConvertFromUtf32(ASCIIC);
                } // -9 
                if (ASCII == 53)
                {
                    ASCIIC = ASCII - 9;
                    encrypt += Char.ConvertFromUtf32(ASCIIC);
                } // -9 
                if (ASCII == 54)
                {
                    ASCIIC = ASCII - 9;
                    encrypt += Char.ConvertFromUtf32(ASCIIC);
                } // -9 
                if (ASCII == 55)
                {
                    ASCIIC = ASCII - 9;
                    encrypt += Char.ConvertFromUtf32(ASCIIC);
                } // -9 
                if (ASCII == 56)
                {
                    ASCIIC = ASCII - 9;
                    encrypt += Char.ConvertFromUtf32(ASCIIC);
                } // -9 
                if (ASCII >= 99 && ASCII <= 115)
                {
                    ASCIIC = ASCII - 51;
                    encrypt += Char.ConvertFromUtf32(ASCIIC);
                } // -51 0, 1 ,2, 3, 4, 5, 6, 7, 8, 9, :, ;, <, = , >, ?, @. 17
                if (ASCII >= 67 && ASCII <= 78)
                {
                    ASCIIC = ASCII - 2;
                    encrypt += Char.ConvertFromUtf32(ASCIIC);
                } // -2 A, B ,C , D, E, F, G, H, I, J, K, L. 12
                if (ASCII >= 85 && ASCII <= 98)
                {
                    ASCIIC = ASCII - 8;
                    encrypt += Char.ConvertFromUtf32(ASCIIC);
                } // -8 M, N, O, P, Q, R, S, T, U, V, X, Y, Z. 13
                if (ASCII >= 79 && ASCII <= 84)
                {
                    ASCIIC = ASCII + 12;
                    encrypt += Char.ConvertFromUtf32(ASCIIC);
                } // +12 [, \, ], ^, _,  . 6
                if (ASCII >= 116 && ASCII <= 126)
                {
                    ASCIIC = ASCII - 19;
                    encrypt += Char.ConvertFromUtf32(ASCIIC);
                } // -19 a, b, c, d, e, f, g, h, i, j, k. 11
                if (ASCII >= 57 && ASCII <= 66)
                {
                    ASCIIC = ASCII + 51;
                    encrypt += Char.ConvertFromUtf32(ASCIIC);
                } // +51 l, m, n, o, p, q, r, s, t, u. 10
                if (ASCII >= 32 && ASCII <= 40)
                {
                    ASCIIC = ASCII + 86;
                    encrypt += Char.ConvertFromUtf32(ASCIIC);
                } // +86 v, x, y, z, {. 5
            }

            return crip = encrypt;
        }

        public static Boolean ValidarCrip(string cript)
        {
            bool validado;
            string dobanco = "Tenho que pegar isso do bancoaaa";
            if(Descriptografar(dobanco) == cript)
            {
                validado = true;
            }
            else
            {
                validado = false;
            }
            return validado;
        }

        public static void MandarEmail(string login)
        {
            MailMessage email = new MailMessage();
            email.From = new MailAddress("emaildaempresa@gmail.com");
            email.To.Add(new MailAddress(GetEmail(login)));
            email.Subject = "Recuperação de senha";
            string body = "Segue o token para trocar a senha " + SetCriptografia(GetIdPerfil(login)) + "\t \t \t Obrigado";
            email.Body = body;
            email.IsBodyHtml = true;
            email.Priority = MailPriority.Normal;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Send(email);
            //https://www.hostinger.com.br/tutoriais/aprenda-a-utilizar-o-smtp-google/
        }



    }
}