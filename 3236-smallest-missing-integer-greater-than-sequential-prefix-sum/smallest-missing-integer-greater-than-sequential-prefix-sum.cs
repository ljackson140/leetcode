public class Solution {
    public int MissingInteger(int[] nums) {

        int n = nums.Length;

        //find longest prfix 1,2,3 from example
        int length = 1;
        while(length < n && nums[length] == nums[length - 1] + 1){
            length++;
        }

        //calculate sum
        int prefixSum = 0;
        for(int i = 0; i < length; i++){
            prefixSum += nums[i];
        }

        //find smallest missing number >= prefixSum
        var set = new HashSet<int>(nums);
        int result = prefixSum;

        while(set.Contains(result)){
            result++;
        }

        return result;
        
    }
}