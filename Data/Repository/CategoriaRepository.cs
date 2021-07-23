using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    class CategoriaRepository
    {
        private List<Categoria> categoria;
        public CategoriaRepository()
        {
            categoria = new List<Categoria>();
        }
        public void Create(Categoria model)
        {
            categoria.Add(model);
        }
        public List<Categoria> Listar()
        {
            return categoria;
        }

    }
}
