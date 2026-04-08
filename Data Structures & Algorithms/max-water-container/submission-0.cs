public class Solution {
    public int MaxArea(int[] heights) {
        var maxAmount = 0;
        var left = 0;
        var right = heights.Length - 1;
        while (left < right) {
            var amount = Math.Min(heights[left], heights[right]) * (right - left);
            if (amount > maxAmount) {
                maxAmount = amount;
            }
            if (heights[left] < heights[right]){
                left += 1;
            }
            else {
                right -= 1;
            }
        }
        return maxAmount;
    }
}
