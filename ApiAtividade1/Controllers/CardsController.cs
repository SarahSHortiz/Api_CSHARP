using ApiAtividade1.DAO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiAtividade1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardsController : ControllerBase
    {
        [HttpGet]
        [Route("listar")]
        public IActionResult Listar()
        {
            var dao = new CardsDAO();
            var card = dao.ListarCards();
            return Ok(card);
        }
    }
}
