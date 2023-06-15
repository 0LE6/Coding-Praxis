// Based on my "0118_Pascal's_Triangle" solution

public class Solution {
    public IList<int> GetRow(int rowIndex) {
        IList<int> row = new List<int>();
        
        for (int i = 0; i < rowIndex + 1; i++){
            IList<int> newRow = new List<int>();

            for (int j = 0; j <= i; j++){
                if (j == 0 || j == i) newRow.Add(1);
                else newRow.Add(row[j - 1] + row[j]);
            }
            row = newRow;
        }
        return row; 
    }
}
