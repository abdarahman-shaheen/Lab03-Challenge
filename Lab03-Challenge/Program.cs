using System.Diagnostics.Metrics;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.IO;
using System.Reflection.Emit;

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



            printStar();
    int [] arr = {1, 1, 1 ,1 };
            Console.WriteLine(FindDublicated(arr));

            int[] arr = { 5, 25, 99, 123, 78, 96, 555, 108, 4 };
            Console.WriteLine(MaxNumber(arr));

            string word = "Hello words";
            WriteText(word);
            
            string path = "../../../words.txt";
            ReadText(path);*/
            string word = "Hello Friend";
            reWriteText(word);

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

        public static void printStar()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }
        }

        public static int FindDublicated(int[] Numbers)
        {
            int counter=0;
            int maxCounter = 0;
            int maxVaule = 0; 
            for (int i = 0; i < Numbers.Length; i++)
            {
                if (Numbers[i] != maxVaule)
                {
                    counter = 0;

                    for (int j = i + 1; j < Numbers.Length; j++)
                    {
                        if (Numbers[i] == Numbers[j])
                        {
                            counter++;
                        }
                        if (maxCounter < counter)
                        {
                            maxCounter = counter;
                            maxVaule = Numbers[i];
                        }

                    }
                }
                if (maxVaule == 0)
                {
                    return Numbers[0];
                }
                
             

            }
            return maxVaule;
        }
    
        public static int MaxNumber(int[] numbers)
        {
            int max = numbers[0];
            foreach (int item in numbers)
            {
                if (item>max)
                {
                    max = item;

                }

            }
            return max;
        }

        public static void WriteText(string words)
        {
            string path = "../../../words.txt";
            File.WriteAllText(path, words);
        }
        public static void ReadText(string path)
        {
            string result = File.ReadAllText(path);
            Console.WriteLine(result);
        }

        public static void reWriteText(string words)
        {
            string path = "../../../words.txt";
            File.WriteAllText(path, words);
        }
    }
    



}
