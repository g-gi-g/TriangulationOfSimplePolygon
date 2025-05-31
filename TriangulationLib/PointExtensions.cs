
using System.Drawing;

namespace TriangulationLib
{
    public static class PointExtensions
    {
        public static double GetAngleBetweenTwoPoints(this Point p, Point p1, Point p2)
        {
            var distanceBetweenPoints = (Point p1, Point p2) 
                => Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y));
            var adjSide1 = distanceBetweenPoints(p, p1);
            var adjSide2 = distanceBetweenPoints(p, p2);
            var opposite = distanceBetweenPoints(p1, p2);
            Point prevVector = new Point(p1.X - p.X, p1.Y - p.Y);
            Point nextVector = new Point(p2.X - p.X, p2.Y - p.Y);

            double crossProduct = prevVector.X * nextVector.Y - prevVector.Y * nextVector.X;

            return crossProduct < 0 
                ? Math.Acos((adjSide1 * adjSide1 + adjSide2 * adjSide2 - opposite * opposite) 
                             / (2 * adjSide1 * adjSide2)) * 180 / Math.PI 
                : 360 - Math.Acos((adjSide1 * adjSide1 + adjSide2 * adjSide2 - opposite * opposite)
                             / (2 * adjSide1 * adjSide2)) * 180 / Math.PI;
        }


    }
}
