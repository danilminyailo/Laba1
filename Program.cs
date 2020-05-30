using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    class Program
    {/*Описати клас, що представляє трикутник. 
      * Передбачити методи для створення об'єктів, обчислення площі, периметра і точки перетину медіан. 
      * Описати властивості для отримання стану об'єкта.*/
        static void Main(string[] args)
        {
            Point first = new Point(-2, 1);
            Point second = new Point();
            Point third = new Point(3, -1);
            Point fourth = new Point(2, 1);
            Point fiveth = new Point(-2, -1);
            Triangle triangle = new Triangle(first, second, third);
            triangle.EditPoint(2, fourth);
            Console.WriteLine("Edit second point");
            Console.WriteLine("Perimetr: " + triangle.FindPerimetr());
            Console.WriteLine("Square: " + triangle.FindSquare());
            Console.WriteLine("Point of mediants: "+ triangle.PeretinMedian().ToString());
        }
    }
}
