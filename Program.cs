using System;

namespace Loops_Hutton_Riley
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asks the user why they want to make games and takes their response
            Console.WriteLine("Why do you want to make games?");
            string response = Console.ReadLine();

            // Responds to the user
            Console.WriteLine($"The sentence, \"{response}\" has {CountNumberOfSpaces(response)} spaces in it.");

            // Asks the user to enter a whole number and takes their response
            Console.WriteLine("Please enter a whole number!");
            String response2 = Console.ReadLine();

            // Responds to the user
            Console.WriteLine($"The sum of the individual digits of {response2} is {SumOfDigits(response2)}!");
        }

        /// <summary>
        /// Takes the response from the user and counts the number of spaces
        /// </summary>
        /// <param name="sentence">The sentence to count the number of spaces</param>
        /// <returns>number of spaces</returns>
        static int CountNumberOfSpaces(string sentence)
        {
            int numberOfSpaces = 0;
            foreach (char character in sentence)
            {
                if(character == ' ')
                {
                    numberOfSpaces++;
                }
            }
            return numberOfSpaces;
        }

        /// <summary>
        /// Takes the response2 from the user and adds the individual digits together
        /// </summary>
        /// <param name="number">Takes the whole number</param>
        /// <returns>The sum of the digits</returns>
        static int SumOfDigits(string number)
        {
            int sum = 0;
            foreach(char digit in number)
            {
                sum += (int)Char.GetNumericValue(digit);
            }
            return sum;
        }
    }
}
