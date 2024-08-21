using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.XPath;
using System.Globalization;


namespace KOTO
{
    class Program
    {
        static void Main(string[] args)
        {

            //Question 1
            // Console.Write("Enter your first name: ");
            // string fname = Console.ReadLine();


            // Console.Write("Enter your last name: ");
            // string lname = Console.ReadLine();


            // Console.Write("Enter your age: ");
            // string age = Console.ReadLine();

            // int calAge= 100 - int.Parse(age);


            // Console.WriteLine($"Hello,{fname}.You will turn 100 in {calAge}");

            //Question 2
            // Console.Write("Enter a word: ");
            // string word = Console.ReadLine();

            // char[] reword = word.ToCharArray();

            // int wordL = reword.Length;

            // for (int len=0; len<=wordL; len++)
            // {
            //     Console.WriteLine($"Character {len+1}: {reword[len]}");

            // }

            //Question 3

            // Console.Write("Enter the first string: ");
            // string fword = Console.ReadLine();

            // Console.Write("Enter the second string: ");
            // string sword = Console.ReadLine();

            // string result ="";

            // if (string.Equals(fword, sword, StringComparison.OrdinalIgnoreCase))
            // {
            //      result = "equal";
            // }
            // else{
            //      result = "not equal";
            // }

            // Console.WriteLine($"The strings are {result}");

            //Question 4

            // Console.Write("Enter the radius of the circle: ");
            // string radius = Console.ReadLine();

            // int rad = int.Parse(radius);
            // double A = 3.142*(rad*rad); 
            // float circum = (float)(3.142*(rad+rad));


            // Console.WriteLine($"For a circle with radius {rad}, Area: {A}, Circumference: {circum}");


            //Question 5

            //             Console.Write("Enter a sentence: ");
            //             string sent = Console.ReadLine();

            //             string[] split = sent.Split(" ");

            //             char[] secplit = split[0].ToCharArray();

            //             int len  = secplit.Length;

            //             int count=0;

            //             foreach (char c in secplit)
            // {
            //             if ("aeiouAEIOU".IndexOf(c) >= 0)
            //             {
            //                 count++;
            //             }

            //             Console.WriteLine($"The first word is '{split[0]}', which contains {count} vowels.");

            //Question 6

            // Console.Write("Enter a string: ");
            // string original = Console.ReadLine();

            // char[] charArray = original.ToCharArray();

            // Array.Reverse(charArray);

            // string reversed = new string(charArray);
            // Console.WriteLine($"Reversed String: {reversed}");

            // string result = "";

            // if (string.Equals(original, reversed, StringComparison.OrdinalIgnoreCase))
            // {
            //      result = "palindrome";
            // }
            // else{
            //      result = "not palindrome";
            // }

            // Console.WriteLine($"The string is a {result}.");


            // Question 7

            // Console.Write("Enter a string: ");
            // string original = Console.ReadLine();


            // Dictionary<char, int> frequency = new Dictionary<char, int>();

            // foreach(char c in original){
            //     if(frequency.ContainsKey(c)){
            //     frequency[c]++;
            // }else{
            //     frequency.Add(c,1);

            // }
            // }
            // Console.WriteLine("Frequency: ");
            // foreach(KeyValuePair<char,int>entry in frequency){
            //     Console.WriteLine($"{entry.Key} : {entry.Value}");

            // }

            // //Question 8

            // Console.Write("Enter a birthdate in (YYYY-MM-DD): ");
            // DateTime birthDate =DateTime.Parse(Console.ReadLine());

            // TimeSpan totalDaysLived = DateTime.Now - birthDate;

            // Console.WriteLine($"Total days lived: {totalDaysLived.Days}");

            // //Question 9

            // Console.Write("Enter a sentence: ");
            // string sentence =Console.ReadLine();

            // string capitalword = CapitalizeSentences(sentence);

            // Console.WriteLine($"{capitalword}");

            //Question 10

            //     Console.Write("Enter a string: ");
            //     string original = Console.ReadLine();

            //     string[] words = original.Split(new char[]{' ','.',',','!','?'}, StringSplitOptions.RemoveEmptyEntries);

            //     Dictionary<string, int> frequency = new Dictionary<string, int>();


            //     foreach(string word in words){
            //     if(frequency.ContainsKey(word)){
            //         frequency[word]++;
            //     }else{
            //         frequency.Add(word,1);
            //     }
            // }
            //     Console.WriteLine("Frequency: ");
            //     foreach(KeyValuePair<string,int>entry in frequency){
            //         Console.WriteLine($"{entry.Key} : {entry.Value}");

            //     }

            // //Question 11


            // Console.Write("Enter the first string: ");
            // string firstString = Console.ReadLine();

            // Console.Write("Enter the second string: ");
            // string secondString = Console.ReadLine();

            // bool areAnagrams = AreAnagrams(firstString, secondString);

            // if (areAnagrams)
            // {
            //     Console.WriteLine("The strings are anagrams.");
            // }
            // else
            // {
            //     Console.WriteLine("The strings are not anagrams.");
            // }

            // // Question 12

            // Console.Write("Enter a string: ");
            // string original = Console.ReadLine();
            // string compressedString = CompressString(original);
            // Console.WriteLine("Compressed String: ");
            // Console.WriteLine(compressedString);

            // Question 13

            // Console.Write("Enter a string: ");
            // string original = Console.ReadLine().ToUpper();

            // Console.Write("Enter the shift value: ");
            // int shift = int.Parse(Console.ReadLine());

            // string encryptedText = CaesarCipher(original, shift);
            // Console.WriteLine("Encrypted Text: ");
            // Console.WriteLine(encryptedText);


            // Question 14

            // Console.Write("Enter a string: ");
            // string original = Console.ReadLine().ToUpper();

            // List<string> longestWords = new List<string>();

            // string[] words = original.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            // int maxLength = 0;

            // foreach (string word in words)
            // {
            //     int length = word.Length;

            //     if (length > maxLength)
            //     {
            //         maxLength = length;
            //         longestWords.Clear();
            //         longestWords.Add(word);
            //     }
            //     else if (length == maxLength)
            //     {
            //         longestWords.Add(word);
            //     }
            // }

            // //Question 15

            // Console.Write("Enter a sentence: ");
            // string input = Console.ReadLine();

            // bool isPalindrome = IsPalindrome(input);

            // if (isPalindrome)
            // {
            //     Console.WriteLine("The sentence is a palindrome.");
            // }
            // else
            // {
            //     Console.WriteLine("The sentence is not a palindrome.");
            // }

            //Question 16

            //     Console.Write("Enter a sentence: ");
            //     string input = Console.ReadLine();

            //     List<string> permutations = GeneratePermutations(input);

            // Console.WriteLine("All permutations:");
            // foreach (string permutation in permutations)
            // {
            //     Console.WriteLine(permutation);
            // }

            //Question 17


            // string password;
            // bool isValid;

            // do
            // {
            //     Console.Write("Enter a password: ");
            //     password = Console.ReadLine();

            //     isValid = password.Length >= 8 &&
            //               ContainsUpper(password) &&
            //               ContainsLower(password) &&
            //               ContainsDigit(password);

            //     if (!isValid)
            //     {
            //         Console.WriteLine("Password not strong");
            //     }
            // } while (!isValid);

            // Console.WriteLine("Password Strong!");


            //Question 18

            // Console.Write("Enter the main string: ");
            // string mainString = Console.ReadLine();

            // Console.Write("Enter the substring to find: ");
            // string substringToFind = Console.ReadLine();

            // Console.Write("Enter the substring to replace it with: ");
            // string substringToReplace = Console.ReadLine();

            // string result = mainString.Replace(substringToFind, substringToReplace);

            // Console.WriteLine("Resulting String: ");
            // Console.WriteLine(result);


            //Question 19

            // Console.Write("Enter a sentence: ");
            // string input = Console.ReadLine();

            // string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            // Array.Reverse(words);
            // string reversedSentence = string.Join(" ", words); ;


            // Console.WriteLine("Reversed sentence:");
            // Console.WriteLine(reversedSentence);

            //Question 20

            // Console.Write("Enter the number: ");
            // string number = Console.ReadLine();

            // Console.Write("Enter the current base (2 for binary, 8 for octal, 16 for hexadecimal): ");
            // int currentBase = int.Parse(Console.ReadLine());

            // Console.Write("Enter the desired base (10 for decimal, 8 for octal, 16 for hexadecimal): ");
            // int desiredBase = int.Parse(Console.ReadLine());

            // int decimalValue = Convert.ToInt32(number, currentBase);
            // string convertedNumber;

            // if (desiredBase == 10)
            // {
            //     convertedNumber = decimalValue.ToString();
            // }
            // else if (desiredBase == 8)
            // {
            //     convertedNumber = Convert.ToString(decimalValue, 8);
            // }
            // else if (desiredBase == 16)
            // {
            //     convertedNumber = Convert.ToString(decimalValue, 16).ToUpper();
            // }
            // else
            // {
            //     throw new ArgumentException("Unsupported base");
            // }


            // Console.WriteLine("Converted Number: " + convertedNumber);

        }



