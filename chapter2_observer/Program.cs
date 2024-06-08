// See https://aka.ms/new-console-template for more information
using chapter2_observer;

Console.WriteLine("Hello, World!");
WeatherData weatherData = new WeatherData();
CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
weatherData.setMeasurements(80, 65, 30.4f);

