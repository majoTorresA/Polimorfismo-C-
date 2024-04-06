
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
            var resultado = BaseFig * AlturaFig;
            Console.WriteLine($"El área del rectángulo es base x altura y el resultado es: {BaseFig} x {AlturaFig} = {resultado}");
        }
    }
}

