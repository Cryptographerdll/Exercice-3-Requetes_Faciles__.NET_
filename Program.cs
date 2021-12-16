using System;
using System.Collections.Generic;
using System.Linq;

namespace Requêtes_Faciles_3__.NET_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nombres supérieurs à 2, qui sont des multiples de 2, inférieurs à 20, différents de 8

            List<int> Entiers = new List<int> { 2, 3, 5, 1, 58, 46, 31, 14, 82, 0, 6 };

            var query = from x
                        in Entiers
                        where x > 2
                        where x % 2 == 0
                        where x < 20
                        where x != 8
                        orderby x ascending 
                        select x;

            foreach (var x in query)
                Console.WriteLine(x);
        }
    }
}
