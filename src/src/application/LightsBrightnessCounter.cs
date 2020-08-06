using ChristmasLightsKata.src.domain;

namespace ChristmasLightsKata.src.application
{
    public class LightsBrightnessCounter
    {
        private readonly SantaLightGridService santaLightGridService;

        public LightsBrightnessCounter()
        {
            santaLightGridService = new SantaLightGridService();
        }

        public int Execute()
        {
            var lightGrid = santaLightGridService.TurnOn();
            return lightGrid.CountLightsBrightness();
        }
    }
}
