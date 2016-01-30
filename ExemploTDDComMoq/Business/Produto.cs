using System;

namespace Business
{
    public class Produto
    {
        private IRepositorioProduto repositorio;

        public string Nome { get; set; }

        public Produto()
        {
        }

        public Produto(IRepositorioProduto repositorio)
        {
            this.repositorio = repositorio;
        }

        public bool Catalogar()
        {
            if(string.IsNullOrEmpty(this.Nome))
            {
                return false;
            }

            return repositorio.Salvar(this);
        }
    }
}