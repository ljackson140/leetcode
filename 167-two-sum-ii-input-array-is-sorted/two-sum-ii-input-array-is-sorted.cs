public class Solution {
    public int[] TwoSum(int[] numbers, int target) {

        //numbers is already sorted 1,2,3 etc

        //i'll need to find 2 numbers that equal to target

        //2 pointer approach so if left + right is more than target then we move the right pointer else less than target move left pointer

        //return new int[]{left + 1, right + 1};

        //only 1 solution 

        int n = numbers.Length;

        int left = 0;
        int right = n - 1;

        while(left < n){

            var sum = numbers[left] + numbers[right];
            if(sum == target){
                return new int[] {left + 1, right + 1};
            }
            else if(sum > target){
                right--;
            }
            else if(sum < target){
                left++;
            }else{
                right--;
                left++;
            }
        }

        return new int[]{0, 0};
        
    }
}