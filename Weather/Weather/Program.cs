using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Gebe deine gewünschte Stadt an:");
        string city = Console.ReadLine();

        Console.Clear();

        string apiKey = "apikeyhere";

            using (HttpClient client = new HttpClient())
            {
                string url = $"http://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric";
                HttpResponseMessage response = await client.GetAsync(url);
                string responseBody = await response.Content.ReadAsStringAsync();

                dynamic weatherData = JsonConvert.DeserializeObject(responseBody);

                float temperature = weatherData.main.temp;
                string weatherConditions = weatherData.weather[0].main;
                int humidity = weatherData.main.humidity;
                float windSpeed = weatherData.wind.speed;
                float windDirection = weatherData.wind.deg;
                int sunrise = weatherData.sys.sunrise;
                int sunset = weatherData.sys.sunset;
                int chanceOfRain = weatherData.clouds.all;
                float pressure = weatherData.main.pressure;

                Console.WriteLine("Wetter in " + city + ":");
                Console.WriteLine("---------------------");
                Console.WriteLine("Temperatur: " + temperature + "°C");
                Console.WriteLine("Wetterbedingungen: " + weatherConditions);
                Console.WriteLine("Luftfeuchtigkeit: " + humidity + "%");
                Console.WriteLine("Windgeschwindigkeit: " + windSpeed + " m/s");
                Console.WriteLine("Windrichtung: " + windDirection + "°");
                Console.WriteLine("Sonnenaufgang: " + DateTimeOffset.FromUnixTimeSeconds(sunrise).LocalDateTime.ToString("HH:mm"));
                Console.WriteLine("Sonnenuntergang: " + DateTimeOffset.FromUnixTimeSeconds(sunset).LocalDateTime.ToString("HH:mm"));
                Console.WriteLine("Niederschlagswahrscheinlichkeit: " + chanceOfRain + "%");
                Console.WriteLine("Luftdruck: " + pressure + " hPa");

       
                Console.ReadKey();
        }
    }
}
