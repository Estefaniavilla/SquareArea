using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the length of the side of the square: ");
        double sidelength = Convert.ToDouble(Console.ReadLine());

        
        Square miSquare = new Square(sidelength);

        
        Console.WriteLine($"Area of ​​the square: {mySquare.CalculateArea()}");

        
        Console.Write("Enter the width of the rectangle: ");
        double rectanglewidth = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Área del rectángulo: {mySquare.CalcularArea(rectanglewidth)}");
    }
}

