namespace Labb1_IntroOOP;

public class Circle
{
    public int Radius { get; set; }

    public Circle(int radius)
    {
        Radius = radius; 
    }

    public double Area()
    {
        double area = Math.Pow(Radius, 2) * Math.PI;
        return area;
    }
}