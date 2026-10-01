using EleicaoApi.Models;
using Eleitores.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Eleitores.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EleitorController : ControllerBase
    {
        private readonly IListaEleitoresRepository repository;

        public EleitorController(IListaEleitoresRepository repository)
        {
            this .repository = repository;
        }

        [HttpPost]
        public IActionResult Exibir(IListaEleitoresRepository Eleitor)
        {
            var eleitor = repository.AdicionarEleitor(eleitor.CPF)
        }
      
    }
}
