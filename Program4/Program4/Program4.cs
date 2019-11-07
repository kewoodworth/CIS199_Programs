//  Y8021
//  CIS 199-75, Program 4, Due Tuesday, April 24
//  Displays information for five packages, using methods and classes
//  Changes assigned values for each object, prints updated information to console

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Program4
{
    class Program4
    {
        public static void Main(string[] args)
        {
            WriteLine("Brown Parcel Service\n");

            //  create class objects
            GroundPackage package1 = new GroundPackage("Package 1", 40217, 89886, 8, 5, 2, 2);
            GroundPackage package2 = new GroundPackage("Package 2", 90117, 20666, 10, 6, 4, 3);
            GroundPackage package3 = new GroundPackage("Package 3", 10023, 30988, 12, 4, 2, 5);
            GroundPackage package4 = new GroundPackage("Package 4", 46168, 78704, 16, 12, 3, 8);
            GroundPackage package5 = new GroundPackage("Package 5", 99713, 54569, 5, 7, 5, 6);

            //  create five element array for GroundPackage
            GroundPackage[] packages = new GroundPackage[5];

            //  Assign objects to array elements
            packages[0] = package1;
            packages[1] = package2;
            packages[2] = package3;
            packages[3] = package4;
            packages[4] = package5;

            DisplayPackages(packages);

            //  create new class objects
            package1.OriginZip = 47404;
            package1.Height = 5;
            package2.DestinationZip = 60222;
            package2.Width = 8;
            package3.Length = 18;
            package3.Weight = 1;
            package4.OriginZip = 40205;
            package4.Width = 10;
            package5.DestinationZip = 59773;
            package5.Height = 6;

            DisplayPackages(packages);

        }  //  end Main

        //  Method DisplayPackages prints information to console for each GroundPackage
        //  Precondition:  GroundPackage objects created, stored in array
        //  Postcondition:  Prints each GroundPackage item in an array to console
        public static void DisplayPackages(GroundPackage[] packages)
        {
            //  foreach process each element in array packages
            foreach (GroundPackage currentPackage in packages)
            {
                WriteLine(currentPackage);                                      //  invokes ToString implicitly
                WriteLine($"Cost to Ship: {currentPackage.CalcCost():C}\n");    //  returns cost of shipping
            }  //  end foreach
        }  //  end DisplayPackages
    }
}
