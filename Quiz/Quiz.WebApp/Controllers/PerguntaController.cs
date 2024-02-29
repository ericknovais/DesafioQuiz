using Microsoft.AspNetCore.Mvc;
using Quiz.DataAccess.Repositories;

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
                throw new Exception(ex.Message);
            }
            
        }
    }
}
