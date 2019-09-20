using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DynalistSync.BusinessLogic;
using DynalistSync.Models;
using Microsoft.AspNetCore.Mvc;

namespace DynalistSync.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        public DynalistAPI pippo = new DynalistAPI();
        public DynManagement Man = new DynManagement();
        // GET api/values
        [HttpGet]
        public ActionResult<String> Get()
        {
            //     return new string[] { "value1", "value2" };
            DynResp dynResp = pippo.getFromDynalistAsync().Result;
            DynFile myfile=Man.getFileByName(dynResp, "vidiemme");
            DynDoc dynDoc = pippo.getDocFromID(myfile.id).Result;
            List<Node> todo = Man.getUncheckItem(dynDoc);
            string res = "" ;
            todo.ForEach(el => res=res+"\n"+el.content);
            return res;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<int> Get(int id)
        {
            return id;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
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
