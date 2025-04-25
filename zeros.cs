namespace Homework_9

    // written by Bobbi Lovstad
    // 4/25/25
{
    public class Program
    {
        public int MoveZeros(int[] nums)
        {
            int insertPos = 0;

            for ( int i = 0; i < nums.Length; i ++)
            {
                if (nums[i] != 0 )
                {
                    nums[insertPos] = nums[i];
                    insertPos++;
                }
            }

            while ( insertPos < nums.Length)
            {
                nums[insertPos] = 0;
                insertPos++;
            }

        }
    }
}

