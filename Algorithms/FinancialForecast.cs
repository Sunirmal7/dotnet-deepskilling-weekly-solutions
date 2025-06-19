namespace Week1Exercises.Algorithms
{
    public static class FinancialForecast
    {
        public static List<decimal> MovingAverageForecast(List<decimal> prices, int window, int forecastDays)
        {
            var forecast = new List<decimal>();

            for (int i = 0; i < forecastDays; i++)
            {
                var recent = prices.TakeLast(window).ToList();
                decimal average = recent.Sum() / window;
                forecast.Add(average);
                prices.Add(average); // simulate the forecast
            }

            return forecast;
        }
    }
}
