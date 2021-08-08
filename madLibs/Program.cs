using System;

namespace madLibs {
    internal class Program {
        public static void Main() {
            string color, pluralNoun, celebrity;
            
            // Get color
            Console.Write("Enter a color: ");
            color = Console.ReadLine();
            
            // Get pluralNoun
            Console.Write("Enter a plural noun: ");
            pluralNoun = Console.ReadLine();
            
            // Get color
            Console.Write("Enter a celebrity: ");
            celebrity = Console.ReadLine();
            
            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("I love " + celebrity);
        }
    }
}