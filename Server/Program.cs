using System;
using System.Collections.Generic;
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

            Console.WriteLine(publicKey);
            Console.WriteLine("");
            Console.WriteLine(privateKey);
            Console.ReadKey();
        }
    }
}
