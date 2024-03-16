namespace WebApi.Models
{
    public class Contribuyentes
    {
        public int Id { get; set; }

        public string RncCedula { get; set; }

        public string Nombre { get; set; }

        public string Tipo { get; set; }

        public string Estatus { get; set; }

       public virtual ICollection<Comprobante> Comprobante { get; set;}
    }
     

}
