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
    //Auxiliary space approach
	public IList<int> FindDuplicatesAuxiliary(int[] nums) {

        //Hold duplicates
        var res = new List<int>();

        // our variable that is going to help us manipulate the array
        int index;

        for(int i = 0; i < nums.Length; i++){

            //map our number to its 0 based index 
            index = Math.Abs(nums[i]) - 1;
            
            if(nums[index] < 0){
                res.Add(index + 1);
            }else{
                nums[index] = -nums[index];
            }
        }

        return res;
        
    }
    
}
