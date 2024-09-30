using FiguresLib.Abstract;


namespace F​iguresLib.Figures
{
    public class Triangle : IFigure
    {
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }
        

        public Triangle(double a, double b, double c ) 
        {
            Check(a,b,c);

            A = a; 
            B = b; 
            C = c;

         }



        public double Square(int round = 1)
        {
            double semiperimeter;
            semiperimeter = (A + B + C) / 2;

            double square;
            square = Math.Round(Math.Sqrt
                ( semiperimeter * 
                (semiperimeter - A) *
                (semiperimeter - B) *
                (semiperimeter - C) 
                ), round);
            return square;
        }

        public bool IsRightTriangle()
        {
            return 
                Math.Round(Math.Pow(A, 2) + Math.Pow(B, 2),1) == Math.Round(Math.Pow(C,2), 1) ||
                Math.Round(Math.Pow(B, 2) + Math.Pow(C, 2), 1) == Math.Round(Math.Pow(A,2), 1) ||
                Math.Round(Math.Pow(C, 2) + Math.Pow(A, 2), 1) == Math.Round(Math.Pow(B,2), 1);
        }

        public void Check(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException($"Side can't <=0\n A = {a};\n B = {b}\n C = {c}");
            }

            if (a + b < c || b + c < a || c + a < b)
            {
                throw new ArgumentException("This figure is not a Triangle");
            }
        }
    }
}
