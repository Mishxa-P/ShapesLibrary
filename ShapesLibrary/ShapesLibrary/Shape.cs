namespace ShapesLibrary
{
    public abstract class Shape
    {
        public static double CalculateArea(Shape shape)
        {
            if (shape == null)
            {
                throw new ArgumentNullException(nameof(shape), "Shape cant be null");
            }
            return shape.CalculateArea();
        }
        protected abstract double CalculateArea();
    }
}
