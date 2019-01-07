using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi_MVC.Models
{
    public class Produtos
    {
        public int Id { get; set; }
        public string Categoria { get; set; }
        public double Preco { get; set; }

    }
}