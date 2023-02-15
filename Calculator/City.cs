using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class City
    {
        public City(string name, double transit, double travelPrice, City? transitCity = null, bool europeanCity = true)
        {
            _name = name;
            TransitCost = transit;
            TravelPrice = travelPrice;
            IsEuropeanCity=europeanCity;
        }

        public City(string name, double transit, double travelPrice, bool startCity, bool europeanCity = true)
        {
            _name = name;
            TransitCost = transit;
            TravelPrice = travelPrice;
            StartCity = startCity;
            IsEuropeanCity = europeanCity;
        }

        public void AddTransitCity(City city) =>
            TransitCity = city;

        public readonly string _name;
        public double TransitCost { get; set; }
        public double TravelPrice { get; set; }
        public bool IsEuropeanCity { get; set; }
        public bool StartCity { get; set; }
        public City? TransitCity { get; set; }
        public double? Surcharge { get; set; }

        public override string ToString()
        {
            return $"{_name}";
        }
    }
}
