using System;
using System.Collections.Generic;
using System.Text;

namespace RobotName {
    public class Robot
    {
        private const int NUMBER_OF_LETTER = 2;
        private const int NUMBER_OF_DIGIT = 3;
        private static int nameMaxCombination = (int)(Math.Pow(26, NUMBER_OF_DIGIT) * Math.Pow(10, NUMBER_OF_DIGIT));
        private static Random rnd = new Random();
        private static StringBuilder sb = new StringBuilder();
        private static HashSet<string> names = new HashSet<string>();
        private string _name;
        private string _tempName;

        public Robot() {
            Reset();
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public void Reset()
        {
            if (names.Count == nameMaxCombination)
            {
                throw new ArgumentOutOfRangeException("The number of generated names has reached the maximum possible combinations value!");
            }
        
            do
            {
                _tempName = $"{randomLetters()}{randomNumber()}";

            } while (names.Contains(_tempName));
            names.Add(_tempName);
            _name = _tempName;
        }

        private string randomLetters()
        {
            sb.Clear();
            for (int i = 0; i < NUMBER_OF_LETTER; i++)
            {
                sb.Append((char)rnd.Next('A', 'Z' + 1));
            }
            return sb.ToString();
        }


        private string randomNumber()
        {
            return rnd.Next(0, (int)Math.Pow(10, NUMBER_OF_DIGIT)).ToString("D3");
        }
    }
}