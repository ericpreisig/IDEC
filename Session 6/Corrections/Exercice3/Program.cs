namespace Exercice3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            Triangle triangle = new Triangle(10, 10);
            triangle.Color = "bleu";

            Square square = new Square(10);
            square.Color = "rouge";

            Rectangle rectangle = new Rectangle(5, 10);
            rectangle.Color = "rose";

            Circle circle = new Circle(15);
            circle.Color = "vert";

            shapes.Add(triangle);
            shapes.Add(square);
            shapes.Add(rectangle);
            shapes.Add(circle);

            foreach (var shape in shapes)
            {
                Console.WriteLine($"Je suis un {shape.Name} de couleur {shape.Color} et mon air est de {shape.CalculateAera()}");
            }

            Console.ReadLine();
        }
    }
}
