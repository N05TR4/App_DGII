using WebApi.Models;

namespace WebApi.Repositories.Interfaces
{
    public interface IContribuyente : IDisposable
    {
        List<Contribuyentes> GetAllContribuyentes();
        //IEnumerable<Contribuyentes> GetAllContribuyentes();
        Contribuyentes GetContribuyenteByRncCedula(string rncCedula);
    }
}
