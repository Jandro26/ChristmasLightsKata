﻿using ChristmasLightsKata.src.domain;

namespace ChristmasLightsKata.src.application
{
    public class CountLightsLit
    {

        public int Execute()
        {
            var lightGrid = new LightGrid();
            return lightGrid.CountLightLit();

        }
    }
}
