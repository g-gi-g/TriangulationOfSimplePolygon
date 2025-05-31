using System.Drawing;

namespace TriangulationLib
{
    public static class SimplePolygonGenerator
    {
        public static List<Point> Generate(int verticlesCount)
        {
            int radius = 70;
            List<Point> points = new List<Point>();
            double angleIncrement = 2 * Math.PI / verticlesCount;
            double currentAngle = 0;

            for (int i = 0; i < verticlesCount; i++)
            {
                int x = (int)(radius * Math.Cos(currentAngle)) + 100;
                int y = (int)(radius * Math.Sin(currentAngle) + 100);
                points.Add(new Point(x, y));

                currentAngle += angleIncrement;
            }

            return points;
        }
    }
}
