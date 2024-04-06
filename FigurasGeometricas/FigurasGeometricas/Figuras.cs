

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

            var resultadoArea = BaseFig * AlturaFig;
            Console.WriteLine($"El area de la figura es base x altura y el resultado es: {BaseFig} x {AlturaFig} = {resultadoArea}");
            
        }
        public virtual void CalcularPerimetro()
        {
            var resultadoPerimetro = (2 * BaseFig) + (2 * AlturaFig);
            Console.WriteLine($"El perímetro de la figura da como resultado : formula = {resultadoPerimetro}");
        }
        
    }
   
}
