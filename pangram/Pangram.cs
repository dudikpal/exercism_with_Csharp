namespace Pangram {
    public static class Pangram
    {
        private static string letters = "abcdefghijklmnopqrstuvwxyz";
        public static bool IsPangram(string input)
        {
            if (input == "")
            {
                return false;
            }
            foreach (char letter in letters)
            {
                if (!input.ToLower().Contains(letter.ToString()))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
