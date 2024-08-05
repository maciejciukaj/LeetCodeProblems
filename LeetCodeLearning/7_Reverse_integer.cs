//https://leetcode.com/problems/reverse-integer/description/
namespace LeetCodeLearning
{
    public class _7_Reverse_integer
    {
        //7. Reverse Integer
        public static int reverse(int x)
        {
            long newNum = 0, oldValue = x;
            x = (x > 0) ? x : (0 - x);
            while (x != 0)
            {
                newNum *= 10;
                newNum += x % 10;
                x /= 10;
                if (newNum > int.MaxValue || newNum < int.MinValue)
                    return 0;
            }
            if (oldValue > 0)
                return (int)newNum;
            else if (oldValue < 0)
                return (int)(newNum * (-1));
            else
                return 0;
        }
    }
}
