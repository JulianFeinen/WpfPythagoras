using System;

namespace dreieickv2
{
    class Dreieck
    {
        public double a;
        public double b;
        public double c;

        public double BerechnungHypotenuse()
        {
            double cquadrat = (this.a * this.a) + (this.b * this.b);
            c = Math.Sqrt(cquadrat);
            return c;
        }
        public double BerechnungKatheteA()
        {
            double aquadrat = (this.c * this.c) - (this.b * this.b);
            a = Math.Sqrt(aquadrat);
            return a;
        }
        public double BerechnungKatheteB()
        {
            double bquadrat = (this.c * this.c) - (this.a * this.a);
            b = Math.Sqrt(bquadrat);
            return b;
        }
    }
}
