using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace PracticePatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(new SalaryType(), 1, 2);
            acc.Calculate();

            Console.WriteLine();

            Account acc1 = new Account(new СommonType(), 1, 2);
            acc.Calculate();

            Console.ReadKey();
        }
    }
}
