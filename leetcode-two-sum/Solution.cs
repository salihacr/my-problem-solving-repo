public class Solution {

    /// <summary>
    /// Brute force: Time Complexity: O(n^2), Space complexity: O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="target"></param>
    /// <returns>integer array of indices</returns>
    public int[] TwoSumBruteForce(int[] nums, int target) {
        
        int arrayLength = nums.Length;
        if(nums==null || arrayLength<2)
            return new int[]{};
              
        for(int i = 0; i < arrayLength; i++){        
            for(int j = i + 1; j < arrayLength; j++){
                int total = nums[i] + nums[j];
                if(total == target) return new int[]{ i, j };
            }   
        }
        return new int[]{};
    }    

    /// <summary>
    /// Using a Dictionary: Time Complexity: O(n), Space complexity: O(n)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="target"></param>
    /// <returns>integer array of indices</returns>
     public int[] TwoSumOptimized(int[] nums, int target) {
        
        int arrayLength = nums.Length;
        Dictionary < int, int > resultDictionary = new();

        if (nums == null || arrayLength < 2)
            return new int[]{};
        
        for (int i = 0; i < arrayLength; i++) {
            int firstNumber = nums[i];
            int secondNumber = target - firstNumber;
            if (resultDictionary.TryGetValue(secondNumber, out int index)) {
                return new [] { index, i };
            }
            resultDictionary[firstNumber] = i;
        }
        return new int[]{};
    }   
}