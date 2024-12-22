using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Pratik1CodeFirstBasic.Models
{
    public class Games
    {
        int id;
        string name;
        string platform;
        decimal rating;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Platform { get => platform; set => platform = value; }

        [Range(0, 10)]
        public decimal Rating { get => rating; set => rating = value; }
    }
}
