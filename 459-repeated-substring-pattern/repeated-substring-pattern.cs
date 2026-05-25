public class Solution {
    public bool RepeatedSubstringPattern(string s) {

        int n = s.Length;

        //start at 1 because a pattern must atleast have 1 character
        //loop through half of the string, if the pattern is more than half the string then return false 
        for(int len = 1; len <= n / 2; len++){

            //check if the string is divisible by the first character
            if(n % len == 0){

                //extract the pattern "a" for example
                var pattern = s.Substring(0, len);

                //flag to check if pattern is repeatable
                var isValid = true;

                //loop through each segment after the first pattern
                for(int i = len; i < n; i += len){
                    
                    //"b" != "a", it will break and we'll go through the loop again and check if "ab" != "ab"
                    if(s.Substring(i, len) != pattern){

                        isValid = false;
                        break;
                    }
                }

                if(isValid) return true;
            }
        }

        

        return false;
        
    }
}