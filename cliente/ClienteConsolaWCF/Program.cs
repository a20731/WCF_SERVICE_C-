using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteConsolaWCF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            calcWs.CalcServiceClient ws = new calcWs.CalcServiceClient();
            Console.WriteLine("soma de 1 com 2 e: "+ws.Sum(1, 2));
            Console.WriteLine("divisao de 1 com 2 e: "+ws.Div(1, 2));

            Console.ReadKey();
           //ws.s

        }
    }
}
