public class WeatherData : ISubject
{
    private List<IObserver> observers;
    private double temperature;
    private double humidity;
    private double pressure;

    public WeatherData()
    {
        observers = new List<IObserver>();
    }

    public void RegisterObserver(IObserver o) 
    {
        observers.Add(o);
    }

    public void RemoveObserver(IObserver o) 
    {
        int i = observers.IndexOf(o);
        if (i >= 0) 
        {
            observers.RemoveAt(i);
        }
    }

    public void NotifyObservers()
    {
        observers.ForEach(observer => observer.Update(temperature, humidity, pressure));
    }

    /// <summary>
    /// This method is called whenever the measurements have been updated
    /// </summary>
    public void MeasurementsChanged() 
    {
        NotifyObservers();
    }

    public void SetMeasurements(double temperature, double humidity, double pressure) 
    {
        this.temperature = temperature;
        this.humidity = humidity;
        this.pressure = pressure;
        MeasurementsChanged();
    }
}