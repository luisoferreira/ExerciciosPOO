

namespace ExerciciosConstrutores
{
    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int NumeroPaginas { get; set; }

        public Livro()
        {
            Titulo = "Sem titulo";
            Autor = "Desconhecido";
            NumeroPaginas = 0;
         
        }

      public Livro(string titulo)
        {
            Titulo = titulo;
            Autor = "Desconhecido";
            NumeroPaginas = 0;
        }
      public Livro(string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor ;
            NumeroPaginas = 0;
        }
      public Livro(string titulo, string autor, int numeroPaginas)
        {
            Titulo = titulo;
            Autor = autor;
            NumeroPaginas = numeroPaginas;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Número de páginas: {NumeroPaginas}");
        }
    }
}