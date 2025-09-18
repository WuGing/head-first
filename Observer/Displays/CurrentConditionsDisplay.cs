public class CurrentConditionsDisplay : IObserver, IDisplayElement
{
    private double temperature;
    private double humidity;
    private ISubject weatherData;

    public CurrentConditionsDisplay(WeatherData weatherData)
    {
        this.weatherData = weatherData;
        weatherData.RegisterObserver(this);
    }

    public void Update(double temperature, double humidity, double pressure)
    {
        this.temperature = temperature;
        this.humidity = humidity;
        Display();
    }

    public void Display()
    {
        Console.WriteLine($"Current conditions: {temperature}F degrees and {humidity}% humidity");
    }
}