public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        var left = 0;
        var right = numbers.Length - 1;
        while (left < right) {
            var sum = numbers[left] + numbers[right];
            if (sum < target) {
                left += 1;
            }
            else if (sum > target) {
                right -= 1;
            }
            else {
                return new int[] {left + 1, right + 1};
            }
        }
        return new int[]{};
    }
}
