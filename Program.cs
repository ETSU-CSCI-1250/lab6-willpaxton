public class Program
{
    static void Main()
    {
        Console.WriteLine(ShowCharacter("New York", 2));
        Console.WriteLine($"\n{CalculateRetail(5.00, 50)}\n");

        for (double i = 80; i <= 100; i++)
            Console.WriteLine(Celsius(i));

        Console.WriteLine($"\n{IsPrime(4)}");
    }

    static char ShowCharacter(string text, int position)
    {
        return (text[position - 1]);
    }

    static string CalculateRetail(double cost, double percentage)
    {
        return (cost * (1 + (percentage / 100))).ToString("C");
    }

    static string Celsius(double fahrenheit)
    {
        double conversionRatio = 5.0 / 9.0;
        double cel = (fahrenheit - 32) * conversionRatio;
        return $"{fahrenheit}°F = {Math.Round(cel, 2)}°C";
    }

    static bool IsPrime(int num)
    {
        if (num <= 1)
        {
            return false;

        }

        for (int i = 2; i < num; i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}