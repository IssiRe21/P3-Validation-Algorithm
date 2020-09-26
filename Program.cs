using System;

namespace P3___Validation_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
             int[] arr = new int[] {1, 1, 1, 3};


            static void Comprobar(int[]nums)
            {
                bool requisitos = true;
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    if (nums[i] != 1)
                    {
                      requisitos = false;                    }
                    
                    if (nums[nums.Length-1] != nums.Length-1)
                    {
                        requisitos = false;
                    }
                
                }

                if (requisitos == false)
                {
                    System.Console.WriteLine("Los datos no cumplen los requisitos");
                }
                else
                { 
                    System.Console.WriteLine("Los datos cumplen los requisitos");
                }
            }

            Comprobar(arr);
            
        }
    }
}
