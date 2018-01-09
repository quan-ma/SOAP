using SoapDemoConsole.PizzaReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoapDemoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new PizzaClient();

            System.Console.WriteLine(client.Prepare().Message);
            System.Console.ReadLine();
        }
    }
}
