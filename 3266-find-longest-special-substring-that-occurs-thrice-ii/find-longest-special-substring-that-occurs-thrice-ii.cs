public class Solution {
    public int MaximumLength(string s) {

        //similar to the last question but this time we want to also ensure the substring appears 3 times in the string 

        //substring can contain duplicates

        //1. substring must appear 3 times
        //2. return the substring size 
        //3. if no substring appears 3 times return -1;

        int n = s.Length;
    
        // Store frequency of each substring length for each character
        int[][] freq = new int[26][];
        for (int i = 0; i < 26; i++)
            freq[i] = new int[n + 2]; // +2 to avoid index issues
        
        // Find all runs
        int runLen = 1;
        for (int i = 1; i <= n; i++)
        {
            if (i < n && s[i] == s[i - 1])
            {
                runLen++;
            }
            else
            {
                char c = s[i - 1];
                int idx = c - 'a';                
                
                for (int len = 1; len <= runLen; len++)
                {
                    freq[idx][len] += runLen - len + 1;
                }
                
                runLen = 1;
            }
        }
        
        // Find maximum length with frequency >= 3
        int maxLen = -1;
        for (int i = 0; i < 26; i++)
        {
            for (int len = 1; len <= n; len++)
            {
                if (freq[i][len] >= 3)
                {
                    maxLen = Math.Max(maxLen, len);
                }
            }
        }
        
        return maxLen;
        
    }
}