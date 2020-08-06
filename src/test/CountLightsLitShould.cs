using ChristmasLightsKata.src.application;
using Xunit;

namespace ChristmasLightsKataTest
{
    public class CountLightsLitShould
    {
        private const int EXPECTED_LIGHT_BRIGHTNESS = 1000000 + 2000 - 4;

        [Fact]
        public void It_should_get_the_number_of_lights_lit()
        {
            var expectedLightLit = EXPECTED_LIGHT_BRIGHTNESS;

            var countLightsLit = new LightsLitCounter();
            var lightLit = countLightsLit.Execute();

            Assert.True(expectedLightLit == lightLit);
        }

    }
}
