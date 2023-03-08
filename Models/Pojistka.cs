using System.ComponentModel.DataAnnotations;
namespace AspWrong.Models
{
    public class Pojistka
    {
        public int Id { get; set; }
        public int PojistenyId { get; set; }
        public string Majetek { get; set; } = "";
        public string Osoby { get; set; } = "";
        public string Zivot { get; set; } = "";
        public string Uraz { get; set; } = "";
        public string Predmet { get; set; } = "";
        public DateTime Od { get; set; }
        public DateTime Do { get; set; }
    }
}
