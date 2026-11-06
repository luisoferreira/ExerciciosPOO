

namespace ExerciciosConstrutores
{
    public class Calculadora
    {

        public decimal a { get; set; }
        public decimal b { get; set; }

            public void somar(decimal a, decimal b)
            {
                decimal resultado ;
                resultado = a + b;
                Console.WriteLine($"O resultado da soma é: {resultado}");
            }
            public void subtrair(decimal a, decimal b)
            {
                decimal resultado ;
                resultado = a - b;
                Console.WriteLine($"O resultado da subtração é: {resultado}");
            }
            public void multiplicar(decimal a, decimal b)
            {
                decimal resultado ;
                resultado = a * b;
                Console.WriteLine($"O resultado da multiplicação é: {resultado}");
            }
            public static void dividir (decimal a, decimal b)
            {
                decimal resultado ;
                resultado = a / b;
                Console.WriteLine($"O resultado da divisão é: {resultado}");
            }

    }
}