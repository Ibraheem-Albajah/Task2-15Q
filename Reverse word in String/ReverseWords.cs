
public class Solution {
    public string ReverseWords(string s) {
     string[] rev = s.Split();
        string res ="" ; 
        for(int i=0 ; i<rev.Length;i++){
          char[] charArray = rev[i].ToCharArray();                       Array.Reverse(charArray); 
           string ret = new string(charArray);
        res+=ret+" ";}
        
        
        
        
        
        return res.Trim();
    }
}