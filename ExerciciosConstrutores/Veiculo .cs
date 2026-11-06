
namespace ExerciciosConstrutores
{
    public class Veiculo 
    {
        public double Velocidade{ get; set; }
        
       public Veiculo( int velocidadeAtual)
        {
            Velocidade = 200;

            if(velocidadeAtual > 0 && velocidadeAtual <= 200)
            {
                Console.WriteLine($"A velocidade do veículo é: {velocidadeAtual} km/h");
            }
            else if (velocidadeAtual < 0)
            {
                Console.WriteLine($"A velocidade do veículo é inválida, pois é negativa");
            }
            else
            {
                Console.WriteLine($"A velocidade do veículo é inválida, pois ultrapassa a velocidade permitida de {Velocidade} km/h");
            }
        }
     
    }
    }