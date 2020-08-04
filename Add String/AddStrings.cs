public class Solution {
    public string AddStrings(string num1, string num2) {
int n = s.Length();
        String t = "";
        int i = 0;
        for(int j = 0; j <= n; j++) {
            if(j == n || s.charAt(j)==' '){
                StringBuilder sb = new StringBuilder();
                t += sb.append(s.substring(i,j)).reverse().toString()+" ";
                i = j+1;
            }
        }
        return t.trim();
    }
}