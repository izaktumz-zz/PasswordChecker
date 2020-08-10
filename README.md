# PasswordChecker
A library that checks if a password is strong by checking if it contains a combination of lowercase,uppercase,special characters and numbers. In Addittion,it also generates a random password of the desired length


# Overview
instructions:
Install-Package PasswordChecker -Version 1.2.0


# Usage
The Library contains three methods

1.CheckPassword

  -It takes two parameters, the password and required length
  -The method returns the minimum no of characters required to reach the required length
  
2.IsPasswordStrong

 -It takes two parameters, the password and required length
 -The method returns true if the password has all the required characters and the required length otherwise returns false.
 
 3.GeneratePassword
  
   -It takes one parameter,the password length
   -The method returns a password with a combination of numbers,lowercase,uppercase and special characters of the required length.
    

