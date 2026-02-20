namespace TSS.Api.Models
{
    public class NominaDto
    {
        public string NoAsiento { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public string CuentaContable { get; set; }
        public string TipoMovimiento { get; set; }
        public decimal Monto { get; set; }
        public string Asignacion { get; set; }
    }
}