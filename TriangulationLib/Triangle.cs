using System.Drawing;

namespace TriangulationLib
{
    public record struct Triangle
    {
        public Point P1{get;init;}
        public Point P2{get;init;}
        public Point P3 { get; init; }
        public Triangle(Point p1, Point p2, Point p3)
        {
            P1 = p1;
            P2 = p2;
            P3 = p3;
        }

        public override string ToString()
        {
            return $"Triangle: ({P1}, {P2}, {P3})";
        }

        public double FindSquare()
        {
            return Math.Abs(P1.X * P2.Y + P2.X * P3.Y + P3.X * P1.Y - P1.Y * P2.X - P2.Y * P3.X - P3.Y * P1.X) / 2;
        }

        public bool IsPointInside(Point p)
        {
            var thisSquare = FindSquare();
            var squareP1 = (new Triangle(P1,P2,p)).FindSquare();
            var squareP2 = (new Triangle(P1, P3, p)).FindSquare();
            var squareP3 = (new Triangle(P3, P2, p)).FindSquare();
            return thisSquare == squareP1 + squareP2 + squareP3;
        }
    }
}
