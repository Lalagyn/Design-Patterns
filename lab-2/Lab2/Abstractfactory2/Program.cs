using System;

namespace Abstractfactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IBrandFactory iproneFactory = new IProneFactory();
            IBrandFactory kiaomiFactory = new KiaomiFactory();
            IBrandFactory balaxyFactory = new BalaxyFactory();

            IDevice iproneLaptop = iproneFactory.CreateLaptop();
            IDevice kiaomiSmartphone = kiaomiFactory.CreateSmartphone();
            IDevice balaxyEBook = balaxyFactory.CreateEBook();

            Console.WriteLine(iproneLaptop.GetDetails());
            Console.WriteLine(kiaomiSmartphone.GetDetails());
            Console.WriteLine(balaxyEBook.GetDetails());
        }
    }
}