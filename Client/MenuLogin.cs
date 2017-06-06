using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Net;
using System.Net.Sockets;
using EI.SI;
using System.IO;

namespace Client
{
    public partial class MenuLogin : Form
    {
        private string username;
        private string password;
        private const int PORT = 9999;
        private static ProtocolSI protocolSI;
        private static RSACryptoServiceProvider rsa;
        TcpClient tcpClient = new TcpClient();
        NetworkStream networkStream = null;

        AesCryptoServiceProvider aes;

        private byte[] key;
        private byte[] iv;

        public MenuLogin()
        {
            InitializeComponent();

            //groupBoxFicheiros.Enabled = false;
            buttonLogout.Enabled = false;

            protocolSI = new ProtocolSI();
            rsa = new RSACryptoServiceProvider();
            aes = new AesCryptoServiceProvider();



        }

        private void buttonRegistar_Click(object sender, EventArgs e)
        {
            /*rsa = new RSACryptoServiceProvider();
            TcpClient tcpClient = new TcpClient();
            NetworkStream networkStream = null;*/

            try
            {
                tcpClient = new TcpClient();
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Loopback, PORT);

                tcpClient.Connect(endPoint);
                networkStream = tcpClient.GetStream();

                username = textBoxUsername.Text;
                password = textBoxPassword.Text;

                byte[] usernamebyte = Encoding.UTF8.GetBytes(username);
                byte[] usernameEnc = rsa.Encrypt(usernamebyte, true);
                networkStream.Write(usernameEnc, 0, usernameEnc.Length);

                byte[] passbyte = Encoding.UTF8.GetBytes(password);
                byte[] passwordEnc = rsa.Encrypt(passbyte, true);
                networkStream.Write(passwordEnc, 0, passwordEnc.Length);

            }
            catch (Exception)
            {
                throw;
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            /*rsa = new RSACryptoServiceProvider();
            TcpClient tcpClient = new TcpClient();
            NetworkStream networkStream = null;*/

            try
            {
                tcpClient = new TcpClient();
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Loopback, PORT);

                tcpClient.Connect(endPoint);
                networkStream = tcpClient.GetStream();

                username = textBoxUsername.Text;
                password = textBoxPassword.Text;

                byte[] usernamebyte = Encoding.UTF8.GetBytes(username);
                byte[] usernameEnc = rsa.Encrypt(usernamebyte, true);
                networkStream.Write(usernameEnc, 0, usernameEnc.Length);

                byte[] passbyte = Encoding.UTF8.GetBytes(password);
                byte[] passwordEnc = rsa.Encrypt(passbyte, true);
                networkStream.Write(passwordEnc, 0, passwordEnc.Length);

            }
            catch (Exception)
            {
                throw;
            }
        }

        private void buttonGenerateKey_Click(object sender, EventArgs e)
        {
            groupBoxFicheiros.Enabled = true;

            /*rsa = new RSACryptoServiceProvider();
            TcpClient tcpClient = new TcpClient();
            NetworkStream networkStream = null;*/

            try
            {
                tcpClient = new TcpClient();
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Loopback, PORT);

                tcpClient.Connect(endPoint);
                networkStream = tcpClient.GetStream();

                networkStream.Read(protocolSI.Buffer, 0, protocolSI.Buffer.Length);

                if (protocolSI.GetCmdType() == ProtocolSICmdType.PUBLIC_KEY)
                {
                    textBoxKey.Text = protocolSI.GetStringFromData();
                }

                byte[] dados = Encoding.UTF8.GetBytes("SymKeydesenrrasque");
                byte[] dadosEnc = rsa.Encrypt(dados, true);

                networkStream.Write(dadosEnc, 0, dadosEnc.Length);

                /*using (AesCryptoServiceProvider aes = new AesCryptoServiceProvider())
                {
                    string publicKey = textBoxKey.Text;

                    this.key = aes.Key;
                    //this.iv = aes.IV;

                    byte[] encKey;

                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            cs.Write(key, 0, key.Length);
                        }

                        encKey = ms.ToArray();
                    }

                    

                }*/

            }

            catch (Exception)
            {
                throw;
            }

            /*finally
            {
                if (networkStream != null)
                {
                    networkStream.Close();
                }

                if (tcpClient != null)
                {
                    tcpClient.Close();
                }
            }*/
        }

        private void buttonPedirFicheiro_Click(object sender, EventArgs e)
        {
            
        }
    }
}
