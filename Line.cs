namespace Shapes
{
    // y = mx + b
    class Line
    {
        private double m;
        private double b;

        Line()
        {
            m = 1;
            b = 0;
        }
        Line(Point a, Point b)
        {
            m = (a.getY() - b.getY()) / (a.getX() - b.getX());
            this.b = a.getY() - (m * a.getX());
            // or this.b = b.getY() - (m * b.getX());
        }

        public void setM(double m)
        {
            this.m = m;
        } 
        public double getM()
        {
            return m;
        }
        public void setB(double b)
        {
            this.b = b;
        }
        public double getB()
        {
            return b;
        }

        public bool isEqual(Line line)
        {
            return (m == line.m) && (b == line.b);
        }

        public bool isParallel(Line line)
        {
            return (m == line.m);
        }

        public Point intersect(Line line)
        {
            if (!isParallel(line)) return null;
            double x = ((line.m * b) - (m * line.b)) / (b - line.b);
            double y = (line.b - b) / (b - line.b);

            return new Point(x, y);
        }

        public bool isPerpendicular(Line line)
        {
            return (m == (-1 / line.m));
        }

    }
}
