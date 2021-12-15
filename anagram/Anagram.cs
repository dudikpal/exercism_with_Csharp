using System;
using System.Collections.Generic;
using System.Linq;

public class Anagram
{

    private string baseWord;
    private Dictionary<char, int> baseMap;
    private List<string> anagrams;
    public Anagram(string baseWord)
    {
        this.baseWord = baseWord;
        baseMap = stringToMap(baseWord);
        anagrams = new List<string>();
    }

    public string[] FindAnagrams(string[] potentialMatches)
    {
        foreach (string word in potentialMatches)
        {
            if (baseWord.ToLower().Equals(word.ToLower()))
            {
                continue;
            }
            Dictionary<char, int> temp = stringToMap(word);
            if (baseMap.Count == temp.Count &&
                !baseMap.Except(temp).Any())
            {
                anagrams.Add(word);
            }
        }

        return anagrams.ToArray();
    }


    private Dictionary<char, int> stringToMap(string input)
    {
        Dictionary<char, int> result = new Dictionary<char, int>();
        foreach (char letter in input.ToLower().ToCharArray())
        {
            if (result.TryGetValue(letter, out int val))
            {
                result[letter] += 1;
            }
            else
            {
                result.Add(letter, 1);
            }
        }

        return result;
    }
}