using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RestauranteEtec.Data;
using RestauranteEtec.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RestauranteEtec.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Contexto contexto;

        public HomeController(ILogger<HomeController> logger, Contexto contexto)
        {
            _logger = logger;
            this.contexto = contexto; // injeção de dependência (passamos o serviço pelo método construtor do controller
        }

        public IActionResult Index()
        {
            var chefes = contexto.Funcionarios.Include(f => f.Cargo)
                .Where(f => f.ExibirHome).OrderBy(f => f.OrdemExibicao).ToList();
            ViewData["Chefes"] = chefes;

            /*Produtos*/
            var produtos = contexto.Produtos.Include(c => c.Categoria)
                .Where(c => c.ExibirHome).ToList();
            ViewData["Menu"] = produtos;

            return View();
        }

        public IActionResult QuemSomos()
        {
            return View();
        }

        public IActionResult Chefes()
        {
            /* Chefes */
            var chefes = contexto.Funcionarios.Include(f => f.Cargo)
                .Where(f => f.ExibirHome).OrderBy(f => f.OrdemExibicao).ToList();
            ViewData["Chefes"] = chefes;

            



            /*
            var produtosDal = new ProdutoDAL();
            var categorias = new CategoriaDAL().GetAll();
            List<MenuViewModel> menu = new List<MenuViewModel>();
            foreach (var cat in categorias)
            {
                var pvm = new MenuViewModel();
                pvm.Categoria = cat.Nome;
                var produtos = produtosDal.GetAll().Where(p => p.CategoriaId == cat.Id && p.Ativo && p.ExibirHome).Take(3);
                pvm.Produtos = produtos.Count() > 0 ? new List<ProdutoViewModel>() : null;
                foreach (var prod in produtos)
                {
                    pvm.Produtos.Add(new ProdutoViewModel()
                    {
                        Nome = prod.Nome,
                        Descricao = prod.Descricao,
                        Valor = prod.Preco.ToString("N2"),
                        Imagem = prod.Foto
                    });
                }
                menu.Add(pvm);
            }
            ViewData["Menu"] = menu;
            */


            return View();
        }

        public IActionResult Menu()
        {
            return View();
        }

        public IActionResult Reservas()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
