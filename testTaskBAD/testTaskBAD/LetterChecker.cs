using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace testTaskBAD
{
    public class LetterChecker
    {
        public char find_least_repeated_letter(string str)
        {
            string[] words = get_words_from_string(only_letters_string(str));
            string letters = "";

            for (int i = 0; i < words.Length; i++)
            {
                for(int j = 0; j < words[i].Length; i++)
                {
                    if (letter_count_in_wrod(words[i][j], words[i]) == 1)
                    {
                        letters += words[i][j];
                        break;
                    }
                }
            }


            for (int i = 0; i < letters.Length; i++)
            {
                if (letter_count_in_wrod(letters[i], letters) == 1)
                {
                    return letters[i];
                }
            }

            return ' ';
        }

        private string only_letters_string(string str)
        {
            string result = "";
            foreach (char c in str)
            {
                if ((Char.ToLower(c) >= 'a' && Char.ToLower(c) <= 'z') || c == ' ')
                {
                    result += c;
                }
            }
            return result;
        }

        private string[] get_words_from_string(string str)
        {
            string[] words = str.Split(' ');
            List<string> result = new List<string>();
            for (int i = 0; i < words.Length; i++)
            {
                if (!string.IsNullOrEmpty(words[i]))
                {
                    result.Add(words[i]);
                }
            }
            return result.ToArray();
        }

        private int letter_count_in_wrod(char letter, string word)
        {
            int result = 0;
            for(int i = 0; i < word.Length; i++)
            {
                if(letter == word[i])
                {
                    result++;
                }
            }
            return result;
        }
    }
}