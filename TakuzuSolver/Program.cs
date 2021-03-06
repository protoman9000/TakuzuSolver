﻿using System;
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
            
            //Letting the user selecte what kind of size for the grid
            Console.WriteLine("Enter the height:");
            string tmp = Console.ReadLine();
            int tmpNum = Convert.ToInt16(tmp);

            Console.WriteLine("Enter the Width:");
            string tmp2 = Console.ReadLine();
            int tmp2Num = Convert.ToInt16(tmp2);
            
            string[,] newGrid = new string[tmp2Num, tmpNum];
            
            //Random generator for the red and blue
            int randGen = ((tmp2Num * tmpNum) / 2);
            Random rnd = new Random();
            int placement = rnd.Next(randGen);

            //filling out the grid. 
            for (int i = 0; i < placement; i++)
            {
                for (int j = 0; j < placement; j++)
                {
                    if (i > 3 && j < 3)
                    {
                        continue;
                    }
                    else
                    {
                        newGrid[j, i] = "Red";
                        newGrid[i, j] = "Blue";
                    }
                }
            }
        }
    }
}
