namespace PruebaTecnicaFlexTech.Models
{
    public class InformationJson
    {
        public InformationJson(DateTime fecha,string information)
        {
            Fecha = ParseDate(fecha);
            Information = information;
        }
        public string Fecha { get; set; }

        public string Information { get; set; }
        private string ParseDate(DateTime date)
        {

            return date.ToString("dd/MM/yyyy");
        }

    }
}
