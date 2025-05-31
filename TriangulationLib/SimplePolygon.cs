using System.Drawing;

namespace TriangulationLib
{
    public class SimplePolygon
    {
        private List<Point> points;
        private List<Point> convexVerticles = new List<Point>();
        private List<Point> reflexVerticles = new List<Point>();
        private List<Point> ears = new List<Point>();

        public SimplePolygon(List<Point> pointsList) => points = pointsList;

        public List<Triangle> Triangulate()
        {
            List<Triangle> result = new List<Triangle>();
            FindConvexVerticles();
            FindReflexVerticles();
            FindEars();
            while(points.Count > 3)
            {
                Point ear = ears[0];
                var adjPoints = GetAdjPoints(ear);
                result.Add(new Triangle(ears[0], adjPoints.Item1, adjPoints.Item2));
                points.Remove(ear);

                RecalculateEars(adjPoints);
                RecalculateConvexVerticles(adjPoints);
                convexVerticles.Remove(ear);
                ears.Remove(ear);
            }
            result.Add(new Triangle(points[0], points[1], points[2]));
            return result;

        }
        
        private void FindConvexVerticles()
        {
            for (int i = 0; i < points.Count; i++)
            {
                if (IsConvex(points[i],points[Mod(i - 1)], points[Mod(i + 1)]))
                {
                    convexVerticles.Add(points[i]);
                }
            }
        }

        private bool IsConvex(Point pointExtensions, Point adjP1, Point adjP2)
        {
            return pointExtensions.GetAngleBetweenTwoPoints(adjP1, adjP2) < 180;
        }

        private void FindReflexVerticles() => reflexVerticles = points.Except(convexVerticles).ToList();

        private void FindEars()
        {
            for (int i = 0; i < points.Count; i++)
            {
                if (convexVerticles.Contains(points[i]) && 
                    IsEar(points[i], points[Mod(i - 1)], points[Mod(i + 1)]))
                {
                    ears.Add(points[i]);
                }
            }
        }

        private bool IsEar(Point pointExtensions, Point adjP1, Point adjP2)
        {
            var suspectedEarTriangle = new Triangle(pointExtensions, adjP1, adjP2);
            foreach (var p in points)
            {
                if (p != pointExtensions && p != adjP1 && p != adjP2 && suspectedEarTriangle.IsPointInside(p))
                {
                    return false;
                }
            }
            return true;
        }

        private void RecalculateEars((Point, Point) adjPoints)
        {
            var adjPointsOfAdj1 = GetAdjPoints(adjPoints.Item1);
            var adjPointsOfAdj2 = GetAdjPoints(adjPoints.Item2);

            if (convexVerticles.Contains(adjPoints.Item1))
            {
                AddIfEar(adjPoints.Item1, adjPointsOfAdj1.Item1, adjPointsOfAdj1.Item2);
            }
            if (convexVerticles.Contains(adjPoints.Item2))
            {
                AddIfEar(adjPoints.Item2, adjPointsOfAdj2.Item1, adjPointsOfAdj2.Item2);
            }

            void AddIfEar(Point p, Point adj1, Point adj2)
            {
                if (IsEar(p, adj1, adj2))
                {
                    if (!ears.Contains(p))
                    {
                        ears.Add(p);
                    }
                }
                else
                {
                    ears.Remove(p);
                }
            }
        }

        private void RecalculateConvexVerticles((Point, Point) adjPoints)
        {
            var adjPointsOfAdj1 = GetAdjPoints(adjPoints.Item1);
            var adjPointsOfAdj2 = GetAdjPoints(adjPoints.Item2);

            if (!convexVerticles.Contains(adjPoints.Item1))
            {
                AddIfConvexIfEar(adjPoints.Item1, adjPointsOfAdj1.Item1, adjPointsOfAdj1.Item2);
            }
            if (!convexVerticles.Contains(adjPoints.Item2))
            {
                AddIfConvexIfEar(adjPoints.Item2, adjPointsOfAdj2.Item1, adjPointsOfAdj2.Item2);
            }

            void AddIfConvexIfEar(Point p, Point adj1, Point adj2)
            {
                if (IsConvex(p, adj1, adj2))
                {
                    convexVerticles = convexVerticles.Prepend(adj2).ToList();
                    reflexVerticles.Remove(p);
                    if (IsEar(p, adj1, adj2))
                    {
                        ears = ears.Prepend(p).ToList();
                    }
                }
            }
        }

        private int Mod(int n) => (n % points.Count + points.Count) % points.Count;

        private int GetIndexOfVerticle(Point p) => points.FindIndex(point => point == p);

        private (Point,Point) GetAdjPoints(Point p)
        {
            int pInd = GetIndexOfVerticle(p);
            return (points[Mod(pInd - 1)], points[Mod(pInd + 1)]);
        }
    }
}
