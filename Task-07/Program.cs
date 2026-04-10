using System;
using System.Diagnostics;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("=== ASYNC CONCURRENT EXECUTION ===\n");

        var stopwatch = Stopwatch.StartNew();

        try
        {
            // Start all tasks concurrently
            var weatherTask = GetWeatherAsync();
            var stockTask = GetStockAsync();
            var userTask = GetUserAsync();

            // Wait for all to complete
            var results = await Task.WhenAll(weatherTask, stockTask, userTask);

            // Aggregate + Print results
            Console.WriteLine("\n--- Aggregated Results ---");
            Console.WriteLine($"Weather: {results[0]}");
            Console.WriteLine($"Stock:   {results[1]}");
            Console.WriteLine($"User:    {results[2]}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\n Error occurred: {ex.Message}");
        }

        stopwatch.Stop();
        Console.WriteLine($"\nTotal Time: {stopwatch.ElapsedMilliseconds} ms");
    }

    // Simulated API 1
    static async Task<string> GetWeatherAsync()
    {
        await Task.Delay(2000); // simulate delay
        return "Sunny 32°C";
    }

    // Simulated API 2
    static async Task<string> GetStockAsync()
    {
        await Task.Delay(3000); // simulate delay
        return "Market Up ";
    }

    // Simulated API 3 (with failure possibility)
    static async Task<string> GetUserAsync()
    {
        await Task.Delay(2500);

        // simulate random failure
        if (DateTime.Now.Second % 2 == 0)
        {
            throw new Exception("User API Failed");
        }

        return "User Active";
    }
}