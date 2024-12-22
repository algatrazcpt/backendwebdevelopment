using System.Collections.Generic;
using Pratik3Survior.Models;

namespace Pratik3Survior.Controllers
{
    public class DatabaseController
    {
       public static List<Competitor> competitors = new List<Competitor>
            {
                new Competitor(1, DateTime.Now.AddMonths(-3), DateTime.Now, false, "Ahmet", "Yılmaz", 1),
                new Competitor(2, DateTime.Now.AddMonths(-5), DateTime.Now, false, "Mehmet", "Demir", 2),
                new Competitor(3, DateTime.Now.AddMonths(-2), DateTime.Now, true, "Elif", "Kaya", 3),
                new Competitor(4, DateTime.Now.AddMonths(-4), DateTime.Now, false, "Zeynep", "Arslan", 1),
                new Competitor(5, DateTime.Now.AddMonths(-6), DateTime.Now, false, "Ahmet2", "Can", 3),
                           new Competitor(4, DateTime.Now.AddMonths(-4), DateTime.Now, false, "Zeynep2", "Arslan", 4),
                new Competitor(5, DateTime.Now.AddMonths(-6), DateTime.Now, false, "Ahmet3", "Can", 5)
            };
       public static List<Category> categories = new List<Category>
            {
                new Category(1, DateTime.Now.AddMonths(-3), DateTime.Now, false, "Survivor"),
                new Category(2, DateTime.Now.AddMonths(-6), DateTime.Now, false, "Adventure"),
                new Category(3, DateTime.Now.AddMonths(-1), DateTime.Now, true, "Elimination"),
                new Category(4, DateTime.Now.AddMonths(-5), DateTime.Now, false, "Team Challenge"),
                new Category(5, DateTime.Now.AddMonths(-4), DateTime.Now, false, "Solo Challenge")
            };

        public List<Competitor> GetCompetiorlist()
        {
            return competitors;
        }
        public List<Category> GetCategorylist()
        {
            return categories;
        }
        public void AddCategorylist(Category category)
        {
            categories.Add(category);
        }
        public void AddCompetiorlist(Competitor competitor)
        {
            competitors.Add(competitor);
        }
        public Category EditCategorylist(int id)
        {
            return categories.Where(categ => id== categ.Id).FirstOrDefault();
        }
        public Competitor EditCompetiorlist(int id)
        {
            return competitors.Where(compe => compe.Id== id).FirstOrDefault();
        }
    }
}
