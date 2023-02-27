namespace AspBlog.Models
{
    public class Article1
    {
        public int Id { get; set; }
        public string Jméno { get; set; } = "";
        public string Příjmení { get; set; } = "";
        public string Adresa { get; set; } = "";
        public string Obec { get; set; } = "";
        public int PSČ { get; set; }
        public string Telefon { get; set; } = "";
        public string Email { get; set; } = "";
    }
}
