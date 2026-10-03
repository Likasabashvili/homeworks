namespace homework2.Models;

public class Temperature
{
    public double Quantity { get; set; }
    public string UnitOfMeasurment { get; set; }

    public Temperature(double quantity, string unitOfMeasurment)
    {
        Quantity = quantity;
        UnitOfMeasurment = unitOfMeasurment;
    }

    // gadaviyvanot celsiusshi
    public double ToCelsius()
    {
        if (UnitOfMeasurment == "C")
        {
            return Quantity;
        }

        if (UnitOfMeasurment == "F")
        {
            return (Quantity - 32) * 5 / 9;
        }

        throw new ArgumentException("ზომის ერთეული უნდა იყოს C ან F!");
    }

    public static Temperature operator +(Temperature a, Temperature b)
    {
        double result = a.ToCelsius() + b.ToCelsius();
        return new Temperature(result, "C");
    }

    public static Temperature operator -(Temperature a, Temperature b)
    {
        double result = a.ToCelsius() - b.ToCelsius();
        return new Temperature(result, "C");
    }

    public static Temperature operator *(Temperature a, double number)
    {
        return new Temperature(a.Quantity * number, a.UnitOfMeasurment);
    }

    public static Temperature operator /(Temperature a, double number)
    {
        return new Temperature(a.Quantity / number, a.UnitOfMeasurment);
    }

    public static Temperature operator %(Temperature a, double number)
    {
        return new Temperature(a.Quantity % number, a.UnitOfMeasurment);
    }

    public static bool operator >(Temperature a, Temperature b)
    {
        return a.ToCelsius() > b.ToCelsius();
    }

    public static bool operator <(Temperature a, Temperature b)
    {
        return a.ToCelsius() < b.ToCelsius();
    }

    public static bool operator ==(Temperature a, Temperature b)
    {
        return a.ToCelsius() == b.ToCelsius();
    }

    public static bool operator !=(Temperature a, Temperature b)
    {
        return a.ToCelsius() != b.ToCelsius();
    }

    public static bool operator >=(Temperature a, Temperature b)
    {
        return a.ToCelsius() >= b.ToCelsius();
    }

    public static bool operator <=(Temperature a, Temperature b)
    {
        return a.ToCelsius() <= b.ToCelsius();
    }

    public override string ToString()
    {
        return Quantity + " " + UnitOfMeasurment;
    }
}
