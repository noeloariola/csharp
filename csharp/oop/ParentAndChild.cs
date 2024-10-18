
interface IShape {
    double CalculateArea();
}
public class Shape: IShape {
    public string? ShapeName { get; set; }
    public int CenterX { get; set; } = 0;
    public int Radius { get; set; } = 0;

    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

// ENHERITANCE
// CIRCLE = derived class or child class
// SHAPE = base class or parent class
public class Circle : Shape { 
    public Circle(string name, int centerX, int radius) {
        ShapeName = name;
        CenterX = centerX;
        Radius = radius;
    }
    public void printAreaOfCircle() {
        Console.WriteLine($"Area of circle {ShapeName} is {CalculateArea()}");
    }
}