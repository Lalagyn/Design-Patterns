using System;
using System.Text;

namespace Composer5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            LightElementNode div = new LightElementNode("div", DisplayType.Block, CloseType.Normal);
            div.CssClasses.Add("container");

            LightElementNode h1 = new LightElementNode("h1", DisplayType.Block, CloseType.Normal);
            h1.AddChild(new LightTextNode("Привіт, World!"));

            LightElementNode p = new LightElementNode("p", DisplayType.Block, CloseType.Normal);
            p.AddChild(new LightTextNode("Тисяча і один абзац написані тією ж мовою, що й LightHTML."));

            div.AddChild(h1);
            div.AddChild(p);

            Console.WriteLine(div.OuterHTML);
        }
    }
}