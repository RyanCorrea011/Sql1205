using Microsoft.AspNetCore.Mvc;
using WebApp_Noite.Models;

namespace WebApp_Noite.Controllers
{
    public class ProdutoController : Controller
    {
        public static List<ProdutoModel> pl = new List<ProdutoModel>();
        public IActionResult Lista()
        {
            return View( pl );
        }
        public IActionResult Cadastrar()
        {
            ProdutoModel modelL = new ProdutoModel();
            return View( modelL );
        }
        [HttpPost]
        public IActionResult SalvarDados(ProdutoModel Produto)
        {
            if (Produto.Id == 0)
            {
                Random rand = new Random();

                Produto.Id = rand.Next(1, 9999);
                pl.Add(Produto);
            }
            return RedirectToAction("Lista");
        }
        public IActionResult Excluir(int id)
        {
            ProdutoModel itemP = pl.Find(a => a.Id == id);
            if (itemP != null)
            {
                pl.Remove(itemP);
            }
            return RedirectToAction("Lista");
        }
        public IActionResult Editar(int id)
        {
            ProdutoModel itemP = pl.Find(a => a.Id == id);
            if (itemP != null)
            {
                return View(itemP);

            }
            else
            {
                return RedirectToAction("lista");
            }
        }
    }
}
    

