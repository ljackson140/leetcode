public class Solution {
    public int ArraySign(int[] nums) {

        var product = 1;

        foreach(int i in nums){
            if(i == 0) return 0;

            if(i < 0) product++;
        }

        return product % 2 == 0 ? -1 : 1;
        
    }

}