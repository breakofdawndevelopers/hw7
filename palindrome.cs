using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)

        {
            while (true)
            {
                try
                {

                    Console.WriteLine("Palindrome Game");
                    Console.WriteLine("Enter Text to See if it's a Palindrome. Then press Enter");
                    string palendrome = Console.ReadLine();


                    char[] palendromeArray = palendrome.ToCharArray();
                    Array.Reverse(palendromeArray);
                    string wordReversed = "";

                    foreach (char item in palendromeArray)
                    {
                        wordReversed += item;
                    }
                    wordReversed += "";

                    Console.WriteLine("Your word typed backwords: " + wordReversed + " Press Enter");

                    Console.ReadLine();

                    if (palendrome == wordReversed)
                    {
                        Console.WriteLine("Your word is a Palendrome! Press 'Enter' to Continue");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Your word is not a Palendrome! Press 'Enter' to Continue");
                        Console.ReadLine();
                    }

                    while (true)
                    {
                        Console.Write("Do you want to play again, if yes, type Y, if no, type E to Exit [Y/E]?");
                        string answer = Console.ReadLine().ToUpper();
                        if (answer == "Y")
                            break;
                        if (answer == "E")
                            return;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("General Exception Caught");
                }
                finally
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
