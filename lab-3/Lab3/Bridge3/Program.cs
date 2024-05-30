using System;
using System.Text;

namespace Bridge3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            IRenderer rasterRenderer = new RasterRenderer();
            IRenderer vectorRenderer = new VectorRenderer();

            Shape circle = new Circle(rasterRenderer);
            Shape square = new Square(vectorRenderer);
            Shape triangle = new Triangle(rasterRenderer);

            circle.Draw();
            square.Draw();
            triangle.Draw();
        }
    }
}