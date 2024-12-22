using Microsoft.AspNetCore.Mvc;
using Pratik3Survior.Models;

namespace Pratik3Survior.Controllers
{
    [ApiController]
    [Route("Competitor")]
    public class CompetitorController : ControllerBase
    {
        DatabaseController databaseController = new DatabaseController();
        [HttpGet]
        public IActionResult GetCompetitors()
        {
            var v = databaseController.GetCompetiorlist();
            if (v.Count <= 0)
            {
                return NotFound("Competior yok");
            }
            return Ok(v);
        }
        [HttpGet("{id}")]
        public IActionResult GetCompetitors(int id)
        {
            var v = databaseController.GetCompetiorlist().Where(comp=>comp.Id==id&&comp.IsDeleted==false).FirstOrDefault();
            if (v==null)
            {
                return NotFound("Competior yok");
            }
            return Ok(v);
        }
        [HttpGet("categories/{categoryId}")]
        public IActionResult GetCompetitorsCategory(int categoryId)
        {
            var v = databaseController.GetCompetiorlist().Where(comp => comp.CategoryId == categoryId && comp.IsDeleted == false).ToList();
            if (v.Count() <=0)
            {
                return NotFound("categori için competier yok");
            }
            return Ok(v);
        }
        [HttpPost]
        public IActionResult PostCompetitor(Competitor competitor)
        {
            if(ModelState.IsValid)
            {
                if (null != databaseController.GetCategorylist().Where(cat => cat.Id == competitor.CategoryId && cat.IsDeleted == false).FirstOrDefault())
                {
                    competitor.CreatedDate = DateTime.Now;
                    competitor.ModifiedDate = DateTime.Now;
                    competitor.IsDeleted = false;
                    databaseController.AddCompetiorlist(competitor);
                    return Ok(competitor);
                }
                return NotFound("Kategori bulunamadı");
            }
            return NotFound("Oluşturma başarısız");
        }


        [HttpPut("{id}")]
        public IActionResult PutCompetitor(int id, [FromBody] Competitor competitor)
        {
            var edited=databaseController.EditCompetiorlist(id);
            if(edited == null)
            {
                return NotFound("Competier bulunamadı");
            }
            if(null==databaseController.GetCategorylist().Where(cat=>cat.Id==competitor.Id&&cat.IsDeleted==false))
            {
                return NotFound("Böyle bir kategori yok");
            }
            edited.FirstName = competitor.FirstName;
            edited.LastName = competitor.LastName;
            edited.ModifiedDate = DateTime.Now;
            edited.CategoryId=competitor.CategoryId;
            return Ok(edited);
        }
        [HttpDelete]
        public IActionResult DeleteCompetitor(int id)
        {
            var edited = databaseController.EditCompetiorlist(id);
            if(edited==null)
            {
                return NotFound("böyle bir competier yok");
            }
            edited.IsDeleted = true;
            return Ok("Categori silindi");

        }


    }
}
