using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintNum();
        }

        public static void PrintNum()
        {
            for (int num = 1; num <= 100; num++)
            {
                bool support = num % 3 == 0;
                bool training = num % 5 == 0;

                if (support && training)
                    Console.WriteLine("SupportTraining");
                else if (support)
                    Console.WriteLine("Support");
                else if (training)
                    Console.WriteLine("Training");
                else Console.WriteLine(num);
            }
        }
    }
}
