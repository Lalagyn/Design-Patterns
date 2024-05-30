using Composer5;
using System;
using System.IO;

namespace Lightweight6
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "THE TRAGEDY OF ROMEO AND JULIET\n\nby William Shakespeare\n\n\n\n\nContents\n\nTHE PROLOGUE.\n\nACT I\nScene I. A public place.\nScene II. A Street.\nScene III. Room in Capulet’s House.\nScene IV. A Street.\nScene V. A Hall in Capulet’s House.\n\nACT II\nCHORUS.\nScene I. An open place adjoining Capulet’s Garden.\nScene II. Capulet’s Garden.\nScene III. Friar Lawrence’s Cell.\nScene IV. A Street.\nScene V. Capulet’s Garden.\nScene VI. Friar Lawrence’s Cell.\n\nACT III\nScene I. A public Place.\nScene II. A Room in Capulet’s House.\nScene III. Friar Lawrence’s cell.\nScene IV. A Room in Capulet’s House.\nScene V. An open Gallery to Juliet’s Chamber, overlooking the Garden.\n\nACT IV\nScene I. Friar Lawrence’s Cell.\nScene II. Hall in Capulet’s House.\nScene III. Juliet’s Chamber.\nScene IV. Hall in Capulet’s House.\nScene V. Juliet’s Chamber; Juliet on the bed.\n\nACT V\nScene I. Mantua. A Street.\nScene II. Friar Lawrence’s Cell.\nScene III. A churchyard; in it a Monument belonging to the Capulets.\n\n\n\n\n Dramatis Personæ\n\nESCALUS, Prince of Verona.\nMERCUTIO, kinsman to the Prince, and friend to Romeo.\nPARIS, a young Nobleman, kinsman to the Prince.\nPage to Paris.\n\nMONTAGUE, head of a Veronese family at feud with the Capulets.\nLADY MONTAGUE, wife to Montague.\nROMEO, son to Montague.\nBENVOLIO, nephew to Montague, and friend to Romeo.\nABRAM, servant to Montague.\nBALTHASAR, servant to Romeo.\n\nCAPULET, head of a Veronese family at feud with the Montagues.\nLADY CAPULET, wife to Capulet.\nJULIET, daughter to Capulet.\nTYBALT, nephew to Lady Capulet.\nCAPULET’S COUSIN, an old man.\nNURSE to Juliet.\nPETER, servant to Juliet’s Nurse.\nSAMPSON, servant to Capulet.\nGREGORY, servant to Capulet.\nServants.\n\nFRIAR LAWRENCE, a Franciscan.\nFRIAR JOHN, of the same Order.\nAn Apothecary.\nCHORUS.\nThree Musicians.\nAn Officer.\nCitizens of Verona; several Men and Women, relations to both houses;\nMaskers, Guards, Watchmen and Attendants.\n\nSCENE. During the greater part of the Play in Verona; once, in the\nFifth Act, at Mantua.\n\n\n\n\nTHE PROLOGUE\n\n\n Enter Chorus.\n\nCHORUS.\nTwo households, both alike in dignity,\nIn fair Verona, where we lay our scene,\nFrom ancient grudge break to new mutiny,\nWhere civil blood makes civil hands unclean.\nFrom forth the fatal loins of these two foes\nA pair of star-cross’d lovers take their life;\nWhose misadventur’d piteous overthrows\nDoth with their death bury their parents’ strife.\nThe fearful passage of their death-mark’d love,\nAnd the continuance of their parents’ rage,\nWhich, but their children’s end, nought could remove,\nIs now the two hours’ traffic of our stage;\nThe which, if you with patient ears attend,\nWhat here shall miss, our toil shall strive to mend.\n\n [_Exit._]\n";
            string[] lines = text.Split('\n');

            // Без оптимізації
            LightElementNode rootWithoutFlyweight = new LightElementNode("div", DisplayType.Block, CloseType.Normal);
            rootWithoutFlyweight.CssClasses.Add("book");

            bool isFirstLine = true;

            foreach (string line in lines)
            {
                LightElementNode element;

                if (isFirstLine)
                {
                    element = new LightElementNode("h1", DisplayType.Block, CloseType.Normal);
                    isFirstLine = false;
                }
                else if (line.Length < 20)
                {
                    element = new LightElementNode("h2", DisplayType.Block, CloseType.Normal);
                }
                else if (line.StartsWith(" "))
                {
                    element = new LightElementNode("blockquote", DisplayType.Block, CloseType.Normal);
                }
                else
                {
                    element = new LightElementNode("p", DisplayType.Block, CloseType.Normal);
                }

                element.AddChild(new LightTextNode(line));
                rootWithoutFlyweight.AddChild(element);
            }

            Console.WriteLine("Без використання Flyweight:");
            Console.WriteLine(rootWithoutFlyweight.OuterHTML);

            GC.Collect();
            long memoryUsedWithoutFlyweight = GC.GetTotalMemory(true);
            Console.WriteLine($"Використання пам'яті без Flyweight: {memoryUsedWithoutFlyweight} байт");

            // З оптимізацією
            FlyweightFactory factory = new FlyweightFactory();
            LightElementNode rootWithFlyweight = factory.GetFlyweight("div", DisplayType.Block, CloseType.Normal);
            rootWithFlyweight.CssClasses.Add("book");

            isFirstLine = true;

            foreach (string line in lines)
            {
                LightElementNode element;

                if (isFirstLine)
                {
                    element = factory.GetFlyweight("h1", DisplayType.Block, CloseType.Normal);
                    isFirstLine = false;
                }
                else if (line.Length < 20)
                {
                    element = factory.GetFlyweight("h2", DisplayType.Block, CloseType.Normal);
                }
                else if (line.StartsWith(" "))
                {
                    element = factory.GetFlyweight("blockquote", DisplayType.Block, CloseType.Normal);
                }
                else
                {
                    element = factory.GetFlyweight("p", DisplayType.Block, CloseType.Normal);
                }

                element.AddChild(new LightTextNode(line));
                rootWithFlyweight.AddChild(element);
            }

            Console.WriteLine("\nЗ використанням Flyweight:");
            Console.WriteLine(rootWithFlyweight.OuterHTML);

            GC.Collect();
            long memoryUsedWithFlyweight = GC.GetTotalMemory(true);
            Console.WriteLine($"Використання пам'яті з Flyweight: {memoryUsedWithFlyweight} байт");
        }
    }
}
