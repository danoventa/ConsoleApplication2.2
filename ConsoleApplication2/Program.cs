using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] froots = new string[3];
            froots[0] = "Joe";
            froots[1] = "Oea";
            froots[2] = "Carp";
            UseArray(froots);

            int[] weights = { 12, 124, 345, 345, 2 };
            int sum = weights.Sum();
            Console.WriteLine(sum);

            try
            {
                string[] fruit = { "Apples", null, "Grapes" };
                for (int i = 0; i <= fruit.Length; i++)
                {
                    if(fruit[i] == null)
                    {
                        throw (new ArgumentNullException());
                    }
                    Console.WriteLine(fruit[i]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Derp, of course I print!");
            }

            bool isQuit = true;
            while (isQuit)
            {
                List<int> toSum = new List<int>();

                for (int i = 1; i <= 2; i++)
                {
                    int input;
                    Console.WriteLine("Enter value " + i + ":");
                    bool isValid = Int32.TryParse(Console.ReadLine(), out input);
                    Console.WriteLine(input);

                    while (!isValid)
                    {
                        Console.WriteLine("Enter a valid value " + i + ":");
                        isValid = Int32.TryParse(Console.ReadLine(), out input);
                    }
                    toSum.Add(input);
                }
                Console.WriteLine("Select a function: Add (A), Subtract(S), Divide(D), Multiply(M)");
                char type;
                bool isChar = char.TryParse(Console.ReadLine(), out type);
                while (!isChar)
                {
                    Console.WriteLine("Select a proper function: Add (A), Subtract(S), Divide(D), Multiply(M)");
                    isChar = char.TryParse(Console.ReadLine(), out type);
                }

                switch (Char.ToUpper(type))
                {
                    case 'A':
                        Console.WriteLine(Add(toSum[0], toSum[1]));
                        break;
                    case 'S':
                        Console.WriteLine(Subtracting(toSum[0], toSum[1]));
                        break;
                    case 'D':
                        Console.WriteLine(Divide(toSum[0], toSum[1]));
                        break;
                    case 'M':
                        Console.WriteLine(Multiply(toSum[0], toSum[1]));
                        break;
                    default:
                        Console.WriteLine("You didn't specify any");
                        Console.WriteLine(Add(toSum[0], toSum[1]));
                        Console.WriteLine(Subtracting(toSum[0], toSum[1]));
                        Console.WriteLine(Divide(toSum[0], toSum[1]));
                        Console.WriteLine(Multiply(toSum[0], toSum[1]));
                        break;
                }
                Console.WriteLine("Another? (Y)/(N)");
                char doAgain;
                bool tryAgain = Char.TryParse(Console.ReadLine(), out doAgain);
                while(tryAgain)
                {
                    switch (Char.ToUpper(doAgain))
                    {
                        case 'Y':
                            isQuit = true;
                            tryAgain = false;
                            break;
                        case 'N':
                            isQuit = false;
                            tryAgain = false;
                            break;
                        default:
                            tryAgain = Char.TryParse(Console.ReadLine(), out doAgain);
                            break;
                    }
                }
            }
        }

        static void UseArray(string[] values)
        {
            Console.WriteLine("Values");
            foreach (var item in values)
            {
                Console.WriteLine(item);
            }
        }

        static int Add(int one, int two)
        {
            return one + two;
        }
        static int Subtracting(int one, int two)
        {
            return one - two;
        }
        static int Divide(int one, int two)
        {
            if(two == 0)
            {
                Console.WriteLine("Don't divide by Zero");
                return 0;
            }
            return one / two;
        }
        static int Multiply(int one, int two)
        {
            return one * two;
        }
    }
}
