using System;
using System.Linq;
using System.Collections.Generic;


namespace _1._Digitivision
{
    class Program
    {
        static void Main()
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();

            int Number = int.Parse(a) + int.Parse(b) + int.Parse(c);

            int abc = int.Parse(a + b + c);
            int acb = int.Parse(a + c + b);
            int bac = int.Parse(b + a + c);
            int bca = int.Parse(b + c + a);
            int cab = int.Parse(c + a + b);
            int cba = int.Parse(c + b + a);

            List<int> allComb = new List<int>() {abc, acb, bac, bca, cab, cba };
            bool isDivisible = false;
            for (int i = 0; i < allComb.Count; i++)
            {
                int curr = allComb[i];
                if (Number == 0)
                {
                    break;
                }
                else if (curr % Number == 0)
                {
                    isDivisible = true;
                    break;
                }
            }
            if (isDivisible)
            {
                Console.WriteLine("Digitivision successful!");
            }
            else
            {
                Console.WriteLine("No digitivision possible.");
            }
        }
    }
}
