using System.ComponentModel.DataAnnotations;

namespace shared.Model
{
    public class Kommentar
    {
        [Key]
        public int idKommentar { get; set; }
        public string brugerKommentar { get; set; }
        public string text { get; set; }

        //Antal up/downvotes
        public DateTime dato { get; set; }

    }
}
