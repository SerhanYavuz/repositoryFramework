using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReposiyoryFramework.Persistence;

namespace ReposiyoryFramework.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values     

        ////eski context
        //private readonly ApplicationDbContext _context;

        //public ValuesController(ApplicationDbContext context)
        //{
        //    _context = context;
        //}

        public UnitOfWork unitOfWork = new UnitOfWork(new ApplicationDbContext());
        [HttpGet]
        public IActionResult Get()
        {
            ////eski yapı context'e erişime müsaade etmekte
            ////eski yapıda yapılan her değişiklik ana akışa koyulduğu için db değişiklikleri için sürekli 'get latest' yapılamlı
            //var res = _context.Books.ToList();
            //return Json(res);C:\Users\yavuz\source\repos\ReposiyoryFramework\ReposiyoryFramework\Core\IRepositories\


            // Yeni yapı
            var books = unitOfWork.Books.GetAll();
            unitOfWork.Books.RemoveRange(books);
            unitOfWork.Save();
            
                return Json(books);





            //aynı zamanda bir dönüş nesnesi de dönderebilirdik


        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
