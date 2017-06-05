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

namespace Client
{
    public partial class MenuLogin : Form
    {

        private string username;
        private string password;
        private string passwordHash;
        private const int PORT = 9999;
        private static ProtocolSI protocolSI;

        public MenuLogin()
        {
            InitializeComponent();

            groupBoxFicheiros.Enabled = false;
            
        }

        private void buttonRegistar_Click(object sender, EventArgs e)
        {
            //Criação da hash da password.
            username = textBoxUsername.Text;
            password = textBoxPassword.Text;

            MD5 md5 = MD5.Create();
            byte[] pass = Encoding.UTF8.GetBytes(password);
            byte[] passwordHash = md5.ComputeHash(pass);

            //Passar os dados do utilizador para o server.
            protocolSI = new ProtocolSI();


            TcpClient tcpClient = new TcpClient();
            NetworkStream networkStream = null;
            

            try
            {
                tcpClient = new TcpClient();
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Loopback, PORT);
                tcpClient.Connect(endPoint);
                networkStream = tcpClient.GetStream();
                networkStream = tcpClient.GetStream();

                byte[] byteUsername = protocolSI.Make(ProtocolSICmdType.NORMAL, username);
                networkStream.Write(byteUsername, 0, byteUsername.Length);

                byte[] bytePasswordHash = protocolSI.Make(ProtocolSICmdType.NORMAL, passwordHash);
                networkStream.Write(bytePasswordHash, 0, bytePasswordHash.Length);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
