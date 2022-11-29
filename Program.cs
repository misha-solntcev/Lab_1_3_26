using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 26. Вычислить частичную сумму ряда S=1/(3*5)+1 / (7 * 9) + 1 / ("11" * "13") +⋯
    Вычисление прекратить, когда модуль очередного слагаемого станет меньше 0,001. 
    Проверьте, насколько сумма приблизилась к значению π/8. */

namespace Lab_1_3_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = 4;
            double sum = 0;
            double S = 1 / ((n - 1) * (n + 1));
            while (S > 0.001)
            {                
                sum += S;
                Console.WriteLine($"n={n}, S={S}, sum={sum}");
                n += 4;
                S = 1 / ((n - 1) * (n + 1));
            }
            Console.ReadKey();
        }
    }
}
