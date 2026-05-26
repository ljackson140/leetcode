public class Solution {
    public void MoveZeroes(int[] nums) {

        int n = nums.Length;

        //cannot create a copy of the array so we know its O(1) auxiliary space 
        //we're moving zeros to the end, so we should start at index 1 

        //we'll need sort to hold the position of the first value and use the swap algorithm 

        int sort = 0;

        for(int i = 0; i < n; i++){
            if(nums[i] != 0){

                //hold current integer
                int temp = nums[i];

                //assign index 1 to = 0
                nums[i] = nums[sort];

                //assign index 0 to = temp
                nums[sort] = temp;
                sort++;
            }

        }
        
    }
}