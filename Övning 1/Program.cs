using System;

namespace Övning_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 0;
            
            do {
                i += 1;
                Console.WriteLine(i);
            }
            while (i < 10);
            
            Console.ReadLine();
        }
    }
}
