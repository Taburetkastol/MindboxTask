namespace MindboxTask
{
    public class Triangle : IShape
    {
        private double _a, _b, _c;

        #region public: Fields
        public double A
        {
            get { return _a; }
            set
            {
                if (value < 0) throw new ArgumentNullException("Sides must be more than zero.");
                _a = value;
            }
        }
        public double B
        {
            get { return _b; }
            set
            {
                if (value < 0) throw new ArgumentNullException("Sides must be more than zero.");
                _b = value;
            }
        }
        public double C
        {
            get { return _c; }
            set
            {
                if (value < 0) throw new ArgumentNullException("Sides must be more than zero.");
                _c = value;
            }
        }
        #endregion

        #region public: Constructors
        public Triangle()
        {
            A = 0;
            B = 0;
            C = 0;
        }

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
            var sides = new double[] { A, B, C };
            Array.Sort(sides);
            if (sides[0] + sides[1] < sides[2])
            {
                throw new ArgumentException("Triangle doesn't exist.");
            }
        }
        #endregion

        #region public: Methods
        public double GetArea()
        {
            var sides = new double[] { A, B, C };
            Array.Sort(sides);
            if (sides[0] + sides[1] < sides[2])
            {
                throw new ArgumentException("Triangle doesn't exist.");
            }
            var p = (A + B + C) / 2;

            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
        #endregion
    }
}
