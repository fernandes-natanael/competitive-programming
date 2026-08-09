public class Solution {
    public int Search(int[] nums, int target) {
        var low = 0;
        var high = nums.Length -1;
        while(low <= high)
        {
            int mid = low + ((high - low) >> 1);
            if(nums[mid] == target) return mid;
            else if(nums[mid] > target) high = mid - 1;
            else low = mid + 1;
        }
        return -1;
    }
}
 