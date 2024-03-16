using WebApi.Models;
using WebApi.Data;
using WebApi.Repositories.Interfaces;

namespace WebApi.Repositories.Implementations
{
    public class ComprobanteRepositoy : IComprobante
    {
        private readonly WebApiDBContext _dbContext;

        public ComprobanteRepositoy(WebApiDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Comprobante> GetAllComprobantes()
        {
            var result = _dbContext.Comprobante.ToList();
            return result;
        }

        public Comprobante GetComprobanteById(int Id)
        {
            var result = _dbContext.Comprobante.Where(x => x.Id == Id).FirstOrDefault() ?? null;
            return result;
        }

        public List<Comprobante> GetComprobantesByContribuyenteId(int ContribuyenteId)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        
    }
}
