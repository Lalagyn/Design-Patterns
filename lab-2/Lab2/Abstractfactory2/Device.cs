using System;

namespace Abstractfactory
{
    public interface IDevice
    {
        string GetDetails();
    }

    public class Laptop : IDevice
    {
        private string brand;

        public Laptop(string brand)
        {
            this.brand = brand;
        }

        public string GetDetails()
        {
            return $"{brand} Laptop";
        }
    }

    public class Netbook : IDevice
    {
        private string brand;

        public Netbook(string brand)
        {
            this.brand = brand;
        }

        public string GetDetails()
        {
            return $"{brand} Netbook";
        }
    }

    public class EBook : IDevice
    {
        private string brand;

        public EBook(string brand)
        {
            this.brand = brand;
        }

        public string GetDetails()
        {
            return $"{brand} EBook";
        }
    }

    public class Smartphone : IDevice
    {
        private string brand;

        public Smartphone(string brand)
        {
            this.brand = brand;
        }

        public string GetDetails()
        {
            return $"{brand} Smartphone";
        }
    }
}