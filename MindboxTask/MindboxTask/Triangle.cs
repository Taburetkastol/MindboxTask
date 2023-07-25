namespace MindboxTask
{
    public class Triangle : Shape
    {
        private double _a = 0, _b = 0, _c = 0;

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
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
            if (!IsExist()) throw new ArgumentException("Triangle doesn't exist.");
        }
        #endregion

        #region public: Methods
        public override double GetArea()
        {
            if (!IsExist()) throw new ArgumentException("Triangle doesn't exist.");
            var p = (A + B + C) / 2;

            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
        #endregion

        private bool IsExist()
        {
            var sides = new double[] { A, B, C };
            Array.Sort(sides);
            if (sides[0] + sides[1] < sides[2])
            {
                return false;
            }

            return true;
        }

        public bool IsRight()
        {
            var sides = new double[] { A, B, C };
            Array.Sort(sides);
            if (sides[0] * sides[0] + sides[1] * sides[1] == sides[2] * sides[2]
                && sides[0] != 0) return true;

            return false;
        }
    }
}
