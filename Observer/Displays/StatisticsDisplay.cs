public class StatisticsDisplay : IObserver, IDisplayElement
{
    private double maxTemp;
    private double minTemp;
    private double tempSum;
    private int numReadings;
    private ISubject weatherData;

    public StatisticsDisplay(ISubject weatherData)
    {
        this.weatherData = weatherData;
        weatherData.RegisterObserver(this);

        maxTemp = double.MinValue;
        minTemp = double.MaxValue;
        tempSum = 0;
        numReadings = 0;
    }

    public void Update(double temperature, double humidity, double pressure)
    {
        tempSum += temperature;
        numReadings++;

        if (temperature > maxTemp) 
        {
            maxTemp = temperature;
        }

        if (temperature < minTemp) 
        {
            minTemp = temperature;
        }

        Display();
    }

    public void Display()
    {
        Console.WriteLine($"Avg/Max/Min temperature = {tempSum/numReadings}/{maxTemp}/{minTemp}");
    }

}