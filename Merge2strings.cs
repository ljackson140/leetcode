public class Solution {
    public string MergeAlternately(string word1, string word2) {

        var merged = new StringBuilder();

        int top = 0;
        int bottom = 0;

        while(top < word1.Length && bottom < word2.Length){

            merged.Append(word1[top]);
            merged.Append(word2[bottom]);
            top++;
            bottom++;        
        }

        while(top < word1.Length){                       
            merged.Append(word1[top]);
            top++;       
        }

        while(bottom < word2.Length){                     
            merged.Append(word2[bottom]);          
            bottom++;        
        }

        return merged.ToString();
        
    }
}