using System;
using System.Collections;

namespace SoftwareDevelopmentApplication
{
    class StartApp
    {
        static char calculationType;
        static double numFloatA;
        static double numFloatB;

        static double result;

        static void Main(string[] args)
        {
            Console.Title = "My Basic Calulatior";

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Press Enter Key To Start.\n");
            while (!ToQuit())
            {
                
                Console.Write("Please Type Number Here: ");


                numFloatA = Convert.ToDouble(Console.ReadLine());


                Console.Write("Please Type A Calculation Type Like(+, /, *, -) Here: ");


                calculationType = Convert.ToChar(Console.ReadLine());


                Console.Write("Please Type Your Second Number Here: ");


                numFloatB = Convert.ToDouble(Console.ReadLine());

                result = FloatCalculation(numFloatA, numFloatB, calculationType);

                Console.WriteLine("Your Result Is:" + result);
                                
            }
            
        }
        
        static double FloatCalculation(double floatA,double floatB, char calcType)
        {
            double result;

            
            switch (calcType)
            {
                case '*':
                    result = floatA * floatB;
                    return result;
                case '+':
                    result = floatA + floatB;
                    return result;
                case '-':
                    result = floatA - floatB;
                    return result;
                case '/':
                    result = floatA / floatB;
                    return result;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error Plaese Try +,/,*,-");
                    Console.ResetColor();
                    break;
            }

            return 0f;
        }
        

        static bool ToQuit()
        {
            if (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                return true;
            }
            return false;
        }
    }
}
