namespace Labb1_IntroOOP;

class Program
{
    static void Main(string[] args)
    {
        Circle circle1 = new Circle(5);
        Circle circle2 = new Circle(6);
        
        circle1.Print();
        Console.WriteLine();
        circle2.Print();
    }
}