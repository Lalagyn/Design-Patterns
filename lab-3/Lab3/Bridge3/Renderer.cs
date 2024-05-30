using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge3
{
    public interface IRenderer
    {
        void Render(string shape);
    }

    // Реалізація растрового рендерингу
    public class RasterRenderer : IRenderer
    {
        public void Render(string shape)
        {
            Console.WriteLine($"Малювання {shape} як пікселі");
        }
    }

    // Реалізація векторного рендерингу
    public class VectorRenderer : IRenderer
    {
        public void Render(string shape)
        {
            Console.WriteLine($"Малювання {shape} як лінії");
        }
    }
}
