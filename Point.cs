namespace Point
{
    class Point
    {
        private double x;
        private double y;

        public Point()
        {
            x = 0;
            y = 0;
        }
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double getX()
        {
            return x;
        }
        public double getY()
        {
            return y;
        }
        public void setX(double a)
        {
            x = a;
        }
        public void setY(double a)
        {
            y = a;
        }

        public double getDistance()
        {
            return Math.Sqrt((x * x) + (y * y));
        }

        public bool isEqual(Point pt)
        {
            return (x == pt.x) && (y == pt.y);
        }

        public Point translate(double a, double b)
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
