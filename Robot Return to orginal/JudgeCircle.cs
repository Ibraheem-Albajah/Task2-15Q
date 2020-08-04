public class Solution {
    public bool JudgeCircle(string moves) {
        int upOrDown = 0 ;
        int rigthOrLeft = 0 ; 
for(int i=0 ; i<moves.Length ; i++)        {
            switch (moves[i])
            {
                case 'U':
                    upOrDown++;
                    break;
                case 'D':
                    upOrDown--;
                    break;
                case 'L':
                    rigthOrLeft++;
                    break;
                case 'R':
                    rigthOrLeft--;
                    break;
                        default:
                    break;
            }
        }
        
        return upOrDown == 0 && rigthOrLeft == 0;
    }
}