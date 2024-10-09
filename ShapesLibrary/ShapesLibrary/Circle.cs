namespace ShapesLibrary
{
    public class Circle : Shape
    {
        private double _radius;
        public double Radius
        {
            get => _radius;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Radius of circle must be greater than zero");
                }
                _radius = value;
            }
        }

        private Circle(){}
        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Radius of circle must be greater than zero");
            }
            _radius = radius;
        } 

        protected override double CalculateArea()
        {
            return Radius * Radius * Math.PI;
        }
    }
}
