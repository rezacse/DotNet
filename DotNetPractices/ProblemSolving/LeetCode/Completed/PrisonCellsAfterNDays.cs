namespace Programming.LeetCode.July
{
    public class PrisonCellsAfterNDays
    {

        public int[] GetAfterNDays(int[] cells, int N)
        {
            CellIteration(cells, 1);

            int len = N > 7 ? N % 7 : N;
            if (len == 0) len = 7;


            for (int d = 2; d <= len; d++)
                CellIteration(cells, d);

            if (N % 14 == 0 || N % 14 > 7)
            {
                for (int i = 0; i < 4; i++)
                {
                    var t = cells[7 - i];
                    cells[7 - i] = cells[i];
                    cells[i] = t;
                }
            }


            //CellIteration(cells, 1);
            //int len = N > 14 ? N % 14 : N;
            //if (len == 0) len = 14;
            //for (int d = 2; d <= len; d++)
            //    CellIteration(cells, d);

            return cells;
        }

        private void CellIteration(int[] cells, int d)
        {
            int lCell = cells[0];
            for (int i = 1; i < 7; i++)
            {
                int newVal = (lCell ^ cells[i + 1]) == 0 ? 1 : 0;
                lCell = cells[i];
                cells[i] = newVal;
            }
            if (d > 1) return;

            cells[0] = 0;
            cells[7] = 0;
        }
    }
}
