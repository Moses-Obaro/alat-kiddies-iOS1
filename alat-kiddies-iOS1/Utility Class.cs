using System;
using System.Text.RegularExpressions;

namespace alat_kiddies_iOS1
{

    static class ValidationPack
    {
        public static bool ValidateEmail(string email)
        {
            bool emailInValid;
            if ((!Regex.Match(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Success) & email.Length >= 30)
            {
                emailInValid = true;
            }
            else if (!(Regex.Match(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Success))
            {
                emailInValid = true;
            }
            else if (email.Length >= 30)
            {
                emailInValid = true;
            }
            else
            {
                emailInValid = false;

            }



            return emailInValid;
        }

        public static bool ValidateName(string name)
        {
            bool isNameWrong;
            if (!(Regex.Match(name, "^[A-Z][a-z]*$").Success))
            {
                isNameWrong = true;
            }
            else
            {
                isNameWrong = false;
            }

            return isNameWrong;
        }

        public static bool ValidatePassWord(string password)
        {
            bool isPasswordValid;
            if (!Regex.Match(password, "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[.#?!@$%^&*_-]).{8,}$").Success)
            {
                isPasswordValid = true;
            }
            else
            {
                isPasswordValid = false;
            }

            return isPasswordValid;
        }
    }
}
