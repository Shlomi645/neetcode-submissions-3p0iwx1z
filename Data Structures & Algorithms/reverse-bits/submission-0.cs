public class Solution {
    public uint ReverseBits(uint n) {
        uint res = 0;
        for (int j = 0; j<32;j++){
            uint bit = n & 1;
            res = res << 1;
            res = res | bit;
            n = n >> 1;
        }
        return res;
    }
}
