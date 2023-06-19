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
            UserInterface();
    

        }
        public static void UserInterface()
        {
            Console.WriteLine("Hello in your account");

            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1.Challenge 1");
                Console.WriteLine("2.Challenge 2");
                Console.WriteLine("3.Challenge 3");
                Console.WriteLine("4.Challenge 4");
                Console.WriteLine("5.Challenge 5");
                Console.WriteLine("6.Challenge 6");
                Console.WriteLine("7.Challenge 7");
                Console.WriteLine("8.Challenge 8");
                Console.WriteLine("9.Challenge 9");

                int number;
                string num = Console.ReadLine();
                number = Convert.ToInt32(num);

                switch (number)
                {
                    case 1:
                        Console.WriteLine("Please enter 3 number");
                        string Numbers = Console.ReadLine();
                        Console.WriteLine($"The product of these 3 numbers is: {Multiplication(Numbers)}");
                        break;
                    case 2:

                        try
                        {
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
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("please add the real number");
                        }
                        break;
                    case 3:
                        printStar();
                        break;
                    case 4:
                        int[] arr = { 2, 1, 4,3,5,2,4,2 };
                        Console.WriteLine($"the dublicated number is :{FindDublicated(arr)}");
                        break;
                    case 5:
                        int[] arr2 = { 5, 25, 99, 123, 78, 96, 555, 108, 4 };
                        Console.WriteLine($"The maximam nubers is {MaxNumber(arr2)}");
                        break;
                    case 6:
                        Console.WriteLine("add the word in file text : ");
                        string word = Console.ReadLine();
                        WriteText(word);
                        break;
                    case 7:
                        string path = "../../../words.txt";
                        ReadText(path);
                        break;
                    case 8:
                        string words = "Hello Friend";
                        reWriteText(words);
                        Console.WriteLine("It will be rewrite on text file");
                        break;
                    case 9:
                        Console.WriteLine("Add the sentence ");
                        string sentence =Console.ReadLine();
                        string[] arr3 = NumberWords(sentence);
                        foreach (string s in arr3)
                        {
                            Console.Write($"{s} ");
                        }
                        Console.WriteLine(" ");
                        break;
          
                    default:
                        flag = false;
                        break;
                }

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

        public static void printStar()
        {
            int rows = 5;
            for (int i = 0; i < rows; i++)
            {

                for (int j = 0; j < rows - i - 1; j++)
                {
                    Console.Write(" ");
                }


                for (int k = 0; k < 2 * i + 1; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }


            for (int i = rows - 2; i >= 0; i--)
            {
                for (int j = 0; j < rows - i - 1; j++)
                {
                    Console.Write(" ");
                }


                for (int k = 0; k < 2 * i + 1; k++)
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
        public static string[] NumberWords(string arr)
        {
            string[] sentance = arr.Split(" ");
            string[] newarr=new string[sentance.Length];
            for (int i = 0; i < sentance.Length; i++)
            {
                newarr[i]= $"{sentance[i]}: {sentance[i].Length }";
                            
            }
            return newarr;
        } 

    }
    



}
