namespace ShapesLibrary
{
    public class Triangle : Shape
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;

        public double SideA
        {
            get => _sideA;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("All sides of triangle must be greater than 0");
                }
                if (!IsValidTriangle(value, _sideB, _sideC))
                {
                    throw new ArgumentException("Sides can`t form a triangle");
                }

                _sideA = value;
            }
        }

        public double SideB
        {
            get => _sideB;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("All sides of triangle must be greater than 0");
                }
                if (!IsValidTriangle(_sideA, value, _sideC))
                {
                    throw new ArgumentException("Sides can`t form a triangle");
                }

                _sideB = value;
            }
        }

        public double SideC
        {
            get => _sideC;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("All sides of triangle must be greater than 0");
                }
                if (!IsValidTriangle(_sideA, _sideB, value))
                {
                    throw new ArgumentException("Sides can`t form a triangle");
                }

                _sideC = value;
            }
        }

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

            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;      
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
