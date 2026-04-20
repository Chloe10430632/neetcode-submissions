public class Solution {
    public bool hasDuplicate(int[] nums) {
        // int count = 0;
        // foreach (int i in nums) {
        //     for (int j = 0; j < nums.Length; j++) {
        //         if (nums[j] == i) {
        //             count++;
        //         }
        //     }
        // }

        // if (count >= nums.Length+1) {
        //     return true;
        // } else {
        //     return false;
        // }

        HashSet<int> seen = new HashSet<int>();
        foreach (int num in nums) {
            if (seen.Contains(num)) {
                return true;
            }
            seen.Add(num);
        }
        return false;
    }
}