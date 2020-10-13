using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using PhotoSystem.Models;
using PhotoSystem.DTO;
using Microsoft.Extensions.Options;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PhotoSystem.Controllers
  
{
    
    [Route("api/[controller]")]

    public class ImageController : Controller
    {
        private readonly fotodbContext _context;


        public ImageController(fotodbContext context, IOptions<JWTSettings> jwtsettings)
        {
            _context = context;

        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {


            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public async Task Post([FromBody] List<string> value)
        {
            Account account = new Account("dqacelyhg", "263532498829537", "vISNAVXolVPERp64rZTwcsA1SeA");

            Cloudinary cloudinary = new Cloudinary(account);
           
            
            var delResParams = new DelResParams()
           
            {
                
                PublicIds = value

            };
            cloudinary.DeleteResources(delResParams);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
