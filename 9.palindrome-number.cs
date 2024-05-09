/*
 * @lc app=leetcode id=9 lang=csharp
 *
 * [9] Palindrome Number
 */

// @lc code=start
public class Solution {
    public bool IsPalindrome(int x) {
        string xString = x.ToString();

        if(xString.Length == 1){return true;}

        int inverseI = xString.Length;
        
        for(int i = 0; i < xString.Length / 2; i++){
            
            if(xString[i] != xString[inverseI - i - 1]){ return false;}
        }

        return true;
    }
}
// @lc code=end

