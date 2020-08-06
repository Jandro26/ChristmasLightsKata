

namespace ChristmasLightsKata.src.domain
{
    public class LightGrid
    {
        private const int ROW_SIZE = 1000;
        private const int COLUMN_SIZE = 1000;        
        private int[,] lightGrid = new int[ROW_SIZE, COLUMN_SIZE];

        public LightGrid()
        {
            TurnOnSantaFirstStep();
            TurnOnSantaSecondStep();
            TurnOnSantaThirdStep();
        }

        public int CountLightsBrightness()
        {
            var count = 0;
            for (int i = 0; i <= ROW_SIZE-1; i++)
                for (int j = 0; j <= COLUMN_SIZE-1; j++)
                    count += lightGrid[i, j];

            return count;
        }

        private void TurnOnSantaFirstStep()
        {
            for (int i = 0; i <= ROW_SIZE-1; i++)
                for (int j = 0; j <= COLUMN_SIZE-1; j++)
                    lightGrid[i, j] ++ ;
        }

        private void TurnOnSantaSecondStep()
        {
            for (int k = 0; k <= COLUMN_SIZE-1; k++)
                lightGrid[0, k] += 2;
        }

        private void TurnOnSantaThirdStep()
        {
            for (int i = 499; i <= 500; i++)
                for (int j = 499; j <= 500; j++)
                    if(lightGrid[i, j] > 0)
                        lightGrid[i, j] --;
        }

    }
}
