

namespace ChristmasLightsKata.src.domain
{
    public class LightGrid
    {
        private int[,] lightGrid = new int[1000,1000];

        public LightGrid()
        {
            TurnOnSantaFirstStep();
            TurnOnSantaSecondStep();
            TurnOnSantaThirdStep();
        }

        public int CountLightLit()
        {
            var count = 0;
            for (int i = 0; i <= 999; i++)
                for (int j = 0; j <= 999; j++)
                    count += lightGrid[i, j];

            return count;
        }

        private void TurnOnSantaFirstStep()
        {
            for (int i = 0; i <= 999; i++)
                for (int j = 0; j <= 999; j++)
                    lightGrid[i, j] ++ ;
        }

        private void TurnOnSantaSecondStep()
        {
            for (int k = 0; k <= 999; k++)
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
