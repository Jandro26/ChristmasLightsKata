

namespace ChristmasLightsKata.src.domain
{
    public class LightGrid
    {
        private bool[,] lightGrid = new bool[1000,1000];

        public LightGrid()
        {
            for (int i = 0; i <= 999; i++)
                for (int j = 0; j <= 999; j++)
                    lightGrid[i, j] = true;

            for (int k = 0; k <= 999; k++)
                lightGrid[0, k] = !lightGrid[0, k];

            for (int i = 499; i <= 500; i++)
                for (int j = 499; j <= 500; j++)
                    lightGrid[i, j] = false;
        }

        public int CountLightLit()
        {
            var count = 0;
            for (int i = 0; i <= 999; i++)
                for (int j = 0; j <= 999; j++)
                    if (lightGrid[i, j])
                        count++;

            return count;
        }

    }
}
