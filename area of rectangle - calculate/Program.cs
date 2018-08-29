using System;

namespace area_of_rectangle___calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate the area of a rectangle");
            Console.Write("Enter length of rectangle: ");
            
            //can use decimal or other number type in the place of int
            int lengthInt = int.Parse(Console.ReadLine());
            Console.Write("Enter width of rectangle: ");
            int widthInt = int.Parse(Console.ReadLine());

            int rectangleArea = lengthInt * widthInt;

            Console.WriteLine("The area of your rectangle is: {0}", rectangleArea);

            Console.ReadLine();

        }
    }
}
