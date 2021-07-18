using System;


namespace WeekEightTaskConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum;
            double secondNum;
            double result;
            double Num;
            string operators;

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Hello " + name +", You Are Welcome To My Console Calculator");

            Console.WriteLine("********************************");

            Console.WriteLine("What do you want to do?");
            Console.WriteLine("Press Enter After Selecting Your Operator!");
            Console.WriteLine("I want to... ");
            Console.WriteLine("\t+ - Add");
            Console.WriteLine("\t- - Subtract");
            Console.WriteLine("\t* - Multiply");
            Console.WriteLine("\t/ - Divide");
            Console.WriteLine("\ts - Square");
            operators = Console.ReadLine();

            try 
            {

            if (operators == "+")
            {
            Console.WriteLine("Enter The First Number And Press Enter");
            firstNum = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter The Second Number And Press Enter");
            secondNum = Double.Parse(Console.ReadLine());

                result = firstNum + secondNum;
                Console.WriteLine(result);
            }

            if (operators == "-")
            {
            Console.WriteLine("Enter The First Number And Press Enter");
            firstNum = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter The Second Number And Press Enter");
            secondNum = Double.Parse(Console.ReadLine());

                result = firstNum - secondNum;
                Console.WriteLine(result);
            }

            if (operators == "*")
            {
            Console.WriteLine("Enter The First Number And Press Enter");
            firstNum = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter The Second Number And Press Enter");
            secondNum = Double.Parse(Console.ReadLine());

                result = firstNum * secondNum;
                Console.WriteLine(result);
            }

            if (operators == "/")
            {
            Console.WriteLine("Enter The First Number And Press Enter");
            firstNum = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter The Second Number And Press Enter");
            secondNum = Double.Parse(Console.ReadLine());

            while (secondNum == 0)
             {
                 Console.WriteLine("Enter a non-zero divisor: ");
                 secondNum = Double.Parse(Console.ReadLine());
             }

                result = firstNum / secondNum;
                Console.WriteLine(result);
            }

            if(operators == "s") 
            {
            Console.WriteLine("Enter The Number You Want To Square And Press Enter");

            Num = Double.Parse(Console.ReadLine());

                result = Num * Num ;
                Console.WriteLine(result);
            }

            }
            
            catch (FormatException)
            {
                Console.WriteLine("Invalid Entree. You can only enter a number.");
            }
            
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }

                         
           Console.WriteLine("Press Enter To Exit The Console");


            Console.ReadLine();
        }
    }
}
