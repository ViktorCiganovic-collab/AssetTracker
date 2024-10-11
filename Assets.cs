using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ListWithDifferentObjects
{

    public class Assets
    {
        public string Office;
        public string Asset;
        public string Brand;
        public string Model;
        public double EuroPrice;
        public string Currency;
        public double LocalPrice;
        public DateTime purchaseDate;

        public Assets(string brand, string Model, double localPrice, DateTime purchaseDate)
        {
            this.Brand = brand;
            this.Model = Model;            
            this.LocalPrice = localPrice;
            this.purchaseDate = purchaseDate;
        }
    }


    public class Smartphone : Assets
    {
        public Smartphone(string brand, string Model, double localPrice, DateTime purchaseDate) : base(brand, Model, localPrice, purchaseDate)
        {
            Asset = "Phone";
        }
    }

    public class Computer : Assets
    {
        public Computer(string brand, string Model, double localPrice, DateTime purchaseDate) : base(brand, Model, localPrice, purchaseDate)
        {
            Asset = "Computer";
        }
    }

    public class PolishComputer : Computer
    {
        public PolishComputer(string brand, string Model, double localPrice, DateTime purchaseDate) : base(brand, Model, localPrice, purchaseDate)
        {
            Currency = "PLN";
            Office = "Poland";
        }
    }

    public class PolishPhone : Smartphone
    {
        public PolishPhone(string brand, string Model, double localPrice, DateTime purchaseDate) : base(brand, Model, localPrice, purchaseDate)
        {
            Currency = "PLN";
            Office = "Poland";
        }
    }

    public class USComputer : Computer
    {
        public USComputer(string brand, string Model, double localPrice, DateTime purchaseDate) : base(brand, Model, localPrice, purchaseDate)
        {
            Currency = "USD";
            Office = "USA";
        }
    }

    public class USPhone : Smartphone
    {
        public USPhone(string brand, string Model, double localPrice, DateTime purchaseDate) : base(brand, Model, localPrice, purchaseDate)
        {
            Currency = "USD";
            Office = "USA";
        }
    }

    public class SWEphone : Smartphone
    {
        public SWEphone(string brand, string Model, double localPrice, DateTime purchaseDate) : base(brand, Model, localPrice, purchaseDate)
        {
            Currency = "SEK";
            Office = "Sweden";
        }
    }

    public class SWEComputer : Computer
    {
        public SWEComputer(string brand, string Model, double localPrice, DateTime purchaseDate) : base(brand, Model, localPrice, purchaseDate)
        {
            Currency = "SEK";
            Office = "Sweden";
        }
    }
}

	


