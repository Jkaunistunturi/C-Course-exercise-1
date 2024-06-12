using System.Security.Cryptography.X509Certificates;

namespace C__Course_exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Simple program, where user gives sentence and then gives subsentence to check if the sentence contains the subsentence

            Console.WriteLine("This program will check if the given substring is present in the given string:");
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("");


            //The program asks a sentence
            Console.WriteLine("Input a sentence: ");
            string sentence = Console.ReadLine();

            //The program asks a substring
            Console.WriteLine("Input a substring to search: ");
            string subString = Console.ReadLine();

            //If else statements. If sentence or subsentence are not given, a message of empty input is logged to the console. 
            //If the sentence contains or does not contain the substring, the right message is logged to the console.
            if (sentence == "")
            {
                Console.WriteLine("You did not enter a sentence.");
            }
            else if (subString == "")
            {
                Console.WriteLine("You did not enter a substring.");
            }
            else if (sentence.Contains(subString))
            {
                Console.WriteLine("The substring exist in the sentence.");
            }
            else
            {
                Console.WriteLine("The substring does not exist in the sentence.");
            }


        }
    }
}
