public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        IList<IList<int>> triangle = new List<IList<int>>();

        for(int i = 0; i < numRows; i++) {
            List<int> row = new List<int>();

            for(int j = 0; j <= i; j++) {
                // The first and last elements of each row are always 1
                if(j == 0 || j == i) {
                    row.Add(1);
                } else {
                    // Sum the two elements directly above from the previous
                    int leftAbove = triangle[i - 1][j - 1];
                    int rightAbove = triangle[i - 1][j];
                    row.Add(leftAbove + rightAbove);
                }
            }

            triangle.Add(row);
        }

        return triangle;
    }
}