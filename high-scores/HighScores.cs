using System.Collections.Generic;
using System.Linq;

namespace HighScores {
    public class HighScores
    {
        private List<int> _scores;
        public HighScores(List<int> list)
        {
            _scores = new List<int>(list);
        }

        public List<int> Scores()
        {
            return _scores;
        }

        public int Latest()
        {
            return _scores.Last();
        }

        public int PersonalBest()
        {
            return _scores.Max();
        }

        public List<int> PersonalTopThree()
        {
            if (_scores.Count > 2)
            {
                _scores = _scores.OrderByDescending(x => x).Take(3).ToList();
            }
            else
            {
                _scores = _scores.OrderByDescending(x => x).ToList();
            }
            return _scores;
        
        }
    }
}