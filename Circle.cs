namespace Point
{
    class Circle : Point
    {
        private float radius;

        public Circle(): base()
        {
            radius = 0;
        }
        public Circle(Point center, float radius): base(center.getX(), center.getY())
        {
            this.radius = radius;
        }
    
        public float getRadius()
        {
            return radius;
        }
        public void setRadius(float radius)
        {
            this.radius = radius;
        }

        public bool isEqual(Circle circle)
        {
            return (radius == circle.radius) && (getX() == circle.getX()) && (getY() == circle.getY());
        }

        public double getCircumference()
        {
            return (2 * radius * Math.PI);
        }

        public double getArea()
        {
            return (radius * radius * Math.PI);
        }
    }
}
