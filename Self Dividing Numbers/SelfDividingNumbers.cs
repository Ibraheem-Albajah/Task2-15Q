public class Solution {
    public IList<int> SelfDividingNumbers(int left, int right) {
          List<int> result = new List<int>();
        for(int i = left; i <= right; i++){
            if(isSelfDividing(i)){
                result.Add(i);
            }
        }
        
        return result;
    }
    
    private bool isSelfDividing(int n){
      
        int actualNumber = n;
        while(n > 0){
            if(( n % 10 == 0) || (actualNumber % (n % 10) != 0)){
                return false;
            }
            n /= 10;
        }
        return true;
    }
    }
