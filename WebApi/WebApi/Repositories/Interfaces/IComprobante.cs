using WebApi.Models;

namespace WebApi.Repositories.Interfaces
{
    public interface IComprobante : IDisposable
    {
        List<Comprobante> GetAllComprobantes();
        List<Comprobante> GetComprobantesByContribuyenteId(int ContribuyenteId);
        Comprobante GetComprobanteById(int Id);

    }
}
