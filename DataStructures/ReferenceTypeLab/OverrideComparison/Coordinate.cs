namespace OverrideComparison
{
    public class Coordinate
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

        public override bool Equals(object obj)
        {
            if (obj is Coordinate) // is checks the type of the instance
            {
                //Coordinate temp = (Coordinate) obj;
                Coordinate temp = obj as Coordinate;//obj is converted into Coordinate

                if (this.x == temp.x && this.y == temp.y)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator ==(Coordinate c1, Coordinate c2)
        {
            return c1.Equals(c2);
        }

        public static bool operator !=(Coordinate c1, Coordinate c2)
        {
            return c1.Equals(c2);
        }

        public override string ToString()
        {
            return " X = " + this.x + " , Y = " + this.y;
        }

        public override int GetHashCode()
        {
            return new { x, y }.GetHashCode();
        }
    }
}
