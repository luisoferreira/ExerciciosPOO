using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosConstrutores
{
    public class Funcionario
    {
           public decimal Salario { get; private set; }
           public string Nome { get; set; }
         public string Cargo { get; set; }
        public Funcionario(string nome, string cargo, decimal salarioInicial)
    {
        Nome = nome;
        Cargo = cargo;
        Salario = salarioInicial;
    }

   
    public void AumentarSalario(decimal percentual)
    {
        if (percentual > 0)
        {
            Salario += Salario * (percentual / 100);
            Console.WriteLine($"Aumento de {percentual}% aplicado com sucesso!");
        }
        else
        {
            Console.WriteLine("O percentual de aumento deve ser maior que zero.");
        }
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Cargo: {Cargo}");
        Console.WriteLine($"Salário: R$ {Salario:F2}");
    }
    public void ConsultarSalario()
    {
        Console.WriteLine($"O salário atual do funcionário {Nome} é: R$ {Salario:F2}");
    }
}
}