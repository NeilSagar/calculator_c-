// using System;

// namespace CalculatorApplication
// {
    class CalculatorImplementation
    {
        private int a, b;

        public CalculatorImplementation(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int Addition()
        {
            return a + b;
        }
        
        public int Multiplication()
        {
            return a * b;
        }

        public int Subtraction()
        {
            return a - b;
        }

        public double Division()
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return (double)a / b;
        }
    }

    class Program
    {
        static void Main()
        {
            int a=0,b=0;
            char operation='.';
            try{
                Console.Write("Enter the first number: ");
                a = int.Parse(Console.ReadLine());
                

                Console.Write("Enter the second number: ");
                b = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the operation (+, -, *, /): ");
                HashSet<char> ops = new HashSet<char>(){'+','-','*','/'};
                operation = Console.ReadLine()[0];
                if(!ops.Contains(operation)){
                    throw new Exception("Invalid operation type.");
                }

            }catch(Exception e){
                Console.WriteLine("Error while taking inputs : " + e.Message);
                return;
            }
            

            CalculatorImplementation calculatorImplementation = new CalculatorImplementation(a, b);
            try
            {
                switch (operation)
                {
                    case '+':
                        Console.WriteLine("Result: " + calculatorImplementation.Addition());
                        break;
                    case '-':
                        Console.WriteLine("Result: " + calculatorImplementation.Subtraction());
                        break;
                    case '*':
                        Console.WriteLine("Result: " + calculatorImplementation.Multiplication());
                        break;
                    case '/':
                        Console.WriteLine("Result: " + calculatorImplementation.Division());
                        break;
                    default:
                        throw new Exception("Invalid operation.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }
        }
    }
// }
