using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Pratik3Survior.Models;
namespace Pratik3Survior.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController:ControllerBase
    {

        DatabaseController databaseController=new DatabaseController();
        [HttpGet]   
        public IActionResult Get()
        {
           var v= databaseController.GetCategorylist().Where(category=>category.IsDeleted==false).ToList();
            if(v.Count<=0)
            {
                return NotFound();
            }
            return Ok(v);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var v = databaseController.GetCategorylist().Where(category => category.IsDeleted == false&&category.Id==id).FirstOrDefault();
            if (v==null)
            {
                return NotFound();
            }
            return Ok(v);
        }
        [HttpPost]
        public IActionResult Post(Category category)
        {
            if(ModelState.IsValid)
            {
                category.Id=databaseController.GetCategorylist().Max(category=>category.Id)+1;
                category.CreatedDate = DateTime.Now;
                category.ModifiedDate = DateTime.Now;
                
                databaseController.AddCategorylist(category);
                return Ok(category);
            }
            return BadRequest("Ekleme başarısız");
        }
        [HttpPut]
        public IActionResult Put(int id, [FromBody] Category category)
        {
            var v = databaseController.GetCategorylist().Where(category => category.IsDeleted == false && category.Id == id).FirstOrDefault();
            if (v == null)
            {
                return NotFound();
            }
            var edited=databaseController.EditCategorylist(id);
            edited.ModifiedDate = DateTime.Now;
            edited.Name = category.Name;
            return Ok(edited);
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var v = databaseController.GetCategorylist().Where(category => category.IsDeleted == false && category.Id == id).FirstOrDefault();
            if (v == null)
            {
                return NotFound();
            }
            var deleted=databaseController.EditCategorylist(id);
            deleted.IsDeleted = true;
            return Ok();
        }
    }
}
