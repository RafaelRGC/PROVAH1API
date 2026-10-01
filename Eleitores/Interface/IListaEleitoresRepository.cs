using EleicaoApi.Models;

namespace Eleitores.Interface
{
    public interface IListaEleitoresRepository
    {
        void AdicionarEleitor(Eleitor eleitor);

        List<Eleitor> ListarEleitores();

    }
}