        static string CapitalizeSentences(string input)
        {
            string[] words = input.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 0)
                {
                    words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
                }
            }

            return string.Join(" ", words);
        }

        static bool AreAnagrams(string str1, string str2)
        {
            // Remove white spaces and convert to lowercase
            str1 = new string(str1.Where(c => !char.IsWhiteSpace(c)).ToArray()).ToLower();
            str2 = new string(str2.Where(c => !char.IsWhiteSpace(c)).ToArray()).ToLower();

            // Sort the characters of both strings
            char[] charArray1 = str1.ToCharArray();
            charArray1 = charArray1.OrderBy(c => c).ToArray();

            char[] charArray2 = str2.ToCharArray();
            charArray2 = charArray2.OrderBy(c => c).ToArray();

            // Compare the sorted character arrays
            return charArray1.SequenceEqual(charArray2);
        }

        static string CompressString(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            char currentChar = input[0];
            int count = 1;
            string result = string.Empty;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == currentChar)
                {
                    count++;
                }
                else
                {
                    result += currentChar + (count > 1 ? count.ToString() : string.Empty);
                    currentChar = input[i];
                    count = 1;
                }
            }

            // Append the last character and its count
            result += currentChar + (count > 1 ? count.ToString() : string.Empty);

            // Return the compressed string only if it's shorter than the original
            return result.Length < input.Length ? result : input;
        }

        static string CaesarCipher(string text, int shift)
        {
            string result = string.Empty;

            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    char offset = char.IsUpper(c) ? 'A' : 'a';
                    char encryptedChar = (char)(((c + shift - offset) % 26) + offset);
                    result += encryptedChar;
                }
                else
                {
                    result += c; // Non-letter characters remain unchanged
                }
            }

            return result;
        }

        static bool IsPalindrome(string sentence)

        {
            // Remove spaces, punctuation, and convert to lowercase
            string cleaned = new string(sentence.Where(char.IsLetterOrDigit).ToArray()).ToLower();

            // Compare the cleaned string with its reverse
            string reversed = new string(cleaned.Reverse().ToArray());

            return cleaned == reversed;
        }

        static List<string> GeneratePermutations(string str)
        {
            var result = new List<string>();
            Permute(str.ToCharArray(), 0, str.Length - 1, result);
            return result;
        }

        static void Permute(char[] chars, int left, int right, List<string> result)
        {
            if (left == right)
            {
                result.Add(new string(chars));
            }
            else
            {
                for (int i = left; i <= right; i++)
                {
                    Swap(ref chars[left], ref chars[i]);
                    Permute(chars, left + 1, right, result);
                    Swap(ref chars[left], ref chars[i]); // Backtrack
                }
            }
        }

        static void Swap(ref char a, ref char b)
        {
            char temp = a;
            a = b;
            b = temp;
        }

        static bool ContainsUpper(string input)
        {
            foreach (char c in input)
            {
                if (char.IsUpper(c))
                    return true;
            }
            return false;
        }

        static bool ContainsLower(string input)
        {
            foreach (char c in input)
            {
                if (char.IsLower(c))
                    return true;
            }
            return false;
        }

        static bool ContainsDigit(string input)
        {
            foreach (char c in input)
            {
                if (char.IsDigit(c))
                    return true;
            }
            return false;
        }

    }
}