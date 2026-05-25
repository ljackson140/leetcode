public class Solution {
    public bool IsAnagram(string s, string t) {

        var counter = new int[26];

        foreach(var c in s){
            counter[c - 'a']++;
        }

        foreach(var c in t){
            counter[c - 'a']--;
        }

        foreach(var x in counter){
            if(x != 0){
                return false;
            }
        }

        return true;;
        
    }
}