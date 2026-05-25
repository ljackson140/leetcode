public class Solution {
    public int StrStr(string haystack, string needle) {

        int h = haystack.Length;
        int n = needle.Length;

        //2 strings to find the index of where needle starts in haystack        
        
        //loop through haystack
        for(int i = 0; i <= h - n; i++){

            //using our counter to check if we've matched with needle
            var count = 0;

            while(count < n && haystack[i + count] == needle[count]){
                count++;
            }

            if(count == n){
                return i;
            }
             
        }

        

        return -1;
        
    }
}