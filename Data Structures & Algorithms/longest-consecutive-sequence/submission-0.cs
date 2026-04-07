public class Solution {
    public int LongestConsecutive(int[] nums) {
        var longest = 0;
        var numsSet = new HashSet<int>();
        foreach (var num in nums){
            if (!numsSet.Contains(num)){
                numsSet.Add(num);
            }
        }
        foreach (var n in numsSet) {
            if (!numsSet.Contains(n - 1)){
                var length = 0;
                while (numsSet.Contains(n + length)){
                    length += 1;
                }
                if (length > longest){
                    longest = length;
                }
            }
        }
        return longest;
    }
}
