/* y8021
 * CIS199-75 Program1, Due Tues. Feb 13
 * Paint estimator
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Program_1
{
    class Program1
    {
        static void Main(string[] args)
        {
            double totalLength;  //  declares variable for the total length of the walls
            double totalHeight;  //  declares variable for the total height of the walls
            int doors;  //  declares variable for number of doors
            int windows;  //  declares variable for number of windows
            int coats;  //  declares variable for number of coats of paint needed
            double galCost;  //  declares variable for cost of a gallon of paint

            WriteLine("Um, yes, I heard you need to paint a room \n");

            Write("Enter the total length of all walls (in feet): ");
            totalLength = double.Parse(ReadLine());
            Write("Enter the height of the walls (in feet): ");
            totalHeight = double.Parse(ReadLine());
            Write("Enter the number of doors (non-negative int): ");
            doors = int.Parse(ReadLine());
            Write("Enter the number of windows (non-negative int): ");
            windows = int.Parse(ReadLine());
            Write("Enter the number of coats of paint (non-negative int): ");
            coats = int.Parse(ReadLine());
            Write("Enter the cost per gallon of paint (in dollars): ");
            galCost = double.Parse(ReadLine());
            WriteLine();

            const int DOOR_SUBTRACT = 20;  //  Names constant for number of sq ft to subtract for each door
            const int WINDOW_SUBTRACT = 15;  //  Names constant for number of sq ft to subtract for each door
            double area = totalLength * totalHeight - doors * DOOR_SUBTRACT - windows * WINDOW_SUBTRACT;  //  declares variable of total area to paint
            double totalSquareFeet = area * coats;  //  declares variable for total square feet to paint multiplied by number of coats
            const int CAN_COVER = 375;  //  Names constant for number of square feet one can paints
            double galMinimum = totalSquareFeet / CAN_COVER;  //  declares variable for minimum number of gallons needed
            double gallonsToBuy = (int)Math.Ceiling(galMinimum);  //  declares variable that is rounded up for number of gallons needed
            double totalCost = galCost * gallonsToBuy;  //  declares variable for the total cost

            WriteLine($"You need a minimum of {galMinimum:F1} gallons of paint.");
            WriteLine($"You will need to buy {gallonsToBuy} gallons, at a cost of {totalCost:C}");
        }
    }
}
