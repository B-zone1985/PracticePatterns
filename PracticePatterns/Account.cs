using PracticePatterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePatterns
{
    public class Account
    {
        // тип учетной записи
        public ICalculator Type { get; set; }

        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }

        public Account(ICalculator type, double balance, double interest)
        {
            Type = type;
            Balance = balance;
            Interest = interest;
        }
        public void Calculate()
        {
            Type.CalculateInterest(this);
            Console.WriteLine(this.Interest);
        }
    }
}