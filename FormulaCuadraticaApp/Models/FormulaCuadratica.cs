
namespace FormulaCuadraticaApp.Models
{
    public class FormulaCuadratica
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public FormulaCuadratica(double A, double B, double C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
        }
    }
}
