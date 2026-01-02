using System;

namespace ConsoleApp
{
    public class StringData
    {
        public event Action<int> VowelsCounted;
        public event Action<int> ConsonantsCounted;
        public event Action<int> LengthCounted;

        private string _text;

        public string Text
        {
            get => _text;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Text cannot be empty");
                _text = value;
            }
        }

        public StringData(string text)
        {
            Text = text;
        }

        public int CountVowels()
        {
            int count = 0;
            string vowels = "AEIOUaeiou";
            foreach (char c in _text)
            {
                if (vowels.Contains(c))
                    count++;
            }
            VowelsCounted?.Invoke(count);
            return count;
        }

        public int CountConsonants()
        {
            int count = 0;
            string vowels = "AEIOUaeiou";
            foreach (char c in _text)
            {
                if (char.IsLetter(c) && !vowels.Contains(c))
                    count++;
            }
            ConsonantsCounted?.Invoke(count);
            return count;
        }

        public int CountLength()
        {
            int len = _text.Length;
            LengthCounted?.Invoke(len);
            return len;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            StringData data = new StringData(input);
            
            data.VowelsCounted += sum => Console.WriteLine($"Vowels counted: {sum}");
            data.ConsonantsCounted += sum => Console.WriteLine($"Consonants counted: {sum}");
            data.LengthCounted += len => Console.WriteLine($"String length: {len}");

            data.CountVowels();
            data.CountConsonants();
            data.CountLength();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
