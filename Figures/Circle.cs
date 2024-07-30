using FiguresLib.Abstract;


namespace F​iguresLib.Figures
{
    public class Circle : IFigure
    {
        public double Radius { get; private set; }

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException($"Radius = {radius}, Radius must be > 0");
            }

            Radius = radius;
        }

        public double Square(int round = 2)
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2),round);
        }

   
    }
}
