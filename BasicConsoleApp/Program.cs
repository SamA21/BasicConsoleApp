using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Enter number to count to:{Environment.NewLine}");
            Boolean vaildNumber = false;
            int usedNumber = 0;
            while (!vaildNumber)
            {
                string number = Console.ReadLine();                
                vaildNumber = int.TryParse(number, out usedNumber);
                if (!vaildNumber)
                    Console.WriteLine($"Invalid number, Re-enter:{Environment.NewLine}");
            }
            Console.WriteLine(Environment.NewLine);
            int count = 1;
            while(count < usedNumber)
            {
                if(count % 3 == 0 && count % 5 == 0)
                    Console.WriteLine("FizBuzz");
                else if(count % 5 == 0)
                    Console.WriteLine("Buzz");
                else if (count % 3 == 0)
                    Console.WriteLine("Fizz");
                else
                    Console.WriteLine(count);
                count++;
            }

            Console.ReadLine(); // to stop the program before closing
        }        
    }
}
