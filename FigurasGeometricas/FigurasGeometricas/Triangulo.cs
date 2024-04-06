

namespace FigurasGeometricas
{
    public class Triangulo : Figuras
    {
        public Triangulo(double baseFig, double alturaFig) : base (baseFig, alturaFig)
        {
            //Utilizando constructor de la base padre
        }

        public override void CalcularArea()
        {
            var resultadoArea = BaseFig * AlturaFig / 2;
            Console.WriteLine($"El área del triángulo es base x altura dividido 2 y el resultado es: {BaseFig} x {AlturaFig} / 2 = {resultadoArea}");
        }
        public override void CalcularPerimetro()
        {
            var resultadoPerimetro = BaseFig * 3;
            Console.WriteLine($"El perímetro del Triángulo Equilatero da como resultado : Lado + Lado + Lado = {resultadoPerimetro}");
        }
    }
}
