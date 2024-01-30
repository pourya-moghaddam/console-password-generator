using System;
using System.Text;

namespace PasswordGenerator
{
    public class PasswordGenerate
    {
        private string _upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private string _lower = "abcdefghijklmnopqrstuvwxyz";
        private string _digits = "1234567890";
        private string _special = "!@#$%^&*\"'+=,./:;\\|?~`";
        private string _space = " ";
        private string _minus = "-";
        private string _underline = "_";
        private string _brackets = "[]{}()<>";
        private string _latin1supplement = "¡¢£¤¥¦§¨©ª«¬®¯"
                                         + "°±²³´µ¶·¸¹º»¼½¾¿"
                                         + "ÀÁÂÃÄÅÆÇÈÉÊËÌÍÎÏ"
                                         + "ÐÑÒÓÔÕÖ×ØÙÚÛÜÝÞß"
                                         + "àáâãäåæçèéêëìíîï"
                                         + "ðñòóôõö÷øùúûüýþÿ";

        public PasswordGenerate() { }

        public string GeneratePassword(
            bool useUpper,
            bool useLower,
            bool useDigits,
            bool useSpecial,
            bool useSpace,
            bool useMinus,
            bool useUnderline,
            bool useBrackets,
            bool useLatin1Spl,
            string custChars,
            int passwordSize
        )
        {
            Random rand = new Random();
            StringBuilder charSet = new StringBuilder();
            char[] password = new char[passwordSize];

            if (useUpper)
            {
                charSet.Append(_upper);
            }
            if (useLower)
            {
                charSet.Append(_lower);
            }
            if (useDigits)
            {
                charSet.Append(_digits);
            }
            if (useSpecial)
            {
                charSet.Append(_special);
            }
            if (useSpace)
            {
                charSet.Append(_space);
            }
            if (useMinus)
            {
                charSet.Append(_minus);
            }
            if (useUnderline)
            {
                charSet.Append(_underline);
            }
            if (useBrackets)
            {
                charSet.Append(_brackets);
            }
            if (useLatin1Spl)
            {
                charSet.Append(_latin1supplement);
            }
            charSet.Append(custChars);

            for (int i = 0; i < passwordSize; i++)
            {
                password[i] = charSet[rand.Next(charSet.Length - 1)];
            }

            return string.Join(null, password);
        }
    }
}
