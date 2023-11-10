using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1Day5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[3][];
            matrix[0] = new int[4] { 1, 2, 3, 4 };
            matrix[1] = new int[2] { 8, 9 };
            matrix[2] = new int[3] { 5, 6, 7 };

            Console.WriteLine("For accessing and displaying");

            for(int i = 0; i <matrix.Length; i++)

            {
                Console.WriteLine("Number of element in "+(i+1)+" 's rows");
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j]+"\t");
                }
                Console.WriteLine();

            }

            //modification 
            matrix[2][2] = 15;
            Console.WriteLine("After Modification");
            for (int i = 0; i < matrix.Length; i++)

            {
                Console.WriteLine("Number of element in " + (i + 1) + " 's rows");
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j] + "\t");
                }
                Console.WriteLine();

            }

            //Advance concept;
            dynamic[][] objectMatrix = new dynamic[2][];
            objectMatrix[0] = new dynamic[3] { 1, "shivam", 2.20 };
            objectMatrix[1] = new dynamic[4] { 'A', true, "singh", DateTime.Now };

            for(int i = 0; i < objectMatrix.Length; i++)
            {
                for(int j = 0; j < objectMatrix[i].Length; j++)
                {
                    Console.WriteLine(objectMatrix[i][j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
