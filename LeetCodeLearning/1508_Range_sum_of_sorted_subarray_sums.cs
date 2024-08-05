//https://leetcode.com/problems/range-sum-of-sorted-subarray-sums/description/
namespace LeetCodeLearning
{
    public class _1508_Range_sum_of_sorted_subarray_sums
    {
        //1508. Range Sum of Sorted Subarray Sums
        public static int RangeSum(int[] nums, int n, int left, int right)
        {
            const int MOD = 1000000007;
            List<int> allNums = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                for (int j = i; j < n; j++)
                {
                    sum += nums[j];
                    allNums.Add(sum);
                }
            }

            allNums.Sort();
            long result = 0;
            for (int i = left - 1; i < right; i++)
            {
                result = (result + allNums[i]) % MOD;
            }
            return (int)result;
        }
    }
}
