// Based on my "0118_Pascal's_Triangle" solution

public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        IList<IList<int>> pascalsTriangle = new List<IList<int>>();

        for (int i = 0; i < numRows; i++){

            IList<int> row = new List<int>();

            for (int j = 0; j <= i; j++){
                if (j == 0 || j == i) row.Add(1);
                else row.Add(pascalsTriangle[i - 1][j - 1] + pascalsTriangle[i - 1][j]);
            }
        pascalsTriangle.Add(row);
        }
        return pascalsTriangle;
    }
}
