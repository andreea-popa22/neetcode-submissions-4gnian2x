public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var rows = new Dictionary<int, HashSet<char>>();
        var cols = new Dictionary<int, HashSet<char>>();
        var squares = new Dictionary<(int, int), HashSet<char>>();
        for (int i=0; i<9; i++){
            for (int j=0; j<9; j++){
                var element = board[i][j];
                if (element == '.'){
                    continue;
                }

                if (!rows.ContainsKey(i)) rows[i] = new HashSet<char>();
                if (!cols.ContainsKey(j)) cols[j] = new HashSet<char>();
                if (!squares.ContainsKey((i/3,j/3))) squares[(i/3,j/3)] = new HashSet<char>();

                if (rows[i].Contains(element) 
                || cols[j].Contains(element) 
                || squares[(i/3,j/3)].Contains(element)){
                    return false;
                }

                rows[i].Add(element);
                cols[j].Add(element);
                squares[(i/3,j/3)].Add(element);
            }
        }
        return true;
    }
}
