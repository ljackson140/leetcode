public class Solution {
    public int[] PlusOne(int[] digits) {

        int n = digits.Length;

        /*
        Check value in the array indexes and update value by zero and 
        
        if end index value is 9 then update it "zero" and update previous index value by 1 if again previous index value is 9 then do same steps when previus index element is not 9 then add 1 to them and return array

        if every previous element is 9 till i>=0 at the 0 th index okay if all are 9,9,9,9, 
        in array the make another array and put 0th index value 1 and return if helpful then upvote me


        */

        for(int i = n - 1; i >= 0; i--){

            if(digits[i] < 9){
                digits[i]++;
                return digits;
            }

            digits[i] = 0;
        }

        var res = new int[n + 1];
        res[0] = 1;

        return res;
        
    }
}