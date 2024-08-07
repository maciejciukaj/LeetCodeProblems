//https://leetcode.com/problems/zigzag-conversion/description/
using System.Text;

namespace LeetCodeLearning
{
    public class _6_Zigzag_conversion
    {
        public static string Convert(string s, int numRows)
        {
            if (numRows == 1)
                return s;

            Dictionary<int, List<char>> keyValuePairs = new Dictionary<int, List<char>>();
            int rowIterator = 0;
            bool direction = false;

            foreach (char c in s)
            {
                if (!keyValuePairs.ContainsKey(rowIterator))
                {
                    keyValuePairs[rowIterator] = new List<char>();
                }

                keyValuePairs[rowIterator].Add(c);

                if (rowIterator == 0 || rowIterator == numRows - 1)
                    direction = !direction;

                rowIterator += direction ? 1 : -1;
            }

            StringBuilder newString = new StringBuilder();

            foreach (var pair in keyValuePairs)
            {
                foreach (char c in pair.Value)
                {
                    newString.Append(c);
                }
            }

            return newString.ToString();
        }
    }
}
