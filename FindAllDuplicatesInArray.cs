public class Solution {
    public IList<int> FindDuplicates(int[] nums) {

        //dictionary to store the numbers and frequency
        var dict = new Dictionary<int, int>();

        //Increase frequency
        foreach(var n in nums){
            if(dict.ContainsKey(n)){
                dict[n] = dict.GetValueOrDefault(n, 0) + 1;
            } else{
                dict[n] = 1;
            }
        }

        //loop through dict and add keys that have count greater than one into our result
        var res = new List<int>();

        foreach(var kvp in dict){
            if(kvp.Value > 1){
                res.Add(kvp.Key);
            }
        }

        return res;
        
    }
}