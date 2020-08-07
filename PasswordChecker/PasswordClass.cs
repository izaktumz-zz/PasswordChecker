using System;
using System.Linq;
using System.Text;

namespace PasswordChecker
{
    /// <summary>
    /// A Class that checks and generates password
    /// </summary>
    public class PasswordClass
    {
        private string numbers = "0123456789";
        private string lower_case = "abcdefghijklmnopqrstuvwxyz";
        private string upper_case = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private  string special_characters = "!@#$%^&*()-+";

        /// <summary>
        /// returns the minimum number of characters required to make the password strong
        /// </summary>
        /// <param name="password">user typed password</param>
        /// <param name="requiredLength">required length</param>
        /// <returns></returns>
        public int CheckPassword(string password,int requiredLength)
        {
            int n = password.Length;
            int count = 0;
            bool isNo = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (password.Contains(numbers[i]))
                {
                    isNo = true;
                    break;
                }
            }

            bool isLowercase = false;
            for (int i = 0; i < lower_case.Length; i++)
            {
                if (password.Contains(lower_case[i]))
                {
                    isLowercase = true;
                    break;
                }
            }

            bool isUppercase = false;
            for (int i = 0; i < upper_case.Length; i++)
            {
                if (password.Contains(upper_case[i]))
                {
                    isUppercase = true;
                    break;
                }
            }

            bool isSpecialcase = false;
            for (int i = 0; i < special_characters.Length; i++)
            {
                if (password.Contains(special_characters[i]))
                {
                    isSpecialcase = true;
                    break;
                }
            }

            if (!isNo)
            {
                count++;
            }

            if (!isLowercase)
            {
                count++;
            }

            if (!isUppercase)
            {
                count++;
            }

            if (!isSpecialcase)
            {
                count++;
            }

            return Math.Max(count, requiredLength - n);
        }

        /// <summary>
        /// Returns true if password is strong else false
        /// </summary>
        /// <param name="password"></param>
        /// <param name="requiredLength"></param>
        /// <returns></returns>
        public bool IsPasswordStrong(string password, int requiredLength)
        {
            // Return the minimum number of characters to make the password strong
         
            int count = 0;
            int n = password.Length;

            bool isNo = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (password.Contains(numbers[i]))
                {
                    isNo = true;
                    break;
                }
            }

            bool isLowercase = false;
            for (int i = 0; i < lower_case.Length; i++)
            {
                if (password.Contains(lower_case[i]))
                {
                    isLowercase = true;
                    break;
                }
            }

            bool isUppercase = false;
            for (int i = 0; i < upper_case.Length; i++)
            {
                if (password.Contains(upper_case[i]))
                {
                    isUppercase = true;
                    break;
                }
            }

            bool isSpecialcase = false;
            for (int i = 0; i < special_characters.Length; i++)
            {
                if (password.Contains(special_characters[i]))
                {
                    isSpecialcase = true;
                    break;
                }
            }

            if (!isNo)
            {
                count++;
            }

            if (!isLowercase)
            {
                count++;
            }

            if (!isUppercase)
            {
                count++;
            }

            if (!isSpecialcase)
            {
                count++;
            }

            if (count == 0)
            {
                return true;
            }
            return false;
        }
    

        /// <summary>
        /// Generates a random password of the required length
        /// </summary>
        /// <param name="passwordLength"></param>
        /// <returns></returns>
        public string GeneratePassword(int passwordLength)
        {
            Random rnd = new Random();
            int count = 0;
            StringBuilder sw = new StringBuilder();

            while (count <= passwordLength)
            {         
                int noPosition = rnd.Next(0, numbers.Length);
                if (count <= passwordLength)
                   sw.Append(numbers[noPosition]);
                       
                int lowerCasePosition = rnd.Next(0,lower_case.Length);
                if(count <= passwordLength)
                   sw.Append(lower_case[lowerCasePosition]);

                int upperCasePosition = rnd.Next(0, upper_case.Length);
                if (count <= passwordLength)
                    sw.Append(upper_case[upperCasePosition]);


                int specialCasePosition = rnd.Next(0, special_characters.Length);
                if (count <= passwordLength)
                    sw.Append(special_characters[specialCasePosition]);

                count += 4;
            }

            return sw.ToString();
        }
    }
}
