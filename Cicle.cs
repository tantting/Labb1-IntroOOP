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

    public double Circumference()
    {
        double circumference = 2 * Radius * Math.PI;
        return circumference; 
    }

    public double VolumeSphere()
    {
        double volume = Math.PI * Math.Pow(Radius, 3) * 4 /3;
        return volume; 
    }

    public void Print()
    {
        Console.WriteLine($"Radie {Radius} ger:\n" +
                          $"- Area {Area():N}\n" +
                          $"- Omkrets {Circumference():N}\n" +
                          $"- Volym (för sfär): {VolumeSphere():N}\n");
    }
}