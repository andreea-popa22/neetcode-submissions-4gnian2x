public class Solution {
    public int Trap(int[] height) {
        if (height == null || height.Length == 0) {
            return 0;
        }

        int result = 0;
        int left = 0;
        int right = height.Length - 1;
        int maxLeft = height[left];
        int maxRight = height[right];

        while (left < right) {
            if (maxLeft < maxRight) {
                left += 1;
                maxLeft = Math.Max(maxLeft, height[left]);
                result = result + (maxLeft - height[left]);
            }
            else {
                right -= 1;
                maxRight = Math.Max(maxRight, height[right]);
                result = result + (maxRight - height[right]);
            }
        }

        return result;
    }
}
