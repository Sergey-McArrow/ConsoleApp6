using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            while (true)
            {
                int i = rnd.Next(2, 10);
                int ii = rnd.Next(2, 10);
                Console.Write($"{i} * {ii} = ");
                int answer = int.Parse(Console.ReadLine());
                if (i * ii == answer)
                    Console.WriteLine("Молодец");
                else
                    Console.WriteLine("Тупица");
                
            }      
            
            
        }
    }
}
