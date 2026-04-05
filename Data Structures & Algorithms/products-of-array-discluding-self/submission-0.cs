public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var n = nums.Length;

        var prefixes = new int[n];
        prefixes[0] = 1;
        for (int i = 1; i < n; i++)
        {
            prefixes[i] = prefixes[i - 1] * nums[i - 1];
        }

        var sufixes = new int[n];
        sufixes[n - 1] = 1;
        for (int i = n - 2; i >= 0; i--)
        {
            sufixes[i] = sufixes[i + 1] * nums[i + 1];
        }

        var productExceptSelf = new int[n];
        for (int i = 0; i < n; i++)
        {
            productExceptSelf[i] = sufixes[i] * prefixes[i];
        }

        return productExceptSelf;
    }
}
