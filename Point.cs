namespace Point
{
    class Point
    {
        private double x { get; set; }
        private double y { get; set; }

        Point()
        {
            x = 0;
            y = 0;
        }
        Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public double getDistance()
        {
            return Math.Sqrt((x * x) + (y * y));
        }

        public bool isEqual(Point pt)
        {
            return (x == pt.x) && (y == pt.y);
        }

        public Point translate(int a, int b)
        {
            x += a;
            y += b;

            return this;
        }

        public bool isCollinear(Point a, Point b)
        {
            double area = x * (a.y - b.y) +
                        a.x * (b.y - y) +
                        b.x * (y - a.y);

            return (area == 0);
        }
    }
}
