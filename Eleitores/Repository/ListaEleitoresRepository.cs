using EleicaoApi.Models;

namespace Eleitores.Repository
{
    public class ListaEleitoresRepository
    {
        private readonly List<Eleitor> eleitores = new List<Eleitor>();

        public void AdicionarEleitor(Eleitor eleitor)
        {
            eleitores.Add(eleitor);

        }

        public List<Eleitor> ListarEleitores()
        {
            return eleitores;
        }

    }
}
