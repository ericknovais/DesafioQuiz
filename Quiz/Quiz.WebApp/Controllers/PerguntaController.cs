using Microsoft.AspNetCore.Mvc;
using Quiz.DataAccess.Repositories;
using Quiz.DomainModel.Models;

namespace Quiz.WebApp.Controllers
{
    public class PerguntaController : Controller
    {
        Repository repository = new Repository();
        public IActionResult List()
        {
            try
            {
                return View(repository.Pergunta.ObterTodos());
            }
            catch (Exception ex)
            {
                Alerta(ex);
                return View(new List<Pergunta>());
            }
            
        }

        private void Alerta(Exception ex)
        {
            TempData["Alerta"] = ex.Message.Replace(Environment.NewLine, "</br>");
        }
    }
}
