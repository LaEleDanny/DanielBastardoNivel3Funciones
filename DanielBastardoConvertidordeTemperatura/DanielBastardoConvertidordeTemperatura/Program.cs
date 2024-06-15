class Program
{
    static double CelsiusAFahrenheit(double celsius)
    {
        return (celsius);
    }
    static double FahrenheitACelsius(double fahrenheit)
    {
        return (fahrenheit * 9 / 5) +32; ;
    }
    static double CelsiusAKelvin(double celsius)
    {
        return celsius + 273.15;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Ingresa la temperatura en grados Celsius:");
        double temperaturaCelsius = double.Parse(Console.ReadLine());

        double temperaturaFahrenheit = FahrenheitACelsius(temperaturaCelsius);
        double temperaturaKelvin = CelsiusAKelvin(temperaturaCelsius);

        Console.WriteLine($"{temperaturaCelsius} °C equivale a {temperaturaFahrenheit} °F y {temperaturaKelvin} K");
    }
}
