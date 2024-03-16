using Microsoft.EntityFrameworkCore;
using WebApi.Data;
using WebApi.Models;
using WebApi.Repositories.Interfaces;


namespace WebApi.Repositories.Implementations
{
    public class ContribuyentesRepository : IContribuyente
    {
        private readonly WebApiDBContext _dbContext;

        public ContribuyentesRepository(WebApiDBContext dBContext)
        {
            _dbContext = dBContext;
        }


        public Contribuyentes GetContribuyenteByRncCedula(string rncCedula)
        {
            var result = _dbContext.Contribuyentes.Include(x => x.Comprobante).Where(x => x.RncCedula == rncCedula).FirstOrDefault() ?? null;
            return result;
        }

        

        List<Contribuyentes> IContribuyente.GetAllContribuyentes()
        {
            var result = _dbContext.Contribuyentes.Include(x => x.Comprobante).ToList();
            return result;

        }

        public void Dispose()
        {
            _dbContext?.Dispose();
        }

    }
}
