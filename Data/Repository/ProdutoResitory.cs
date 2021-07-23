using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    class ProdutoResitory
    {
        private List<Produto> produto;
        public ProdutoResitory()
        {
            produto = new List<Produto>();
        }
        public void Create(Produto model)
        {
            produto.Add(model);
        }
        public List<Produto> Listar()
        {
            return produto;
        }
    }
}
