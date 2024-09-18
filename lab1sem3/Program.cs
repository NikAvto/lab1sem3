
using System.Diagnostics;

public class Rectangle
{
    private double sideA;
    private double sideB;

    public Rectangle(double sideA, double sideB)
    {
        this.sideA = sideA;
        this.sideB = sideB;
    }
    public double CalculateArea()
    {
        return sideA * sideB;
    }
    private double CalculatePerimeter()
    {
        return 2 * (sideA + sideB);
    }
    public double Area
    {
        get { return CalculateArea(); }
    }
    public double Perimeter
    {
        get { return CalculatePerimeter(); }
    }
}

public class Point
{
    private int x;
    private int y;
    public Point(int x, int y) 
    { 
        this.x = x;
        this.y = y;
    }
    public int X { get { return x; } }
    public int Y { get { return y; } }
}

public class Figure
{
    private Point[] points;
    public string Name { get; set; }

    public Figure(Point[] points)
    {
        this.points = points;
    }
    public Figure(Point point1, Point point2, Point point3) : this(new Point[] { point1, point2, point3 })
    {
        Name = "Треугольник";
    }
    public Figure(Point point1, Point point2, Point point3, Point point4) : this(new Point[] { point1, point2, point3, point4})
    {
        Name = "Четырёхугольник";
    }
    public Figure(Point point1, Point point2, Point point3, Point point4, Point point5) : this(new Point[] { point1, point2, point3, point4, point5 })
    {
        Name = "Пятиугольник";
    }
    public double LengthSide(Point A, Point B)
    {
        return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
    }
    public double PerimeterCalc()
    {
        double perimeter = 0;
        for (int i = 0; i < points.Length; i++)
        {
            perimeter += LengthSide(points[i], points[(i + 1) % points.Length]);
        }
        return perimeter;
    }
}
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Задание 1:");
        Console.WriteLine("\n");

        Console.WriteLine(sbyte.MinValue);
        Console.WriteLine(sbyte.MaxValue);

        Console.WriteLine(byte.MinValue);
        Console.WriteLine(byte.MaxValue);
    
        Console.WriteLine(short.MinValue);
        Console.WriteLine(short.MaxValue);

        Console.WriteLine(ushort.MinValue);
        Console.WriteLine(ushort.MaxValue);

        Console.WriteLine(int.MinValue);
        Console.WriteLine(int.MaxValue);

        Console.WriteLine(uint.MinValue);
        Console.WriteLine(uint.MaxValue);

        Console.WriteLine(long.MinValue);
        Console.WriteLine(long.MaxValue);

        Console.WriteLine(ulong.MinValue);
        Console.WriteLine(ulong.MaxValue);

        Console.WriteLine(float.MinValue);  
        Console.WriteLine(float.MaxValue);

        Console.WriteLine(double.MinValue);
        Console.WriteLine(double.MaxValue);

        Console.WriteLine(decimal.MinValue);
        Console.WriteLine(decimal.MaxValue);

        Console.WriteLine("\n");
        Console.WriteLine("Задание 2:");
        Console.WriteLine("\n");

        Console.WriteLine("Введите длину A: ");
        double sideA = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите длину B: ");
        double sideB = double.Parse(Console.ReadLine());
        Rectangle rec = new Rectangle(sideA, sideB);
        double side1 = 10;
        double side2 = 15;
        Rectangle rec1 = new Rectangle(side1, side2);
        Console.WriteLine($"Площадь прямоугольника: {rec.Area}");
        Console.WriteLine($"Периметр прямоугольника: {rec.Perimeter}");
        Console.WriteLine("\n");
        Console.WriteLine("Задание 3: ");

        Point point1 = new Point(0, 0);
        Point point2 = new Point(4, 0);
        Point point3 = new Point(4, 3);
        Point point4 = new Point(0, 3);
        Figure f1 = new Figure(point3, point4, new Point(0,0));
        Figure triangle = new Figure(point1, point2, point3);
        Console.WriteLine($"Фигура: {triangle.Name}, Периметр: {triangle.PerimeterCalc()}");     
    }
}