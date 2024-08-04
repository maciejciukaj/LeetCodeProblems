namespace LeetCodeLearning
{
    public class _1460_Make_two_arrays_equal_by_reversing_subarrays
    {
        //1460. Make Two Arrays Equal by Reversing Subarrays
        public static bool CanBeEqual(int[] target, int[] arr)
        {
            Array.Sort(arr);
            Array.Sort(target);
            if (Enumerable.SequenceEqual(target, arr))
            {
                return true;
            }
            return false;
        }
    }
}
