public class Solution {
    public char FindTheDifference(string s, string t) {

        //2 strings s and t
        //we only care about what was added to t

        var counter = new int[26];

        foreach(var c in s){
            //a = 1, b =1
            counter[c - 'a']++;
        }

        foreach(var c in t){
            var index = c - 'a';

            //we know that the extra letter is 0 in t;

            if(counter[index] == 0){
                return c;
            }else{
                counter[c - 'a']--;
            }
        }

        return t[0];        
    }
}