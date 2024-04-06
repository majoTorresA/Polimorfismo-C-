

namespace FigurasGeometricas
{
    public class Circulo : Figuras
    {
        public double Radio { get; set; }

        public Circulo(double radio) : base (0,0)
        {
            Radio = radio;
        }

        public override void CalcularArea()
        {
            var resultadoArea = Math.PI * Math.Pow(Radio, 2);
            Console.WriteLine($"El área del círculo es: {resultadoArea}");
        }

        public override void CalcularPerimetro()
        {
            var resultadoPerimetro = 2 * Math.PI * Radio;
            Console.WriteLine($"El Perímetro del círculo es: {resultadoPerimetro}");
        }

        public void CalcularDiametro() 
        {
            var resultadoDiametro = 2 * Radio;
            Console.WriteLine($"El Diametro del círculo es: {resultadoDiametro}");
        }
    }
}
