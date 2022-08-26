using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _6_5
{
    class CheckMail
    {
        CheckMail check = new CheckMail();
        static void Main(String[] args)
        {
            string email = "test@test.com";
            Console.WriteLine(email);
            Console.WriteLine(IsEmail2(email));
        }

        static bool IsEmail(string email)
        {
            string[] parts = email.Split('@');
            if (parts.Length != 2)
            {
                return false;
            }
            if (IsAlphaNumeric(parts[0]) == false)
            {
                return false;
            }

            parts = parts[1].Split('.');
            if (parts.Length == 1)
            {
                return false;
            }

            foreach(string part in parts)
            {
                if(IsAlphaNumeric(part) == false)
                {
                    return false;
                }
            }

            return true;
        }

        static bool IsAlphaNumeric(string text)
        {
            foreach (char ch in text)
            {
                if (char.IsLetterOrDigit(ch) == false)
                {
                    return false;
                }
            }
            return true;
        }

        private static bool IsEmail2(string email)
        {
            Regex regex = new Regex(@"^([0-9a-zA-Z]+)@([0-9a-zA-Z]+)(\.[0=9a-aA-Z]+){1,}$");
            return regex.IsMatch(email);
        }
    }

   
}
