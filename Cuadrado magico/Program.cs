using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuadrado_magico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CUADRADO MAGICO" +
                "\n");
            Console.WriteLine("HECTOR MUÑOZ" +
                "\n");

            int dimension = 3, n = 1;
            int[,] matriz = new int[dimension, dimension];
            int i = 0;
            int j = dimension / 2;
            int k = 0, l = 0;
            int[] Filas = new int[dimension];
            int[] Columnas = new int[dimension];

            matriz[i, j] = n++;

            for (k = i, l = j; n <= dimension * dimension; n++)
            {
                i--;
                j++;

                if (i < 0)
                    i = dimension - 1;
                if (j >= dimension)
                    j = 0;

                if (matriz[i, j] == 0)
                {
                    matriz[i, j] = n;
                }
                else
                {
                    k++;
                    if (k >= dimension)
                        k = 0;
                    matriz[k, l] = n;
                    i = k;
                    j = l;
                    continue;
                }
                k = i;
                l = j;
            }
            for (i = 0; i < dimension; i++)
            {
                for (j = 0; j < dimension; j++)
                {
                    Console.Write(matriz[i, j]+"   ");
                }
                Console.WriteLine("\n");
                
            }
            Console.ReadKey();

        }
    }
}
