using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyFortuneAPI.Models;


namespace MyFortuneAPI.Controllers
{
    
    

    [Route("/truth")]
    public class FortuneTellerController : Controller
    {

        private readonly IFortuneRepository _fortuneRepository;

        public FortuneTellerController(IFortuneRepository fortuneRepository)
        {
            _fortuneRepository = fortuneRepository;
        }

        [HttpGet("/")]
        public ViewResult Index()
        {
            ViewBag.Datetime = DateTime.Now.ToString();
            ViewBag.Title = "Fortune Teller API";
            ViewBag.Message = "Today we have the power to tell you a fortune!";
            ViewBag.Use = "uri/truth -  will reveal wisdom beyond your expectations!";

            return View();
        }

        [HttpGet("/truth")]
        public Fortune GetFortune()
        {
            return _fortuneRepository.GetFortune();
        }

        
        [HttpGet("/truth/all")]
        public IEnumerable<Fortune> GetAll()
        {
            return _fortuneRepository.GetAllFortunes();
        }

        

        // GET /truth/{id}
        [HttpGet("/truth/{id}")]
        public Fortune Get(int id)
        {
            return _fortuneRepository.GetFortuneById(id);
        }


        // GET /truth/{id}
        [HttpGet("/truth/version")]
        public Fortune GetVersion()
        {
            var rv = new Fortune { id = 999, phrase = "Author: Steve Sparks, Version: 0.3 " };
            return rv;
        }


        // POST api/values
        // [HttpPost]
        // public void Post([FromBody]string value)
        // {
        // }

        // PUT api/values/5
        // [HttpPut("{id}")]
        // public void Put(int id, [FromBody]string value)
        //  {
        // }

        // DELETE api/values/5
        // [HttpDelete("{id}")]
        // public void Delete(int id)
        // {
        // }
    }
}
