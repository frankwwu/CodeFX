using CodeFX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFX.Services
{
    public class WeatherForecastService
    {
        public static readonly Summary[] Summaries = new Summary[]
        {
           new Summary(){Id = 1, Name ="Freezing" }, new Summary(){Id = 2, Name ="Bracing" }, new Summary(){Id = 3, Name ="Chilly" }, new Summary(){Id = 4, Name ="Cool" },
            new Summary(){Id = 5, Name ="Mild" }, new Summary(){Id = 6, Name ="Warm" }, new Summary(){Id = 7, Name ="Balmy" }, new Summary(){Id = 8, Name ="Hot" },
            new Summary(){Id = 9, Name ="Sweltering" }, new Summary(){Id = 10, Name ="Scorching" }
        };

        public static Task<List<WeatherForecast>> GetForecastAsync(DateTime startDate)
        {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 8).Select(index => new WeatherForecast
            {
                Id = index,
                Date = startDate.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)].Name
            }).ToList());
        }
    }
}
