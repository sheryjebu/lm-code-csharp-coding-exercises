using System;
using System.Collections.Generic;
using System.Linq;
using Exercises.Models;

namespace Exercises
{
    public class Exercise001
    {
        public string CapitalizeWord(string word)
        {
           // Start: Code added by Shery
            if (word.Length == 0)
                System.Console.WriteLine("Word is Empty");
            else
                System.Console.WriteLine(char.ToUpper(word[0])+ word.Substring(1));
                word = char.ToUpper(word[0]) + word.Substring(1);
            return word;
           // End : Code added by Shery
        }

        public string GenerateInitials(string firstName, string lastName)
        {
            // Start: Code added by Shery
            string initials;
            if (lastName.Length == 0)
                initials = firstName[0] + ".";
            else
                initials = firstName[0] + "." + lastName[0];
            System.Console.WriteLine(initials);
            return initials;
            // End : Code added by Shery
        }

        public double AddVat(double originalPrice, double vatRate)
        {
  
            // Start: Code added by Shery
            double exact_price = Math.Round(originalPrice + (originalPrice * (vatRate/100)),2);
            System.Console.WriteLine(exact_price);
            return exact_price;
            // End: Code added by Shery
        }

        public string Reverse(string sentence)
        {
            // Start: Code added by Shery
            char[] reverse_sent = sentence.ToCharArray();
            Array.Reverse(reverse_sent);
            System.Console.WriteLine(reverse_sent);
            System.Console.WriteLine(new String(reverse_sent));
            return new String(reverse_sent);
            // End: Code added by Shery
        }

        public int CountLinuxUsers(List<User> users)
        {
            // Start: Code added by Shery
            int count = 0;
            foreach (User i in users)
            {
                if (i.Type == "Linux")
                    count++;
            }
            return count;
            // End : Code added by Shery
    }
    }
}
