using System;

namespace first_app { // Namespace is the same as project name, for now
    internal class Program {
        public static void Main() {
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
        }
    }
}
