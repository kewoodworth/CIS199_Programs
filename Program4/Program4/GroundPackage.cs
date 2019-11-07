using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    //  GroundPackage base class
    //  Precondition:  GroundPackage object is instantiated
    //  Postcondition:  Object variables are assigned, passed to properties, distance and cost calculated, and can return ToString
    class GroundPackage
    {
        //  backing field variables
        //  establish private variables for GroundPackage properties
        private string _name;
        private int _originZip;
        private int _destinationZip;
        private double _length;
        private double _width;
        private double _height;
        private double _weight;

        //  six-parameter constructor
        //  Precondition:  GroundPackage object instantiated
        //  Postcondition:  Variables are assigned
        public GroundPackage(string name, int originZip, int destinationZip, double length,
                             double width, double height, double weight)
        {
            Name = name;
            OriginZip = originZip;
            DestinationZip = destinationZip;
            Length = length;
            Width = width;
            Height = height;
            Weight = weight;
        }  //  end six-parameter constructor

        //  property gets and sets name
        //  Precondition:  name submitted
        //  Postcondition:  name is assigned
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        //  property gets and sets origin zip code
        //  Precondition:  Value is 00000 < zip < 99999
        //  Postcondition:  OriginZip is assigned, or default is assigned
        public int OriginZip
        {
            get { return _originZip; }
            set
            {
                if (value > 00000 && value < 99999)
                    _originZip = value;
                else
                    _originZip = 40202;
            }
        }

        //  property gets and sets destination zip code
        //  Precondition:  Value is 00000 < zip < 99999
        //  Postcondition:  DestinationZip is assigned, or default is assigned
        public int DestinationZip
        {
            get { return _destinationZip; }
            set
            {
                if (value > 00000 && value < 99999)
                    _destinationZip = value;
                else
                    _destinationZip = 90210;
            }
        }

        //  property gets and sets package length
        //  Precondition:  value is > 0
        //  Postcondition:  package length is assigned, or default is assigned
        public double Length
        {
            get { return _length; }
            set
            {
                if (value > 0)
                    _length = value;
                else
                    _length = 1.0;
            }
        }

        //  property gets and sets package width
        //  Precondition:  value is > 0
        //  Postcondition:  package width is assigned, or default is assigned
        public double Width
        {
            get { return _width; }
            set
            {
                if (value > 0)
                    _width = value;
                else
                    _width = 1.0;
            }
        }

        // property gets and sets package height
        //  Precondition:  value is > 0
        //  Postcondition:  package height is assigned, or default is assigned
        public double Height
        {
            get { return _height; }
            set
            {
                if (value > 0)
                    _height = value;
                else
                    _height = 1.0;
            }
        }

        // property gets and sets package weight
        //  Precondition:  value is > 0
        //  Postcondition:  package weight is assigned, or default is assigned
        public double Weight
        {
            get { return _weight; }
            set
            {
                if (value > 0)
                    _weight = value;
                else
                    _weight = 1.0;
            }
        }

        //  read-only property gets the distance between zip codes
        //  Precondition:  both origin zip and destination zip exist
        //  Postcondition:  Distance between the zip codes is calculated as positive integer
        public int ZoneDistance
        {
            get { return Math.Abs((_originZip / 10000) - (_destinationZip / 10000)); }
        }

        //  method calculates cost
        //  Precondition:  all variables provided, valid
        //  Postcondition:  calculates cost to ship
        public double CalcCost()
        {
            double cost;
            cost = 0.20 * (Length + Width + Height) + 0.5 * (ZoneDistance + 1) * Weight;
            return cost;
        }  //  end CalcCost

        //  return string of GroundPackage object, using properties
        //  Precondition:  ToString called
        //  Postcondition:  Returns variable stats as a string
        public override string ToString()
        {
            return $"{Name}{Environment.NewLine}" +
                    $"Origin Zip Code: {OriginZip}{Environment.NewLine}" +
                    $"Destination Zip Code: {DestinationZip}{Environment.NewLine}" +
                    $"Length: {Length} in{Environment.NewLine}" +
                    $"Width: {Width} in{Environment.NewLine}" +
                    $"Height: {Height} in{Environment.NewLine}" +
                    $"Weight: {Weight} lbs";
        }  //  end ToString
    }  //  end GroundPackage
}
