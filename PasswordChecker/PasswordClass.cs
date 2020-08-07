using System;
using System.Linq;

namespace PasswordChecker
{
    public class PasswordClass
    {
        /// <summary>
        /// returns the minimum number of characters required to make the password strong
        /// </summary>
        /// <param name="password">user typed password</param>
        /// <param name="requiredLength">required length</param>
        /// <returns></returns>
        public int CheckPassword(string password,int requiredLength)
        {
            // Return the minimum number of characters to make the password strong
            var numbers = "0123456789";
            var lower_case = "abcdefghijklmnopqrstuvwxyz";
            var upper_case = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var special_characters = "!@#$%^&*()-+";
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
            var numbers = "0123456789";
            var lower_case = "abcdefghijklmnopqrstuvwxyz";
            var upper_case = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var special_characters = "!@#$%^&*()-+";
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
    }
}
