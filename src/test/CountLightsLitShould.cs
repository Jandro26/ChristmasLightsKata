using ChristmasLightsKata.src.application;
using Xunit;

namespace ChristmasLightsKataTest
{
    public class CountLightsLitShould
    {
        private const int EXPECTED_LIGHT_LIT = 998996;

        [Fact]
        public void It_should_get_the_number_of_lights_lit()
        {
            var expectedLightLit = EXPECTED_LIGHT_LIT;

            var countLightsLit = new CountLightsLit();
            var lightLit = countLightsLit.Execute();

            Assert.True(expectedLightLit == lightLit);
        }
    }
}
