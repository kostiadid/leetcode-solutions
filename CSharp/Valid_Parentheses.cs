public class Solution {
    public bool IsValid(string s) {
        Dictionary<char, char> mirror = new Dictionary<char, char>()
        {
            { '(', ')' },
            { '{', '}' },
            { '[', ']' },
        };
        var stack = new Stack<char>();
         foreach(char c in s)
        {
            if(mirror.ContainsKey(c)){
                stack.Push(c);  // if key put in  stack 
            }
            else {
                if (stack.Count==0) return false; 
                if(mirror[stack.Pop()]!= c) return false;  // key != value
            }
        }
        return stack.Count==0;
    }
}
// https://leetcode.com/problems/valid-parentheses/description/


// Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

// An input string is valid if:

// Open brackets must be closed by the same type of brackets.
// Open brackets must be closed in the correct order.
// Every close bracket has a corresponding open bracket of the same type.
 

// Example 1:

// Input: s = "()"

// Output: true

// Example 2:

// Input: s = "()[]{}"

// Output: true

// Example 3:

// Input: s = "(]"

// Output: false

// Example 4:

// Input: s = "([])"

// Output: true

 

// Constraints:

// 1 <= s.length <= 104
// s consists of parentheses only '()[]{}'.
