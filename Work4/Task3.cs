using System.Text;

namespace System
{
    public static class Task3
    {
        private static readonly Dictionary<char, string?> Map = new Dictionary<char, string?>
        {
            {'A', ".-"}, {'B', "-..."}, {'C', "-.-."}, {'D', "-.."}, {'E', "."},
            {'F', "..-."}, {'G', "--."}, {'H', "...."}, {'I', ".."}, {'J', ".---"},
            {'K', "-.-"}, {'L', ".-.."}, {'M', "--"}, {'N', "-."}, {'O', "---"},
            {'P', ".--."}, {'Q', "--.-"}, {'R', ".-."}, {'S', "..."}, {'T', "-"},
            {'U', "..-"}, {'V', "...-"}, {'W', ".--"}, {'X', "-..-"}, {'Y', "-.--"},
            {'Z', "--.."}, {'0', "-----"}, {'1', ".----"}, {'2', "..---"}, {'3', "...--"},
            {'4', "....-"}, {'5', "....."}, {'6', "-...."}, {'7', "--..."}, {'8', "---.."},
            {'9', "----."}, {'.', ".-.-.-"}, {',', "--..--"}, {'?', "..--.."}, {'\'', ".----."},
            {'!', "-.-.--"}, {'/', "-..-."}, {'(', "-.--."}, {')', "-.--.-"}, {'&', ".-..."},
            {':', "---..."}, {';', "-.-.-."}, {'=', "-...-"}, {'+', ".-.-."}, {'-', "-....-"},
            {'_', "..--.-"}, {'"', ".-..-."}, {'$', "...-..-"}, {'@', ".--.-."}
        };

        public static void Run(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                Console.WriteLine("No input text");
                return;
            }

            var sb = new StringBuilder();
            var words = text.Split([' '], StringSplitOptions.RemoveEmptyEntries);

            for (int w = 0; w < words.Length; w++)
            {
                string word = words[w];
                for (int i = 0; i < word.Length; i++)
                {
                    char c = char.ToUpperInvariant(word[i]);
                    if (Map.TryGetValue(c, out string? morse)) sb.Append(morse);
                    else sb.Append('?');
                    if (i < word.Length - 1) sb.Append(' ');
                }
                if (w < words.Length - 1) sb.Append(" / ");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
