using Extentiontask.Models;

namespace Extentiontask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string : ");
            string str=Console.ReadLine();
            str.ToCapitalize();
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("number is odd : ");
            Console.WriteLine(num.IsOdd());
            Console.Write("number is even : ");
            Console.WriteLine(num.IsEven());
        }
    }
}