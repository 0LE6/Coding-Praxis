// Improved version using Stack (More efficient)

public class Solution {
    public bool IsValid(string s) {
        Stack<char> cStack = new Stack<char>();
        bool valid = true;
        foreach (char c in s){
            if (c.Equals('(') || c.Equals('[') || c.Equals('{'))
                cStack.Push(c);
            else if (c.Equals(')')){
                if (cStack.Count != 0 && cStack.Peek().Equals('(')) cStack.Pop();
                else valid = false;
            }
            else if (c.Equals(']')){
                if (cStack.Count != 0 && cStack.Peek().Equals('[')) cStack.Pop();
                else valid = false;
            }
            else if (c.Equals('}')){
                if (cStack.Count != 0 && cStack.Peek().Equals('{')) cStack.Pop();
                else valid = false;
            }
        }
        return cStack.Count == 0 && valid;
    }
}

/* Poor first version (Valid anyways):
public class Solution {
    public bool IsValid(string s) {
        while(s.Contains("()") || s.Contains("[]") || s.Contains("{}"))
            s = s.Replace("()","").Replace("[]","").Replace("{}","");
        return s.Length == 0;
    }
}
*/
