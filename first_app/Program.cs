using System;

namespace first_app { // Namespace is the same as project name, for now
    internal class Program {
        public static void Main() {
            SayHi("Agbadev");
            double cubedNumber = Cuber(5);
            Console.WriteLine(cubedNumber);
            Console.WriteLine(GetMax(Convert.ToInt32(cubedNumber), 150));
            
            Console.WriteLine("Hello World!");  // Print out
            
            // Draw right angled triangle
            Console.WriteLine("     /|");
            Console.WriteLine("    / |");
            Console.WriteLine("   /  |");
            Console.WriteLine("  /   |");
            Console.WriteLine(" /    |");
            Console.WriteLine("/_____|");
            
            /*
             * Variables
             */
            // Declare and assign value
            string name = "Zubair";

            // Declaration
            int age;
    
            // Assignment
            age = 19;
            
            Console.WriteLine(name + " is " + age + " years old");
            
            // Update name and age
            name = "Zubs";
            age = 21;
            
            Console.WriteLine(name + " is " + age + " years old");
            
            /*
             * Data Types
             */
            string var1 = "This shit is crazy";
           
            /*
             * Char can only use ''
             * Char can only have one letter in them
             */
            char letter = 'B';
            int var3 = 230;
            int var4 = -56;
            
            // float and decimal are messed up -_-
            float var5 = 12.535353535f;
            double var6 = -0.00567;
            decimal var7 = 12.3087383838m;
            bool var8 = true;
            
            /*
             * String methods
             */
            string words = "I am Great, don't you think?";
            Console.WriteLine(words.Length);
            Console.WriteLine(words.ToUpper());
            Console.WriteLine(words.ToLower());
            Console.WriteLine(words.Contains("Great"));
            Console.WriteLine(words[2]);
            Console.WriteLine(words.IndexOf("Great"));
            Console.WriteLine(words.Substring(5, 5));
            
            /*
             * Numbers
             */
            Console.WriteLine(Math.Abs(-200));
            Console.WriteLine(Math.Pow(300, 16));
            Console.WriteLine(Math.Sqrt(48));
            Console.WriteLine(Math.Max(4, 90));
            Console.WriteLine(Math.Min(4, 90));
            Console.WriteLine(Math.Round(4.667));
           
            /*
             * User Inputs
             */
            Console.Write("What is your name? ");
            string username = Console.ReadLine();
            
            Console.WriteLine("Hello " + username);
            
            /*
             * Number inputs
             */
            Console.Write("Enter your number: ");
            double userNum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(userNum + 21);
            
            /*
             * Arrays
             * Arrays in C# can only store a type of variable
             */
            int[] scores = { 21, 34, 45, 56 };
            Console.WriteLine(scores[0]);
            
            // Update array
            scores[3] = 900;
            Console.WriteLine(scores);
   
            // Create empty array, but set length
            string[] people = new string[5];
            people[4] = "Zubs"; // Assign array element
            
            /*
             * Conditionals and Logical Operators
             */
            bool isMale = false;
            bool isGay = true;

            if (isMale && isGay) { // Logical AND
                Console.WriteLine("Avoid me");
            } else if (!isMale && !isGay) {
                Console.WriteLine("Don't know if I can not love you");
            } else {
                Console.WriteLine("I'm not sure of what to do to you");
            }

            if (isMale || isGay) { // Logical OR
                Console.WriteLine("I repeat, avoud me!");
            }
        }

        static void SayHi (string username) {
            Console.WriteLine("Hello " + username);
        }

        static double Cuber (double number) {
            return Math.Pow(number, 3);
        }

        static int GetMax(int number1, int number2) {
            if (number1 > number2) {
                return number1;
            } else {
                return number2;
            }
        }
    }
}
