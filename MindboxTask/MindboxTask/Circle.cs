namespace MindboxTask
{
    public class Circle : Shape
    {
        private double _radius;

        #region public: Fields
        public double Radius
        {
            get { return _radius; }
            set
            {
                if (value < 0) throw new ArgumentNullException("Radius must be more than zero.");
                _radius = value;
            }
        }
        #endregion

        #region public: Constructors
        public Circle() => Radius = 0;
        public Circle(double radius) => Radius = radius;
        #endregion

        #region public: Methods
        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
        #endregion
    }
}
