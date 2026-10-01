namespace homework1.Models;

public class Car
{
    public Car(int year, double engineCapacity, string brand, string model, CarColor color)
    {
        _year = year;
        _engineCapacity = engineCapacity;
        Brand = brand;
        Model = model;
        Color = color;
    }

    public string Brand { get; set; }
    public string Model { get; set; }
    private int _year;

    public int Year
    {
        get { return _year; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Invalid year");
            }
            else
            {
                _year = value;
            }
        }
    }
    private double _engineCapacity;

    public double EngineCapacity
    {
        get
        {
            return _engineCapacity;
        } set
        {
            if (value <= 0 || value > 100)
            {
                Console.WriteLine("Invalid engine capacity");  
            }
            else
            {
                _engineCapacity = value;
            }
        }
    }

    public CarColor Color{ get; set; }

    public void GetCarInfo()
    {
        int realiseYear = DateTime.Now.Year - Year;
        Console.WriteLine($"Car was realised in : {realiseYear}");
    }

    public override string? ToString()
    {
        return $"Brand:{Brand}; Model: {Model}; Year: {Year}; EngineCapacity: {EngineCapacity}; Color: {Color}";
    }

    public enum CarColor
    {
        Red,
        Green,
        Blue,
        Yellow,
        Purple,
        Orange,
        White,
        Black,
        Other
    }
}