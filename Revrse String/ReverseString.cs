public class Solution {
    public void ReverseString(char[] s) {
         int i,j;  
         char t;
        for(i=0,j=s.Length-1;i<s.Length/2;i++,j--)
            {
             t=s[i];
             s[i]=s[j];
             s[j]=t;
             
        } 
        
    }
}