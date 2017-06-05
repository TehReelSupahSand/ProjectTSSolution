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

        public MenuLogin()
        {
            InitializeComponent();

            //groupBoxFicheiros.Enabled = false;
            buttonLogout.Enabled = false;

            protocolSI = new ProtocolSI();
            rsa = new RSACryptoServiceProvider();
            

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
