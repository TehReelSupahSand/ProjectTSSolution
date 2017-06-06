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
        private static ProtocolSI protocolSI;
        private static RSACryptoServiceProvider rsa;


        static void Main(string[] args)
        {
            protocolSI = new ProtocolSI();
            TcpListener tcpListener = null;
            TcpClient tcpClient = null;
            NetworkStream networkStream = null;

            byte[] symKey1;
            string symKey2;

            try
            {
                rsa = new RSACryptoServiceProvider();

                string publicKey = rsa.ToXmlString(false);
                string privatepublicKey = rsa.ToXmlString(true);

                File.WriteAllText("publicprivateKey.txt", privatepublicKey);

                IPEndPoint endPoint = new IPEndPoint(IPAddress.Loopback, PORT);
                tcpListener = new TcpListener(endPoint);

                Console.WriteLine("Starting Server...");

                tcpListener.Start();
                Console.WriteLine("Waiting for connections...");

                tcpClient = tcpListener.AcceptTcpClient();
                Console.WriteLine("Client found.");

                networkStream = tcpClient.GetStream();

                byte[] packet = protocolSI.Make(ProtocolSICmdType.PUBLIC_KEY, publicKey);
                networkStream.Write(packet, 0, packet.Length);

                Console.WriteLine("Chave Pública Enviada");

                networkStream.Read(protocolSI.Buffer,0,protocolSI.Buffer.Length);
                symKey2 = protocolSI.GetStringFromData();

                //symKey2 = Convert.ToBase64String(symKey1);

                byte[] dados = Convert.FromBase64String(symKey2);
                byte[] dadosDec = rsa.Decrypt(dados, true);

                Console.WriteLine(symKey2);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            Console.ReadKey();
        }

        private void register()
        {

            protocolSI = new ProtocolSI();
            TcpListener tcpListener = null;
            TcpClient tcpClient = null;
            NetworkStream networkStream = null;

            try
            {
                //Obter username
                networkStream.Read(protocolSI.Buffer, 0, protocolSI.Buffer.Length);
                string usernameEnc = protocolSI.GetStringFromData();
                byte[] usernamebyte = Convert.FromBase64String(usernameEnc);
                byte[] usernameDec = rsa.Decrypt(usernamebyte, true);
                string username = Encoding.UTF8.GetString(usernameDec);

                //Obter password
                networkStream.Read(protocolSI.Buffer, 0, protocolSI.Buffer.Length);
                string passwordEnc = protocolSI.GetStringFromData();
                byte[] passwordbyte = Convert.FromBase64String(usernameEnc);
                byte[] passDec = rsa.Decrypt(passwordbyte, true);
                string password = Encoding.UTF8.GetString(passDec);

                Console.WriteLine(username);
                Console.WriteLine(password);

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
        }


        static public string[] pedirLista()
        {
            string path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            string pasta = Path.GetFileName(path + "/Material_Projeto_Pratico-20170605");

            string[] ficheiros = Directory.GetFiles(pasta).Select(Path.GetFileName).ToArray();

            //encriptar

            return ficheiros;
        }

        static public string ficheiro1()
        {
            string path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            string imagem1 = Path.GetFileName(path + "/Material_Projeto_Pratico-20170605" + "estg_logo.jpg");

            return imagem1;
        }

        static public string ficheiro2()
        {
            string path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            string imagem2 = Path.GetFileName(path + "/Material_Projeto_Pratico-20170605" + "ipl_logo_gray.png");

            //encryptar

            return imagem2;
        }

        static public string ficheiro3()
        {
            string path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            string imagem3 = Path.GetFileName(path + "/Material_Projeto_Pratico-20170605" + "ipl_logo_white.png");

            //encryptar

            return imagem3;
        }

        /*private bool VerifyLogin(string username, string passwordhash)
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
