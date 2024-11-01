using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp23
{
    public class ValueToWords
    {
        public static string NumberToWords(int number)
        {
            if (number < 0 || number > 9999)
                return "Value exceeds limits";

            if (number ==0)

                return "Zero";

            string words = " ";


            // Describe the word translations
            string[] ones = {
                "","One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven",
                "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"

            };

            string[] tens = {
             "",   "","Twenty", "Thirty","Forty", "Fifty", "Sixty", "Seventy", "Eighty" , "Ninety"

            };

            { 

                // Process thousands
                if (number >= 1000)
                {
                    words += ones[number / 1000] + " Thousand";
                    number %= 1000; // Discard the thousands value

                    if (number > 0)
                    { 
                        words += " ";
                    }
                }

                // Process hundreds

                if (number >= 100)
                {
                    words += ones[number / 100] + " Hundred";
                    number %= 100; //Discard the hundreds value

                    if (number > 0)
                    {
                        words += " ";
                    }
                }

                // Process tens and ones

                if (number >= 20)
                {
                    words += tens[number / 10]; // Insert the tens element
                    number%= 10; //Remove the tens part
                    if (number > 0)
                    {
                        words +="-";

                    }
                }

                if (number > 0)
                {
                    words += ones[number]; //Insert the ones part
                

                }

                return words.Trim(); // Eliminate extra spaces

            }
        }
        public static void Main()
        {
            Console.WriteLine("Please provide a number(from 0 and 9999):");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                string result = NumberToWords(number);
                Console.WriteLine($"{number} in words is: {result}");
            }

            else
            {
                Console.WriteLine("Input is not valid.Please provide a correct number");
            }


        }
    }
}