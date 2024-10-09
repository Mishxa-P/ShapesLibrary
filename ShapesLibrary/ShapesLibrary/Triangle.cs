namespace ShapesLibrary
{
    public class Triangle : Shape
    {
        public double SideA { get; private set; }
        public double SideB { get; private set; }
        public double SideC { get; private set; }

        private Triangle() {}
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("All sides of triangle must be greater than 0");
            }
            if (!IsValidTriangle(sideA, sideB, sideC))
            {
                throw new ArgumentException("Sides can`t form a triangle");
            }
              
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public bool IsRightAngledTriangle()
        {
            double[] sides = { SideA, SideB, SideC };
            Array.Sort(sides);
            return Math.Abs(Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) - Math.Pow(sides[2], 2)) < 1e-10;
        }
        private bool IsValidTriangle(double sideA, double sideB, double sideC)
        {
            return sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA;
        }
        protected override double CalculateArea()
        {
            double semiPerimeter = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));
        }
    }
}
