public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var complementMap = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            var complement = target - nums[i];

            if (complementMap.ContainsKey(complement)) {
                return new int[] {complementMap[complement], i};
            }

            complementMap[nums[i]] = i;
        }

        return new int[] {};
    }
}
