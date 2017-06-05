using EI.SI;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Program
    {
        private const int PORT = 9999;
        private static ProtocolSI protocolsi;
        private static RSACryptoServiceProvider rsa;


        static void Main(string[] args)
        {
            protocolsi = new ProtocolSI();
            TcpListener tcpListener = null;
            TcpClient tcpClient = null;
            NetworkStream networkStream = null;

            try
            {
                rsa = new RSACryptoServiceProvider();

                string publicKey = rsa.ToXmlString(false);

                File.WriteAllText("publickey.txt", publicKey);
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Loopback, PORT);
                tcpListener = new TcpListener(endPoint);

                Console.WriteLine("Starting Server...");

                tcpListener.Start();
                Console.WriteLine("Waiting for connections...");

                tcpClient = tcpListener.AcceptTcpClient();
                Console.WriteLine("Client found.");

                networkStream = tcpClient.GetStream();

                byte[] packet = protocolsi.Make(ProtocolSICmdType.PUBLIC_KEY, publicKey);
                networkStream.Write(packet, 0, packet.Length);

                Console.WriteLine("Chave Pública Enviada");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            finally
            {
                if (networkStream != null)
                {
                    networkStream.Close();
                }

                if (tcpClient != null)
                {
                    tcpClient.Close();
                }
            }

            Console.ReadKey();

        }

        /*public static string genKeys()
        {
            rsa = new RSACryptoServiceProvider();
            //Criação de chaves privada/publica.
            string publicKey = rsa.ToXmlString(false);
            string privateKey = rsa.ToXmlString(true);

            //Guardar as chaves em ficheiros.
            File.WriteAllText("publicKey.txt", publicKey);
            File.WriteAllText("publicPrivateKey.txt", privateKey);

            //Console.WriteLine(publicKey);

            return publicKey;
        }

        private bool VerifyLogin(string username, string passwordhash)
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

                // Declaração dos parâmetros do comando SQL
                SqlParameter param = new SqlParameter("@username", username);

                // Introduzir valor ao parâmentro registado no comando SQL
                cmd.Parameters.Add(param);

                // Associar ligação à Base de Dados ao comando a ser executado
                cmd.Connection = conn;

                // Executar comando SQL
                SqlDataReader reader = cmd.ExecuteReader();

                if (!reader.HasRows)
                {
                    throw new Exception("Error while trying to access an user");
                }

                // Ler resultado da pesquisa
                reader.Read();



                return true;


            }
            catch (Exception)
            {

                Console.WriteLine("An error occurred!");
                return false;
            }
        }

        private void Register(string username, byte[] passwordHash)
        {
            SqlConnection conn = null;
            try
            {
                // Configurar ligação à Base de Dados
                conn = new SqlConnection();
                conn.ConnectionString = String.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\DIOGO\Documents\Visual Studio 2015\Projects\TopicosSegurancaFicha8Solution\FichaPratica8_Base\Database.mdf';Integrated Security=True");

                // Abrir ligação à Base de Dados
                conn.Open();

                // Declaração dos parâmetros do comando SQL
                SqlParameter paramUsername = new SqlParameter("@username", username);
                SqlParameter paramPassHash = new SqlParameter("@passwordHash", passwordHash);

                // Declaração do comando SQL
                String sql = "INSERT INTO Users (Username, PasswordHash) VALUES (@username,@passwordHash)";

                // Prepara comando SQL para ser executado na Base de Dados
                SqlCommand cmd = new SqlCommand(sql, conn);

                // Introduzir valores aos parâmentros registados no comando SQL
                cmd.Parameters.Add(paramUsername);
                cmd.Parameters.Add(paramPassHash);

                // Executar comando SQL
                int lines = cmd.ExecuteNonQuery();

                // Fechar ligação
                conn.Close();
                if (lines == 0)
                {
                    // Se forem devolvidas 0 linhas alteradas então o não foi executado com sucesso
                    throw new Exception("Error while inserting an user");
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error while inserting an user:" + e.Message);
            }
        }*/

    }
}
