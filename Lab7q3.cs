using System;

class Program
{
    static void Main()
    {
        Func<double, double> discountCalculator = null;

        discountCalculator += price => price * 0.95;
        discountCalculator += price => price * 0.90;
        discountCalculator += price => price - 100;

        Console.Write("Введіть початкову ціну: ");
        double priceValue = Convert.ToDouble(Console.ReadLine());

        foreach (Func<double, double> func in discountCalculator.GetInvocationList())
        {
            priceValue = func(priceValue);
        }

        Console.WriteLine($"Кінцева ціна після знижок: {priceValue}");
    }
}