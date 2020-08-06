using ChristmasLightsKata.src.application;
using Xunit;

namespace ChristmasLightsKataTest
{
    public class CountLightsLitShould
    {
        [Fact]
        public void It_should_get_the_number_of_lights_lit()
        {
            var expectedLightLit = 998996;

            var countLightsLit = new CountLightsLit();
            var lightLit = countLightsLit.Execute();

            Assert.True(expectedLightLit == lightLit);
        }
    }
}
