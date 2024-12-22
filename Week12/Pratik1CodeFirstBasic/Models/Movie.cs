using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Pratik1CodeFirstBasic.Models
{
    public class Movie
    {
        int id;
        string title;
        string genre;
        int releaseYear;
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string Genre { get => genre; set => genre = value; }
        public int ReleaseYear { get => releaseYear; set => releaseYear = value; }
    }
}
