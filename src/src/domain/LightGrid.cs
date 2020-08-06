

namespace ChristmasLightsKata.src.domain
{
    public class LightGrid
    {
        public const int GRID_ROWS_NUMBER = 1000;
        public const int GRID_COLUMNS_NUMBER = 1000;        
        private int[,] lightGrid = new int[GRID_ROWS_NUMBER, GRID_COLUMNS_NUMBER];

        public void TurnOn(int row, int column)
        => lightGrid[row, column]++;

        public void TurnOff(int row, int column)
        {
            if (lightGrid[row, column] > 0) lightGrid[row, column]--;
        }

        public void Toggle(int row, int column)
        => lightGrid[row, column] += 2;

        public int GetRowsNumber()
        => GRID_ROWS_NUMBER;

        public int GetColumnsNumber()
        => GRID_COLUMNS_NUMBER;

        public int CountLightsBrightness()
        {
            var count = 0;
            for (int i = 0; i <= GRID_ROWS_NUMBER - 1; i++)
                for (int j = 0; j <= GRID_COLUMNS_NUMBER - 1; j++)
                    count += lightGrid[i, j];

            return count;
        }
    }
}
