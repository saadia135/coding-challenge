using System;

class Program
{
    static void Main()
    {
        int firstFahrenheit = 102;
        decimal firstCelsius = ((firstFahrenheit - 32) * 5m / 9);
        Console.WriteLine($"Converted Temperature: {firstCelsius:F1} °C"); // One decimal place

        int secondFahrenheit = 76;
        decimal secondCelsius = ((secondFahrenheit - 32m) * 5m / 9m);
        Console.WriteLine($"Converted Temperature: {Math.Round(secondCelsius, 3)} °C"); // Three decimal places

        int thirdFahrenheit = 60;
        decimal thirdCelsius = ((thirdFahrenheit - 32m) * 5m / 9m);
        Console.WriteLine($"Converted Temperature: {Math.Round(thirdCelsius)} °C"); // Rounded to nearest integer

        int fourthFahrenheit = 90;
        decimal fourthCelsius = (fourthFahrenheit - 32m) * (decimal)0.5556; // Using a different formula for conversion
        Console.WriteLine($"Converted Temperature: {fourthCelsius:N2} °C"); // Two decimal places, formatted number
    }
}

