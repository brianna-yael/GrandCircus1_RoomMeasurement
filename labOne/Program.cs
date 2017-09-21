using System;

namespace labOne
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                //Ask user for room measurements
                Console.WriteLine("Let's measure the dimensions of this room! Please enter the length of the room:");
                double length = double.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the width of this room:");
                double width = double.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the height of this room:");
                double height = double.Parse(Console.ReadLine());

                //Calculate dimensions
                double area = (length * width);
                double perimeter = 2 * (length + width);
                double volume = (length * width * height);

                //Print dimensions to the console
                Console.WriteLine("Area: " + area);
                Console.WriteLine("Perimeter: " + perimeter);
                Console.WriteLine("Volume: " + volume);

                Console.WriteLine("Do you want to continue? Y/N");
            } while (Console.ReadLine() == "Y");
        }
    }
}
