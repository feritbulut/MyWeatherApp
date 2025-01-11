
```markdown
# MyWeatherApp

MyWeatherApp is a cross-platform weather application built with .NET MAUI. It allows users to view weather information for their current location or search for weather data in a specific city. The app uses OpenWeather API to fetch real-time weather updates.

## Features

- **Location-based Weather**: Automatically fetches weather data based on your current location.
- **Search by City**: Allows users to search for weather updates by entering a city name.
- **Detailed Weather Information**: Displays temperature, humidity, wind speed, and weather description.
- **Interactive UI**: Tap to refresh location data or search using the provided search button.
- **Weather Forecast**: Displays a 5-day weather forecast with detailed hourly information.

## Technologies Used

- **Framework**: .NET MAUI
- **API**: OpenWeather API
- **Language**: C#

## Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/MyWeatherApp.git
   ```
2. Open the project in Visual Studio 2022 or later.
3. Configure the `ApiService` to include your OpenWeather API key.
4. Build and run the application on your desired platform (iOS, Android, or Windows).

## How It Works

### Code Highlights

1. **Fetching Location:**
   ```csharp
   public async Task GetLocation()
   {
       var location = await Geolocation.GetLocationAsync();
       latitude = location.Latitude;
       longitude = location.Longitude;
   }
   ```

2. **Fetching Weather Data:**
   ```csharp
   public async Task GetWeatherDataByLocation(double latitude, double longitude)
   {
       var result = await ApiService.GetWeather(latitude, longitude);
       UpdateUI(result);
   }
   ```

3. **Updating UI:**
   ```csharp
   public void UpdateUI(dynamic result)
   {
       WeatherList = new List<Models.List>();
       foreach (var item in result.list)
       {
           WeatherList.Add(item);
       }
       CvWeather.ItemsSource = WeatherList;

       LblCity.Text = result.city.name;
       LblWeatherDescription.Text = result.list[0].weather[0].description;
       LblTemperature.Text = result.list[0].main.temperature + "°C";
       LblHumidity.Text = result.list[0].main.humidity + "%";
       LblWind.Text = result.list[0].wind.speed + "km/h";
       ImageWeatherIcon.Source = result.list[0].weather[0].customIcon;
   }
   ```

### UI Design

The user interface is designed with a clean and interactive layout using .NET MAUI's `XAML`. Features include:
- A location button to fetch weather data for the current location.
- A search button to input a city name for weather data retrieval.
- A collection view to display hourly and daily weather forecasts.

## Contributing

1. Fork the repository.
2. Create a new branch for your feature (`git checkout -b feature-name`).
3. Commit your changes (`git commit -m 'Add feature'`).
4. Push to the branch (`git push origin feature-name`).
5. Open a pull request.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

