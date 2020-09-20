using System;
namespace playground
{
    public class UniquePath1
    {
        public UniquePath1()
        {
        }

        public int GetUniquePath(int m, int n)
        {
            int count = 0;
            return traverse(0, 0, m, n, count);
        }
        public int traverse(int row, int column, int row_limit, int column_limit, int count)
        {
            if (row > row_limit-1 || column > column_limit-1)
            {
                return count;
            }
            if (row == row_limit-1 && column == column_limit-1)
            {
                count++;
            }

            count = traverse(row + 1, column, row_limit, column_limit, count);
            count = traverse(row, column + 1, row_limit, column_limit, count);
            return count;
        }
    }
}
