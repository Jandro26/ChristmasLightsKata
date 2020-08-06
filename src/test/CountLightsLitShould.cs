using ChristmasLightsKata.src.application;
using Xunit;

namespace ChristmasLightsKataTest
{
    public class CountLightsBrightnessShould
    {
        private const int EXPECTED_LIGHT_BRIGHTNESS = 1000000 + 2000 - 4;

        [Fact]
        public void It_should_get_the_lights_brightness()
        {
            var expectedLightBrightness = EXPECTED_LIGHT_BRIGHTNESS;

            var lightsBrightnessCounter = new LightsBrightnessCounter();
            var brightness = lightsBrightnessCounter.Execute();

            Assert.True(expectedLightBrightness == brightness);
        }

    }
}
