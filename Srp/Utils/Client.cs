using System;

namespace Srp.Utils
{
    public class Client
    {
        public static void CreateClient(string name)
        {
            Console.WriteLine("Criando cliente: " + name);
        }

        public static void DeleteClient()
        {
            Console.WriteLine("Deletando cliente!");
        }

        public static void ReadClient()
        {
            Console.WriteLine("Lendo cliente! ");
        }

        public static void UpdateClient(string name)
        {
            Console.WriteLine("Atualizando cliente para: " + name);
        }
    }
}
