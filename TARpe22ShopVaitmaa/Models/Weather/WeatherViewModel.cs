﻿using TARpe22ShopVaitmaa.Core.Dto.WeatherDtos;

namespace TARpe22ShopVaitmaa.Models.Weather
{
    public class WeatherViewModel
    {
        public DateTime Date { get; set; }
        public int EpochDate { get; set; }
        public int Severity { get; set; }
        public string Text { get; set; }
        public string Category { get; set; }
        public Temperatures Temperature { get; set; }
        public DayNightCycles DayCycle { get; set; }
        public DayNightCycles NightCycle { get; set; }
        public List<string> Sources { get; set; }
        public string MobileLink { get; set; }
        public string Link { get; set; }
    }

    public class Temperatures
    {
        public Temperature Minimum { get; set; }
        public Temperature Maximum { get; set; }
    }

    public class DayNightCycles
    {
        public int Icon { get; set; }
        public string IconPhrase { get; set; }
        public bool HasPrecipitation { get; set; }
        public string PrecipitationType { get; set; }
        public string PrecipitationIntensity { get; set; }
    }
    public class Temperature
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }
}
