namespace PassingRefereceTypeParameters
{
    internal class Coordinate
    {
        private double x;
        private double y;

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }

        public Coordinate(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return " X = " + this.x + " , Y = " + this.y;
        }
    }
}
