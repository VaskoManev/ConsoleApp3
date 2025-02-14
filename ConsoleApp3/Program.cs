namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Въведете число:");
            int number = int.Parse(Console.ReadLine());
            if  (IsPowerOfTwo(number)) 
            { 
                Console.WriteLine($" {number} е степен на 2.");
            }
            else {
                Console.WriteLine($" {number} не е степен на 2."); 
                 }

        }
        static bool IsPowerOfTwo(int n)
        {
            if (n <= 0)
            {
                return false;

            }
            if (n == 1)
            {
                return true;
            }  
            if(n % 2 !=0)
            {
                return false;
                
            }
            return IsPowerOfTwo(n / 2);
        }
    }
}
