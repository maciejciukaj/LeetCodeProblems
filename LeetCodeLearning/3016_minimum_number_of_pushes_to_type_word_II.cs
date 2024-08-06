//https://leetcode.com/problems/minimum-number-of-pushes-to-type-word-ii/description/
namespace LeetCodeLearning
{
    public class _3016_minimum_number_of_pushes_to_type_word_II
    {
        public static int MinimumPushes(string word)
        {
            Dictionary<char, int> numberOfLetters = new Dictionary<char, int>();
            foreach (var letter in word)
            {
                if (numberOfLetters.ContainsKey(letter))
                {
                    numberOfLetters[letter]++;
                }
                else
                {
                    numberOfLetters[letter] = 1;
                }
            }
            var sortedLetters = numberOfLetters.OrderByDescending(pair => pair.Value)
                                        .Select(pair => pair.Value)
                                        .ToList();
            int i = 0;
            int result = 0;
            foreach (var elem in sortedLetters)
            {
                result += elem * (i / 8 + 1);
                i++;
            }
            return result;
        }
    }
}
