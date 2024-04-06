

namespace FigurasGeometricas
{
    public class Figuras
    {
        public double AlturaFig { get; set; }
        public double BaseFig { get; set;}

        public Figuras( double baseFig, double alturaFig)
        {
            BaseFig = baseFig;
            AlturaFig = alturaFig;
        }

        public virtual void CalcularArea() {

            var resultado = BaseFig * AlturaFig;
            Console.WriteLine($"El area de la figura es base x altura y el resultado es: {BaseFig} x {AlturaFig} = {resultado}");
            
        }
        
    }
   
}
