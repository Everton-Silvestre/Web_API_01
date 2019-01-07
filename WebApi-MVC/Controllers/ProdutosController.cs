using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using WebApi_MVC.Models;

namespace WebApi_MVC.Controllers
{
    public class ProdutosController : ApiController
    {
        readonly Produtos[] produtos = new Produtos[]
        {
            new Produtos{ Id = 1, Categoria = "Celular", Preco = 100.00 },
            new Produtos{ Id = 2, Categoria = "Carro", Preco = 200.00 },
            new Produtos{ Id = 3, Categoria = "Pneu", Preco = 150.00 },
            new Produtos{ Id = 4, Categoria = "Caixa", Preco = 700.00 },
            new Produtos{ Id = 5, Categoria = "Som", Preco = 600.00 },
            new Produtos{ Id = 6, Categoria = "PC", Preco = 500.00 }
        };


        public IEnumerable<Produtos> GetTodosProdutos()
        {
            return produtos;
        }

        public IHttpActionResult GetProduto(int id)
        {

            var produto = produtos.FirstOrDefault(p => p.Id == id);

            if (produto == null)
            {
                return NotFound();
            }
            return Ok(produto);           

        }

        public IEnumerable<Produtos> GetProdutoCategoria(string cat)
        {
            var produto = produtos.Where(p => string.Equals(p.Categoria, cat, StringComparison.OrdinalIgnoreCase));

            return produto;
        }




    }
}
