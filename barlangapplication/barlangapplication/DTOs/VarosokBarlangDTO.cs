using System.ComponentModel.DataAnnotations;

namespace barlangapplication.DTOs
{
    public class VarosokBarlangDTO
    {
        [Key]
        public int Id { get; set; }
        public string Varos { get; set; }
        public int Darabszam { get; set; }

    }
}
