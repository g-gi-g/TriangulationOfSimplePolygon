using TriangulationLib;
using Point = System.Drawing.Point;

namespace TriangulationDrawer
{
    public partial class Form1 : Form
    {
        private List<Point> points;
        private List<Triangle> triangles;
        private SimplePolygon? currentPolygon;

        public Form1()
        {
            InitializeComponent();
            points = new List<Point>();
            triangles = new List<Triangle>();
            DoubleBuffered = true;
            Paint += Form1_Paint;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Draw all the triangles
            foreach (var triangle in triangles)
            {
                e.Graphics.DrawPolygon(Pens.Black, new PointF[]{triangle.P1, triangle.P2, triangle.P3});
            }

            // Draw the current polygon being created
            if (currentPolygon != null)
                e.Graphics.DrawLines(Pens.Red, points.ToArray());

            // Draw all the points
            foreach (var point in points)
            {
                e.Graphics.FillEllipse(Brushes.Black, point.X - 3, point.Y - 3, 6, 6);
            }
        }

        private void addPointBtn_Click(object sender, EventArgs e)
        {
            points.Add(new Point(Convert.ToInt32(xCoord.Text),Convert.ToInt32(yCoord.Text)));
            Invalidate();
        }

        private void generatePolygonBtn_Click(object sender, EventArgs e)
        {
            clearBtn_Click(sender, e);
            points = SimplePolygonGenerator.Generate(Convert.ToInt32(verticlesCountTb.Text));
            Invalidate();
        }

        private void triangulateBtn_Click(object sender, EventArgs e)
        {
            currentPolygon = new SimplePolygon(points);
            Invalidate();
            triangles = currentPolygon.Triangulate();
            Invalidate();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            points.Clear();
            currentPolygon = null;
            triangles.Clear();
            Invalidate();
        }
    }
}