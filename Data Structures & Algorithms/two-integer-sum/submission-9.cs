public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // 數字,索引
        Dictionary<int, int> numList = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            int diff = target - nums[i];

            if (numList.ContainsKey(diff)) {
                return new int[2]{numList[diff],i} ;
            }

            if (!numList.ContainsKey(nums[i])) {
                numList.Add(nums[i], i);
            }
        }
        return new int[0];
    }
}
