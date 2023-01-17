using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePatterns

{
   /// <summary>
   /// Общий интерфейс типов калькулятора
   /// </summary>
   public interface ICalculator
    {
        void CalculateInterest(Account account);
    }
}
