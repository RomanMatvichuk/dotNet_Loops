using System;

namespace Övning_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 1;
            var key = "";

            do
            {  
                for (var j = 0; j < i; j++)
                {                    
                    Console.WriteLine("och sen då?");
                }

                key = Console.ReadLine();
                if (key == "" || key == "q"){break;}

                i += i;
            }
            while (true);            
        }
    }
}
