using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakuzuSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Takuza Solver");
            Console.ReadKey();
            
            Console.WriteLine("Enter the height:");
            string tmp = Console.ReadLine();
            int tmpNum = Convert.ToInt16(tmp);

            Console.WriteLine("Enter the Width:");
            string tmp2 = Console.ReadLine();
            int tmp2Num = Convert.ToInt16(tmp2);
            
            string[,] newGrid = new string[tmp2Num, tmpNum];
        }
    }
}
