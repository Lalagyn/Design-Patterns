using System;

namespace Abstractfactory
{
    public interface IBrandFactory
    {
        IDevice CreateLaptop();
        IDevice CreateNetbook();
        IDevice CreateEBook();
        IDevice CreateSmartphone();
    }

    public class IProneFactory : IBrandFactory
    {
        public IDevice CreateLaptop()
        {
            return new Laptop("IProne");
        }

        public IDevice CreateNetbook()
        {
            return new Netbook("IProne");
        }

        public IDevice CreateEBook()
        {
            return new EBook("IProne");
        }

        public IDevice CreateSmartphone()
        {
            return new Smartphone("IProne");
        }
    }

    public class KiaomiFactory : IBrandFactory
    {
        public IDevice CreateLaptop()
        {
            return new Laptop("Kiaomi");
        }

        public IDevice CreateNetbook()
        {
            return new Netbook("Kiaomi");
        }

        public IDevice CreateEBook()
        {
            return new EBook("Kiaomi");
        }

        public IDevice CreateSmartphone()
        {
            return new Smartphone("Kiaomi");
        }
    }

    public class BalaxyFactory : IBrandFactory
    {
        public IDevice CreateLaptop()
        {
            return new Laptop("Balaxy");
        }

        public IDevice CreateNetbook()
        {
            return new Netbook("Balaxy");
        }

        public IDevice CreateEBook()
        {
            return new EBook("Balaxy");
        }

        public IDevice CreateSmartphone()
        {
            return new Smartphone("Balaxy");
        }
    }
}