public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        var sol = new List<List<int>>();
        for (int i = 0; i < nums.Length; i++){
            if (i != 0 && nums[i] == nums[i-1]) {
                continue;
            }
            var left = i + 1;
            var right = nums.Length - 1;
            while (left < right) {
                if(nums[i] + nums[left] + nums[right] < 0) {
                    left += 1;
                }
                else if (nums[i] + nums[left] + nums[right] > 0) {
                    right -= 1;
                }
                else {
                    sol.Add(new List<int>(){nums[i], nums[left], nums[right]});
                    left++;
                    right--;

                    while (left < right && nums[left] == nums[left - 1]) {
                        left++;
                    }

                    while (left < right && nums[right] == nums[right + 1]) {
                        right--;
                    }
                }
            }
        }
        return sol;
    }
}
