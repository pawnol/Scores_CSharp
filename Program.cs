/*
 * Scores
 * Pawelski
 * 1/11/2022
 * Read the code and run the program a few times to see what it does. 
 * Once you are familiar with the program, answer the questions found 
 * on the activity sheet.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalPoints;
            Console.Write("How many points are on the test? >> ");
            totalPoints = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= totalPoints; i++)
            {
                double percentage = (double) i / totalPoints * 100;
                Console.WriteLine(i + "/" + totalPoints + " = " + percentage);
            }
        }
    }
}
