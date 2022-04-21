using System;
using System.Threading.Tasks;

namespace ServerForGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Realm Server | ver. 0.1 beta alpha";
            Console.WriteLine("Realm Server started...");
            Console.WriteLine();

            ServerObject server = new ServerObject();
            Task serverTask = new Task(server.StartServer);
            serverTask.Start();
            serverTask.Wait();

            Console.WriteLine("Realm Server stoped!");
            Console.ReadKey();
        }
    }
}
