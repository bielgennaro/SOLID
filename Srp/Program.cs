using Srp.Utils;

namespace Srp
{
    internal class Program
    {
        /// <summary>
        /// Single Responsability Principle:
        /// A class should have one and only one reason to change, meaning that a class should have only one job
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            Client.CreateClient("Gabriel");
            Client.ReadClient();

            Client.UpdateClient("Júlio");
            Client.DeleteClient();

            Notify.DeleteAccountNotifyClient();
        }
    }
}