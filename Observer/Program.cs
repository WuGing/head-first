WeatherData weatherData = new WeatherData();

CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);

weatherData.SetMeasurements(80, 65, 30.4);
weatherData.SetMeasurements(82, 70, 29.2);
weatherData.SetMeasurements(78, 90, 29.2);

// TODO: Maybe we build something to periodically get weather data from a web service