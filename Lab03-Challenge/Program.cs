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
        }
        public static int Multiplication(string[] Array)
        {
            
            int counter=0;
            foreach (string num in Array) {
                if(Array.Length < 3)
                {
                    return 0;

                }
                else
                {
                sum *= Convert.ToInt32(num);
                counter++;
              

                if (counter == 3)
                {
                        
                        return sum;
                }
                }
               
            }
            return sum;
        }
    }
   

}
