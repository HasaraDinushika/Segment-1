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
            // call PrintNum method
            PrintNum();
        }

        public static void PrintNum()
        {
            for (int num = 1; num <= 100; num++)
            {
                // check whether the number is divisible by 3 and 5
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
