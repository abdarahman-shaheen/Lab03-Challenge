using System.Diagnostics.Metrics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab03_Challenge
{
    public class Program
    {
       

        static void Main(string[] args)
        {

            
            Console.WriteLine("Please enter 3 number");
          string Numbers  =Console.ReadLine();
            Console.WriteLine($"the multiplication {Multiplication(Numbers)}");
            /*
            Console.WriteLine("Please enter number between 2-10");
            string Number = Console.ReadLine();
            if(Number >2 && Number > 10)
            {

            }
*/

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
        public static void Randoms(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                Random random = new Random();
                Console.WriteLine($"{i} of num" );
            }

        }
    }
   

}
