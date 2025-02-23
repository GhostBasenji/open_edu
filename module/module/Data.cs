namespace module
{
    internal class Data
    {
        double[] data = { 1.3, 1.8, 2.24, 3.75, 4.901 };

        public double this[int i]
        {
            get
            {
                if (i >= 0)
                {
                    return data[i];
                }
                return -1;
            }

            set
            {
                if (i >= 0)
                {
                    if (value > 0)
                    {
                        data[i] = value;
                    }
                }
            }
        }
    }
}
