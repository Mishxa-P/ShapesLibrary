namespace ShapesLibrary
{
    public class Circle : Shape
    {
        public double Radius { get; private set; }
        
        private Circle(){}
        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Radius of circle must be greater than zero");
            }
            Radius = radius;
        } 

        protected override double CalculateArea()
        {
            return Radius * Radius * Math.PI;
        }
    }
}
