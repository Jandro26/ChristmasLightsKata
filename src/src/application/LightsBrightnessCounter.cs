using ChristmasLightsKata.src.domain;

namespace ChristmasLightsKata.src.application
{
    public class LightsBrightnessCounter
    {
        public int Execute()
        {
            var lightGrid = new LightGrid();
            return lightGrid.CountLightsBrightness();
        }
    }
}
