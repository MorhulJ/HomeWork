using System.Text;

namespace System
{
    public static class Task4
    {
        private static readonly Dictionary<string, char> MorseToText = new Dictionary<string, char>
        {
            {".-", 'A'}, {"-...", 'B'}, {"-.-.", 'C'}, {"-..", 'D'}, {".", 'E'},
            {"..-.", 'F'}, {"--.", 'G'}, {"....", 'H'}, {"..", 'I'}, {".---", 'J'},
            {"-.-", 'K'}, {".-..", 'L'}, {"--", 'M'}, {"-.", 'N'}, {"---", 'O'},
            {".--.", 'P'}, {"--.-", 'Q'}, {".-.", 'R'}, {"...", 'S'}, {"-", 'T'},
            {"..-", 'U'}, {"...-", 'V'}, {".--", 'W'}, {"-..-", 'X'}, {"-.--", 'Y'},
            {"--..", 'Z'}, {"-----", '0'}, {".----", '1'}, {"..---", '2'}, {"...--", '3'},
            {"....-", '4'}, {".....", '5'}, {"-....", '6'}, {"--...", '7'}, {"---..", '8'},
            {"----.", '9'}, {".-.-.-", '.'}, {"--..--", ','}, {"..--..", '?'}, {".----.", '\''},
            {"-.-.--", '!'}, {"-..-.", '/'}, {"-.--.", '('}, {"-.--.-", ')'}, {".-...", '&'},
            {"---...", ':'}, {"-.-.-.", ';'}, {"-...-", '='}, {".-.-.", '+'}, {"-....-", '-'},
            {"..--.-", '_'}, {".-..-.", '"'}, {"...-..-", '$'}, {".--.-.", '@'}
        };

        public static void Run(string morse)
        {
            if (string.IsNullOrEmpty(morse))
            {
                Console.WriteLine("No input text");
                return;
            }

            var sb = new StringBuilder();
            var words = morse.Split(" / ", StringSplitOptions.RemoveEmptyEntries);

            for (int w = 0; w < words.Length; w++)
            {
                string[] letters = words[w].Split(' ', StringSplitOptions.RemoveEmptyEntries);
                foreach (string letter in letters)
                    sb.Append(MorseToText.GetValueOrDefault(letter, '?'));

                if (w < words.Length - 1) sb.Append(' ');
            }

            Console.WriteLine(sb.ToString());
        }
    }
}