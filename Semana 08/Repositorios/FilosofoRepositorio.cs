using System.Collections.Generic;
using System.Linq;
using ef02.Modelos;

namespace ef02.Repositorios
{
    public class FilosofoRepositorio
    {
        readonly ExemploContexto _contexto;

        public FilosofoRepositorio(ExemploContexto contexto)
        {
            _contexto = contexto;
        }

        public void AdicionarFilosofo(int codigo, string nome, string citacao)
        {
            var filosofo = new Filosofo { Codigo = codigo, Nome = nome, Citacao = citacao };

            //Início do trecho para alteração
            _contexto.Filosofos.Add(filosofo);
            _contexto.SaveChanges();            
            //Fim do trecho para alteração
        }

        public void ModificarFilosofo(int codigo, string nome, string citacao)
        {
            var filosofo = ConsultarFilosofo(codigo);

            if (filosofo == null)
                return;                

            //Início do trecho para alteração
            filosofo.Nome = nome;
            filosofo.Citacao = citacao;

            _contexto.Filosofos.Update(filosofo);
            _contexto.SaveChanges();            
            //Fim do trecho para alteração
        }

        public void DeletarFilosofo(int codigo)
        {
            var filosofo = ConsultarFilosofo(codigo);

            if (filosofo == null)
                return;

            //Início do trecho para alteração
            _contexto.Filosofos.Remove(filosofo);
            _contexto.SaveChanges();
            //Fim do trecho para alteração
        }

        Filosofo? ConsultarFilosofo(int codigo)
        {
            //Início do trecho para alteração
            return _contexto.Filosofos.FirstOrDefault(x => x.Codigo == codigo);            
            //Fim do trecho para alteração
        }

        public List<Filosofo> ListarFilosofos()
        {
            //Início do trecho para alteração
            return _contexto.Filosofos.ToList();            
            //Fim do trecho para alteração
        }

    }

}