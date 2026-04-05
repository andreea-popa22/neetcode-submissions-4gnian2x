public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var n = nums.Length;

        var productExceptSelf = new int[n];
        productExceptSelf[0] = 1;
        for (int i = 1; i < n; i++)
        {
            productExceptSelf[i] = productExceptSelf[i - 1] * nums[i - 1];
        }

        var suffix = 1;
        for (int i = n - 1; i >= 0; i--)
        {
            productExceptSelf[i] *= suffix;
            suffix *= nums[i];
        }

        return productExceptSelf;
    }
}
