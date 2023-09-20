using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter first number");
           var x=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number");
            var y=Convert.ToInt32(Console.ReadLine());
            var sum = Addiction(x, y);
            var difference = Substraction(x, y);
            var product = Multiplication(x, y);
            var quotient = Division(x, y);
            Console.WriteLine(sum);
            Console.WriteLine(difference);
            Console.WriteLine(product);
            Console.WriteLine(quotient);
        }
       static int Addiction(int x, int y)
        {
            return x + y;
        }
        static int Substraction(int x, int y)
        {
            return x - y;
        }
        static int Multiplication(int x, int y)
        {
            return x * y;
        }
        static int Division(int x, int y)
        {
            return x / y;
        }
    }
}