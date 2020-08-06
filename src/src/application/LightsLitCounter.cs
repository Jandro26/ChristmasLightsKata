using ChristmasLightsKata.src.domain;

namespace ChristmasLightsKata.src.application
{
    public class LightsLitCounter
    {
        public int Execute()
        {
            var lightGrid = new LightGrid();
            return lightGrid.CountLightLit();
        }
    }
}
