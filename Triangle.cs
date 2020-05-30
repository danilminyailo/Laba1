using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    class Triangle
    {
        Point first;
        Point second;
        Point third;
        public Triangle(Point point,Point point2, Point point3)
        {
            first = point;
            second = point2;
            third = point3;
        }
        public Triangle()
        {
            first = new Point(-1,0);
            second = new Point(0, 1);
            third = new Point(1, 0);
        }
        public Triangle(double firstX, double firstY, double secondX, double secondY, double thirdX, double thirdY)
        {
            first = new Point(firstX, firstY);
            second = new Point(secondX, secondY);
            third = new Point(thirdX, thirdY);
        }
        public void ShowPoints()
        {
            Console.WriteLine("First"+first.ToString());
            Console.WriteLine("Second"+second.ToString());
            Console.WriteLine("Third"+third.ToString());
        }
        public Point PeretinMedian()
        {
            Point Middle = new Point((first.x + second.x) / 2, (first.y + second.y) / 2);
            double dist = third.FindDistance(Middle);
            return new Point(Math.Round(third.x + dist * 2 / 3,2), third.y);
        }
        public double FindPerimetr()
        {
            double Perim = first.FindDistance(second);
            Perim += first.FindDistance(third);
            Perim += second.FindDistance(third);
            return Perim;
        }
        public double FindSquare()
        {
            double firstsecond = first.FindDistance(second);
            double firstthird = first.FindDistance(third); 
            double secondthird = second.FindDistance(third);
            double Perim = this.FindPerimetr()/2;
            return Math.Sqrt(Perim*(Perim-firstsecond)*(Perim - firstthird) *(Perim - secondthird));
        }
        public void EditPoint(int numberOfPoint,double X,double Y)
        {
            switch (numberOfPoint)
            {
                case 1: first = new Point(X, Y); break;
                case 2: second = new Point(X, Y); break;
                case 3: third = new Point(X, Y); break;
                default:
                    Console.WriteLine($"Cannot find a point {numberOfPoint}");
                    break;
            }
        }
        public void EditPoint(int numberOfPoint, Point point)
        {
            switch (numberOfPoint)
            {
                case 1: first = point; break;
                case 2: second = point; break;
                case 3: third = point; break;
            default:
                    Console.WriteLine($"Cannot find a point {numberOfPoint}");
            break;
        }

        }
    }
    class Point
    {
        private double X;
        public double y
        {
            get { return Y; }
            set
            {
                Y = value;
            }
        }
        private double Y;
        public double x
        {
            get { return X; }
            set {
                X = value;
            }
        }
        public Point()
        {
            x = 0;
            y = 0;
        }
        public Point(double x , double y)
        {
            this.x = x;
            this.y = y;
        }
        public double FindDistance(Point point)
        {
            double distx = point.x - this.x;
            double disty = point.y - this.y;
            double dist = Math.Sqrt(distx * distx + disty * disty);
            return dist;
        }
        public override string ToString()
        {
            return $"({x};{y})";
        }
    }
}
