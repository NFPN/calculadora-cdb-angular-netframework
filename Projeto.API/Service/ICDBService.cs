using Projeto.API.Models;

namespace Projeto.API.Service
{
    public interface ICdbService
    {
        CdbResultModel CalcularCDB(decimal valorInicial, int meses);
    }
}
