using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        private static RSACryptoServiceProvider rsa;

        static void Main(string[] args)
        {
            rsa = new RSACryptoServiceProvider();
            //Criação de chaves privada/publica.
            string publicKey = rsa.ToXmlString(false);
            string privateKey = rsa.ToXmlString(true);

            //Guardar as chaves em ficheiros.
            File.WriteAllText("publicKey.txt", publicKey);
            File.WriteAllText("publicPrivateKey.txt", privateKey);

            
        }

        private bool VerifyLogin()
        {
            //Conecção à base de dados.
            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = String.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alexa\Source\Repos\ProjectTSSolution\Server\Users.mdf;Integrated Security=True");

                //Abrir ligação.
                conn.Open();

                //Comando SQL.
                String sql = "SELECT * FROM Users WHERE username = @username";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;

                return true;


            }
            catch (Exception)
            {

                Console.WriteLine("An error occurred!");
                return false;
            }
        }
    }
}
