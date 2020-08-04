public class Solution {
    public void MoveZeroes(int[] nums) {
       int count = 0;
        for(int i = 0;i < nums.Length; i++)
        {
            if(nums[i] == 0)
                count++;
            else if(count > 0)
            {
                swap(nums, i, i-count);
            }
        }
    }
    private void swap(int[] nums, int a, int b)
    {
        int temp = nums[a];
        nums[a] = nums[b];
        nums[b] = temp;
        
    }
}