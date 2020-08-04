public class Solution {
    public int Compress(char[] chars) {
  
        if(chars == null || chars.Length == 0)
            return 0;
        
        if(chars.Length == 1)
            return 1;
        
        int count = 1;
        int anchor = 1;
        
       for(int i = 1 ; i < chars.Length; i++)
        {
            if(chars[i] == chars[i - 1])
            {
                count++;
            }
            else
            {
                if(count == 1)
                {
                   chars[anchor++] = chars[i];
                   continue;
                }
                else
                {
                        char[] countArray = String.valueOf(count).toCharArray();

                        for(char c: countArray)
                        {
                          chars[anchor++] = c;
                        }

                        chars[anchor++] = chars[i];
                        count = 1;
                }
            }
        }
        
        if(count > 1)
        {
            char[] countArray = String.valueOf(count).toCharArray();

            for(char c: countArray)
            {
                chars[anchor++] = c;
            }
        }
        
        return anchor;
    }
    
}