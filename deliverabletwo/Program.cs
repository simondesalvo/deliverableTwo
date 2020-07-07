using System;

namespace deliverabletwo
{
    class Program
    {
        public static int cipher(char ch)
        {
            if (!char.IsLetter(ch))
            {
                return ch;
            }

            char d = char.IsUpper(ch) ? 'A' : 'a';  
            return (int)((((ch) - d) % 26) + d - 64); 
        }

        public static int checksumNumber(char ch)
        {
            if (!char.IsLetter(ch))
            {
                return ch;
            }

            char d = char.IsUpper(ch) ? 'A' : 'a';  
            return (int)((((ch) - d) % 26) + d); 
        }



        public static string Encipher(string input)
        {
            string output = string.Empty;

            foreach (char ch in input)
                output += (cipher(ch) + "-");
            return output;
        }

        public static string createchecksum(string input)
        {
            int checksum = 0;

            foreach (char ch in input)
                checksum += (checksumNumber(ch));
            return (checksum.ToString());
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Type a string to encrypt:");
            string input = Console.ReadLine();  
            string ucaseinput = input.ToUpper();

            Console.WriteLine(); //I wanted a blank line here so it'd look better when run//

            Console.Write("Your encrypted message is ");

            string message = Encipher(ucaseinput);
            string checksum = createchecksum(ucaseinput);
            Console.WriteLine(message.TrimEnd('-'));

            Console.WriteLine("Checksum");
            Console.Write(checksum);





            Console.ReadKey();
        }
    }
}