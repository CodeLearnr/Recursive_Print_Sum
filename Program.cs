using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA28_RecursivePrintSums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ==== LA 28 - Recursive Print Sums ====\n");

            Console.Write("Input numbers on the top row (separated with a space or comma): \n");

            char[] chr = { ' ', ',' };
            string[] numStr = Console.ReadLine().Split(chr);
            int l = numStr.Length;
            int[] numbInt = new int[l];
            
            for(int i=0; i< l; i++)
            {
                numbInt[i] = Int32.Parse(numStr[i]);
            }
            Console.WriteLine("\n=== A pyramid of numbers above is ===\n");
            RecursionSum(numbInt, numbInt.Length); 

            Console.ReadLine();
        }

        public static int[] RecursionSum(int[] array, int c)
        {
            if (array.Length == 0) 
                return array;

            string s = " ";  
            for(int i=0; i<c-array.Length; i++)
            {
                s += "  ";
            } 
            Console.Write(s);
            foreach(int a in array)
            {
                    Console.Write($" {a:00} ");
            }
            Console.WriteLine();

            int[] newArray = new int[array.Length - 1]; 
            for(int i=0; i<array.Length-1; i++)
            {
                newArray[i] = array[i] + array[i + 1];
            }
            return RecursionSum(newArray, c); 
        }

    }
}
