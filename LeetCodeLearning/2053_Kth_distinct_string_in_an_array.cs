//https://leetcode.com/problems/kth-distinct-string-in-an-array/description/
namespace LeetCodeLearning
{
    internal class _2053_Kth_distinct_string_in_an_array
    {
        public static string KthDistinct(string[] arr, int k)
        {
            Dictionary<string, int> keyValuePairs = new Dictionary<string, int>(); ;
            foreach (var elem in arr)
            {
                if (keyValuePairs.ContainsKey(elem))
                {
                    keyValuePairs[elem]++;
                }
                else
                {
                    keyValuePairs[elem] = 1;
                }
            }

            foreach (var pair in keyValuePairs)
            {
                if (pair.Value == 1)
                {
                    k--;
                    if (k == 0)
                    {
                        return pair.Key;
                    }
                }
            }
            return "";
        }
    }
}
