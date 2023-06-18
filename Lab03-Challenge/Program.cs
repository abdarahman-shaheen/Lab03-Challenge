﻿using System.Diagnostics.Metrics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab03_Challenge
{
    public class Program
    {
       

        static void Main(string[] args)
        {

             /*
            Console.WriteLine("Please enter 3 number");
          string Numbers  =Console.ReadLine();
            Console.WriteLine($"The product of these 3 numbers is: {Multiplication(Numbers)}");
           */
             try {
                Console.WriteLine("Please enter number between 2-10");
                int size = Convert.ToInt32(Console.ReadLine());
                int[] arrnum = new int[size];
                if (size > 2 && size < 10)
                {
                    for (int i = 0; i < size; i++)
                    {
                        Console.WriteLine($"{i + 1} of {size} - Enter a number:");

                        arrnum[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine($"the average is {Randoms(size, arrnum)}");

                }
            } catch ( FormatException) {
                Console.WriteLine("please add the real number");
            }
            


        }
        public static int Multiplication(string number )
        {
            string[] Numbers = number.Split(" ");

            int sum = 1;
        int counter=0;

            
            foreach (string num in Numbers) {
                if (counter == 3)
                {
                        
                        return sum;
                }

                if(Numbers.Length < 3)
                {
                    return 0;

                }


                else
                {
                    try
                    {
                     sum *= Convert.ToInt32(num);
                counter++;
              

               
                    

                    }
                    catch (Exception)
                    {
                        Numbers[counter] = "1";
                        sum *= Convert.ToInt32(Numbers[counter]);
                    }


                }
               
            }
            return sum;
        }
        public static int Randoms(int size , int [] num)
        {
            int sum = 0;
            for (int i = 0; i < size; i++)
            {
               sum+= num[i];
               
            }

                int avg = sum / size;
                return avg;
        }
    }
   

}
