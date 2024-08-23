namespace Logical_Separation
{
    public partial class Point
    {
        public double X { get; }
        public double Y { get; }

        private Point (double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}
