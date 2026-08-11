public class Solution {
    public int HammingWeight(uint n) {
        var countOne = 0;
        while(n != 0) {
            if((n & 1) == 1) countOne++;
            n >>= 1;
        }
        return countOne;
    }
}
