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
        }
    }
}
