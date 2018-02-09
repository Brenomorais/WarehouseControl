using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CaelumEstoque.Models;
using CaelumEstoque.DAO;

namespace CaelumEstoque.Controllers
{
    public class CategoriaController : Controller
    {
        // GET: Categoria
        public ActionResult Index()
        {
            CategoriasDAO dao = new CategoriasDAO();
            IList<CategoriaDoProduto> categorias = dao.Lista();
            ViewBag.Categorias = categorias;
            return View();
        }

        public ActionResult Form()
        {
            return View();
        }
               

        [HttpPost]
        public ActionResult Adiciona(CategoriaDoProduto categoria)
        {            
            CategoriasDAO dao = new CategoriasDAO();
            dao.Adiciona(categoria);

            //return View(); // Redireciona para a view com o nome do metodo "Adiciona" /Categoria/Adiciona
            return RedirectToAction("Index", "Categoria");
        }
    }
}