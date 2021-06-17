using System;

namespace MethodOverloadingPractice
{
    class Program
    {
        //TODO Create a method that takes two string names in the parameter. Have the method tell you which name is longer.
        //TODO Create an overload method that takes a list of string names and an integer. The method will look for the first name that matches the length of the integer.
        static void Main(string[] args)
        {
            nameLength("Mark", "AJ");

            string[] nameArray = { "Mark", "AJ", "TJ" };
            nameLength(nameArray, 2);
            //TODO Call both methods here. Use a break point and watch as the code jumps to the different method overloads.

        }

        public static void nameLength(string name1, string name2)
        {
            if (name1.Length > name2.Length)
            {
                Console.WriteLine($"{name1} is longer than {name2}.");
            }
            else if (name2.Length > name1.Length)
            {
                Console.WriteLine($"{name2} is longer than {name1}.");
            }
            else
            {
                Console.WriteLine($"{name1} and {name2} are the same length.");
            }
        }
        public static void nameLength(string[] names, int length)
        {
            bool nameExists = false;

            foreach (string name in names)
            {
                if (name.Length == length )
                {
                    Console.WriteLine($"{name} is the first name in the given list of length {length}.");
                    nameExists = true;
                    break;
                }
            }

            if (nameExists == false)
            {
                Console.WriteLine($"No names in the list are of length {length}.");
            }

        }
    }
}
