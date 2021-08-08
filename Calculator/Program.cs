using System;

namespace Calculator {
    internal class Program {
        public static void Main() {
            Console.Write("Enter A Number: ");
            double input1 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter Another Number: ");
            double input2 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Choose an operator: ");
            string op = Console.ReadLine();

            if (op == "+") {
                Console.WriteLine(input1 + input2);
            } else if (op == "-") {
                Console.WriteLine(input1 - input2);
            } else if (op == "/") {
                Console.WriteLine(input1 / input2);
            } else if (op == "*") {
                Console.WriteLine(input1 * input2);
            }
            else {
                Console.Write("Invalid Input");
            }
        }
    }
}