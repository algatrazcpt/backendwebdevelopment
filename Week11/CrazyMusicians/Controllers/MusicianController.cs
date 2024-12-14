using CrazyMusicians.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace CrazyMusicians.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MusicianController : ControllerBase
    {
        private static List<Musician> musiciansList = new List<Musician>(){new Musician(1,"music1","music1job","infotrait1"), new Musician(2, "music2", "music2job", "infotrait2") , new Musician(3, "music3", "music3job", "infotrait3") };

        [HttpGet]
        public List<Musician> GetMusicianList()
        {
            return musiciansList;
        }

        [HttpGet]
        [Route("/[controller]/[action]/id/{id}")]
        public ActionResult<Musician> GetMusician(int id)
        {
            var v = musiciansList.FirstOrDefault(mId => mId.Id == id);
            if (v!=null)
            {
                return Ok(v);
            }
            else
            {
                return NotFound("Müzikçi bulunamadı"); ;
            }
        }
        [HttpGet]
        [Route("/[controller]/[action]")]
        public ActionResult<List<Musician>> GetResearchMusician([FromQuery] string? name)
        {
            if(string.IsNullOrEmpty(name)||string.IsNullOrWhiteSpace(name))
            {
                return Ok(musiciansList);
            }
            var v= musiciansList.Where(musician => musician.Name.Contains(name)).ToList();
            if(v.Any())
            {
                return Ok(v);
            }
            else
            {
                return NotFound("Bu isimli müzikçi bulunamadı");
            }
        }


        [HttpDelete]
        [Route("/[controller]/[action]/id/{id}")]
        public IActionResult Delete(int id)
        {
            if(musiciansList.FirstOrDefault(mId => mId.Id == id)!=null)
            {
                musiciansList.Remove(musiciansList.First(mId => mId.Id == id));
                return Ok("Silme işlemi başarılı");
            }
            else
            {
                return NotFound("Silme işlemi başarısız");
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]/create")]
        public ActionResult Create(Musician musician)
        {
            if (ModelState.IsValid)
            {

                musician.Id = musiciansList.Max(mId => mId.Id) + 1;
                musiciansList.Add(musician);
                return Ok(musician);
            }
            else
            {
                return NotFound();
            }
        }
        [HttpPut]
        [Route("/[controller]/[action]/edit")]
        public ActionResult Edit(Musician musician)
        {
            var v=musiciansList.FirstOrDefault(mId => mId.Id == musician.Id);
            if(v!=null)
            {
                v = musician;
                return Ok(v);
            }
            else
            {
                return NotFound("Düzenleme başarısız");
            }
        }
        [HttpPatch]
        [Route("/[controller]/[action]/edit/{id}/{name}")]
        public ActionResult EditMusicianName(int id,string name)
        {
            var v = musiciansList.FirstOrDefault(mId => mId.Id ==id);
            if (v != null)
            {
                v.Name=name;
                return Ok(v);
            }
            else
            {
                return NotFound("Ad düzenlemesi başarısız");
            }
        }

    }
    
}
