public class Solution {
    public bool IsValidSudoku(char[][] board) {
        //checks rows:
        HashSet<char>[] rows = new HashSet<char>[9];
        HashSet<char>[] cols = new HashSet<char>[9];
        HashSet<char>[] boxes = new HashSet<char>[9];

        for (int i = 0; i < 9; i++) {
            rows[i] = new HashSet<char>();
            cols[i] = new HashSet<char>();
            boxes[i] = new HashSet<char>();
        }

        for (int r = 0; r < 9 ; r++){
            for (int c = 0; c < 9 ; c ++){
                char cur = board[r][c];
                int boxIndex = (r/3) * 3 + (c/3);
                if (cur == '.'){
                    continue;
                }
                else{
                    if (rows[r].Contains(cur) || cols[c].Contains(cur) || boxes[boxIndex].Contains(cur)){
                        return false;
                    }
                    else{
                        rows[r].Add(cur);
                        cols[c].Add(cur);
                        boxes[boxIndex].Add(cur);
                    }
                }
            }
        }
        return true;
    }
}
