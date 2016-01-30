using System;

namespace Business
{
    public class Produto
    {
        public string Nome { get; set; }

        public Produto()
        {
        }

        public bool Catalogar()
        {
            if(string.IsNullOrEmpty(this.Nome))
            {
                return false;
            }

            return true;
        }
    }
}