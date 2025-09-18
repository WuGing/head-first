public class ForecastDisplay : IObserver, IDisplayElement
{
    private double currentPressure;
    private double lastPressure;
    private ISubject weatherData;

    public ForecastDisplay(ISubject weatherData)
    {
        this.weatherData = weatherData;
        weatherData.RegisterObserver(this);
    }

    public void Update(double temp, double humidity, double pressure)
    {
        lastPressure = currentPressure;
        currentPressure = pressure;
        Display();
    }

    public void Display()
    {
        string forecastDisplay = GetForecast();
        Console.WriteLine($"Forecast: {forecastDisplay}");
    }

    private string GetForecast()
    {
        if (currentPressure > lastPressure)
        {
            return "Improving weather on the way!";
        }
        else if (currentPressure == lastPressure)
        {
            return "More of the same";
        }
        else
        {
            return "Watch out for cooler, rainy weather";
        }
    }
}