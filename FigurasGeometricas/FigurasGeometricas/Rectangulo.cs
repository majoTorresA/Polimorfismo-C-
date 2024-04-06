
namespace FigurasGeometricas
{
    public class Rectangulo : Figuras
    {
        public Rectangulo(double baseFig, double alturaFig) : base(baseFig, alturaFig)
        {
           //Utilizando constructor de la base padre
        }

        public override void CalcularArea()
        {
            var resultadoArea = BaseFig * AlturaFig;
            Console.WriteLine($"El área del rectángulo es base x altura y el resultado es: {BaseFig} x {AlturaFig} = {resultadoArea}");
        }

        public override void CalcularPerimetro()
        {
            var resultadoPerimetro = (2*BaseFig) + (2*AlturaFig);
            Console.WriteLine($"El perímetro del rectángulo da como resultado : (2 x Base) + (2 x Altura) = {resultadoPerimetro}");
        }
    }
}

