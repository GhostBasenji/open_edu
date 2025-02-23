namespace module
{
    internal class Triangle
    {
        double _a = 3;
        double _b = 4;

        public double A
        {
            get { return _a; }

            set
            {
                if (value > 0)
                {
                    _a = value;
                }
            }
        }

        public double B
        {
            get { return _b; }

            set
            {
                if (value > 0)
                {
                    _b = value;
                }
            }
        }

        public double C
        {
            get
            {
                return Math.Sqrt((_a * _a) + (_b * _b));
            }
        }
    }
}
