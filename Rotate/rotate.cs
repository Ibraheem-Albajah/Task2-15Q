public class Solution {
    public void Rotate(int[] nums, int k) {
 k %= nums.Length;

            Queue<int> replaces = new Queue<int>(k);

            for (int i = 0; i < k; i++)
            {
                replaces.Enqueue(nums[nums.Length - k + i]);
            }

            int[] result = new int[nums.Length];

            for (int i = 0; i < k; i++)
            {
                result[i] = replaces.Dequeue();
            }

            for (int i = 0; i < result.Length - k; i++)
            {
                result[k + i] = nums[i];
            }

            Array.Copy(result, nums, nums.Length);
    }
}