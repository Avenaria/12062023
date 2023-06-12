using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12062023
{
    internal class Program
    {
        static void Main(string[] args)
        {    int max_j=0, max_i=0, min_j=0, min_i=0;
            int[,] arr = new int[5, 5];
            int max = 0;
            Random r = new Random();
            for (int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    arr[i,j]= r.Next(-100,100);
                    
                }
                Console.WriteLine(arr);
            }

            int max1 = arr[0, 0], min = arr[0, 0];
            int temp;
          
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (arr[i, j] < min)
                    {
                        max1 = arr[i, j];
                        max_i = i;
                        max_j = j;
                    }
                    if (arr[i, j] > max1)
                    {
                        max1 = arr[i, j];
                        max_i = i;
                        max_j = j;
                    }
                    if (max_i < min_i)
                    {
                        temp = min_i;
                        min_i = max_i;
                        max_i = temp;
                    }
                    if (max_j < min_j)
                    {
                        temp = min_i;
                        min_i = max_i;
                        max_i = temp;
                    }
                    Console.WriteLine(arr[i, j]);
                }
              
            }
            int sum=0;
            
        }
    }
}
