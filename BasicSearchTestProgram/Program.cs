using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicSearchTestProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //Relatively more simple way of completing the simple task you had me whiteboard
            string data = "This sentence is just a test. These are some random words. Create a method to search this sentence!";
            Console.WriteLine("The sentence is: " + data);
            Console.ReadLine();
            data.Split(' ');



            Console.WriteLine("Enter a word to see if it is present in the sentence");
            string word = Console.ReadLine();
            if (word != null)
            {
                if (data.Contains(word))
                {
                    Console.WriteLine("The sentence contains the word you entered!");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("It does not contain the word you entered");
                    Console.ReadLine();
                }
            }
        }
    }
}

