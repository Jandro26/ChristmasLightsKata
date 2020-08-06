
namespace ChristmasLightsKata.src.domain
{
    public class SantaLightGridService
    {
        private readonly LightGrid lightGrid = new LightGrid();

        public LightGrid TurnOn()
        {
            TurnOnSantaFirstStep();
            TurnOnSantaSecondStep();
            TurnOnSantaThirdStep();

            return lightGrid;
        }
        private void TurnOnSantaFirstStep()
        {
            for (int i = 0; i <= lightGrid.GetRowsNumber() - 1; i++)
                for (int j = 0; j <= lightGrid.GetColumnsNumber() - 1; j++)
                    lightGrid.TurnOn(i, j);
        }

        private void TurnOnSantaSecondStep()
        {
            for (int k = 0; k <= lightGrid.GetColumnsNumber() - 1; k++)
                lightGrid.Toggle(0, k); ;
        }

        private void TurnOnSantaThirdStep()
        {
            for (int i = 499; i <= 500; i++)
                for (int j = 499; j <= 500; j++)
                    lightGrid.TurnOff(i, j); ;
        }
    }
}
