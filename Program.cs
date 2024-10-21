namespace Labb1_IntroOOP;

class Program
{
    static void Main(string[] args)
    {
        Circle circle1 = new Circle(5);
        Circle circle2 = new Circle(6);

        Console.WriteLine($"Arean av cirklarna är: " +
                          $"Radie {circle1.Radius} ger area {circle1.Area():N}\n" +
                          $"Radie {circle2.Radius} ger area {circle2.Area():N}\n" +
                          $"Enhet för radie och area är oklart :)" );
    }
}