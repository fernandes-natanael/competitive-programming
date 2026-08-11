// better solution
public class Solution {
    public int HammingWeight(uint n) {
        var countOne = 0;
        for (int i = 0; i < 32; ++i) {
            if (((1 << i) & n) != 0) 
            // Check creat 1 10 100 ...
            // Check each variation with n
            // Then if the and action generates a
            // number different of 0, so its a new 1
                countOne++;
        }
        return countOne;
    }
}

// my solution
// public class Solution {
//     public int HammingWeight(uint n) {
//         var countOne = 0;
//         while(n != 0) {
//             if((n & 1) == 1) countOne++;
//             n >>= 1;
//         }
//         return countOne;
//     }
// }
