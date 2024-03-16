using System.Text.Json.Serialization;

namespace WebApi.Models
{
    public class Comprobante
    {
        public int Id { get; set; }

        public int ContribuyenteId { get; set; }

        public string Ncf { get; set; }

        public decimal Monto { get; set; }

        public decimal Itbis18 { get; set; }

        [JsonIgnore]
        public Contribuyentes Contribuyente { get; set; }
    }
}
