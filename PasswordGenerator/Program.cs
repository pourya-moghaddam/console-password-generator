using System;
using System.Text;

namespace PasswordGenerator
{
    public class Program
    {
        static void Main(string[] args)
        {
            PasswordGenerate passwordGenerate = new PasswordGenerate();

            Console.WriteLine("- Answer with 'y' for 'yes' and 'n' for 'no' -");
            bool useUpper = GetUserPreference("* Use upper-case letters (A-Z)? ");
            bool useLower = GetUserPreference("* Use lower-case letters (a-z)? ");
            bool useDigits = GetUserPreference("* Use digits (0-9)? ");
            bool useSpecial = GetUserPreference("* Use special characters (!, @, #, ...)? ");
            bool useSpace = GetUserPreference("* Use space ( )? ");
            bool useMinus = GetUserPreference("* Use minus (-)? ");
            bool useUnderline = GetUserPreference("* Use underline (_)? ");
            bool useBrackets = GetUserPreference("* Use brackets ([, ], {, ...)? ");
            bool useLatin1Spl = GetUserPreference("* Use Latin-1 supplement (Ä, µ, ¶, ...)? ");
            Console.WriteLine();
            Console.Write("> Any other characters to include (Press enter for none)? ");
            string custChars = Console.ReadLine();
            Console.Write("> How long would you want the password to be? ");
            int passwordSize = Convert.ToInt32(Console.ReadLine());

            do
            {
                string password = passwordGenerate.GeneratePassword(
                    useUpper,
                    useLower,
                    useDigits,
                    useSpecial,
                    useSpace,
                    useMinus,
                    useUnderline,
                    useBrackets,
                    useLatin1Spl,
                    custChars,
                    passwordSize);
                Console.WriteLine(
                    "\nHere's the generated password: {0}", password.ToString());
                Console.Write("Would you want another one? (y/n) ");
            } while (Console.ReadLine().ToLower() == "y");
        }

        public static bool GetUserPreference(string message)
        {
            Console.Write(message);
            var userInput = Console.ReadLine();
            if (userInput.ToLower() == "y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
