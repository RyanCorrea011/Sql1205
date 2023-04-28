using Microsoft.AspNetCore.Mvc;
using WebApp_Noite.Models;

namespace WebApp_Noite.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Lista()
        {
            return View();
        }
        public IActionResult Cadastrar()
        {
            ClientesModel model = new ClientesModel();
            return View( model );
        }
        [HttpPost]
        public IActionResult SalvarDados(ClientesModel cliente)
        {
            if (cliente.Id == 0) 
            {
                Random rand = new Random();

                cliente.Id = rand.Next(1,9999);
            }
            return RedirectToAction("Lista");
        }
    }
}
