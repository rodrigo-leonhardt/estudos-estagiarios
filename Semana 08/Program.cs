using System;
using ef02.Modelos;
using ef02.Repositorios;

namespace ef02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using var db = ExemploContexto.NovaConexao();
            var cliRepo = new FilosofoRepositorio(db);
            
            AdicionarFilosofos(cliRepo);

            ListarFilosofos(cliRepo);

            ModificarFilosofo(cliRepo);

            RemoverFilosofo(cliRepo);

            ListarFilosofos(cliRepo);        
        }

        static void AdicionarFilosofos(FilosofoRepositorio repo)
        {
            Console.WriteLine("> Adicionando Filósofos");

            repo.AdicionarFilosofo(1, "Heráclito", "Se não sabe escutar, não sabe falar");
            repo.AdicionarFilosofo(2, "Platão", "Muitos odeiam a tirania apenas para que possam estabelecer a sua");
            repo.AdicionarFilosofo(3, "Pitágoras", "Ajuda o teu semelhante a levantar a carga, mas não a levá-la");
            repo.AdicionarFilosofo(4, "Valesca", "Beijinho no ombro pro recalque passar longe");
            repo.AdicionarFilosofo(5, "Tiririca", "Pior que tá não fica");
        }

        static void ListarFilosofos(FilosofoRepositorio repo)
        {
            Console.WriteLine("> Listando Filósofos");

            repo.ListarFilosofos().ForEach(f => Console.WriteLine("- {0} {1}: '{2}'", f.Codigo, f.Nome, f.Citacao));
        }

        static void ModificarFilosofo(FilosofoRepositorio repo)
        {
            Console.WriteLine("> Modificando Filósofo");

            repo.ModificarFilosofo(4, "Epicteto", "É impossível para um homem aprender aquilo que ele acha que já sabe");
        }

        static void RemoverFilosofo(FilosofoRepositorio repo)
        {
            Console.WriteLine("> Removendo Filósofo");

            repo.DeletarFilosofo(5);
        }
       
    }
    
}