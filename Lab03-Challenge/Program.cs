using System.Diagnostics.Metrics;

namespace Lab03_Challenge
{
    internal class Program
    {
        public static int sum = 1;

        static void Main(string[] args)
        {

            
            Console.WriteLine("Please enter 3 number");
          string Number  =Console.ReadLine();
            string[] Numbers = Number.Split(" ");
            Console.WriteLine($"the multiplication {Multiplication(Numbers)}");
            /*
            Console.WriteLine("Please enter number between 2-10");
            string Number = Console.ReadLine();
            if(Number >2 && Number > 10)
            {

            }
*/

        }
        public static int Multiplication(string[] Array)
        {
            
            int counter=0;

            
            foreach (string num in Array) {
                if (counter == 3)
                {
                        
                        return sum;
                }

                if(Array.Length < 3)
                {
                    return 0;

                }


                else
                {
                    try
                    {
                        if (Convert.ToInt32(num) > 0) {
                     sum *= Convert.ToInt32(num);
                counter++;
              

               
                    }

                    }
                    catch (Exception)
                    {
                        Array[counter] = "1";
                        sum *= Convert.ToInt32(Array[counter]);
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
