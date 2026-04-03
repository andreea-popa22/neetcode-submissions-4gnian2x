public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var n = nums.Length;
        var frequency = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            frequency[num] = frequency.GetValueOrDefault(num, 0) + 1;
        }

        var map = new Dictionary<int, List<int>>();
        foreach (var pair in frequency) {
            var num = pair.Key;
            var freq = pair.Value;

            if (!map.ContainsKey(freq)){
                map[freq] = new List<int>();
            }
            map[freq].Add(num);
        }

        var res = new List<int>();
        for (int freq = n; freq >= 1 && res.Count < k; freq--)
        {
            if (!map.ContainsKey(freq)) continue;

            foreach (var num in map[freq])
            {
                res.Add(num);
                if (res.Count == k)
                {
                    return res.ToArray();
                }
            }
        }

        return res.ToArray();
    }
}
