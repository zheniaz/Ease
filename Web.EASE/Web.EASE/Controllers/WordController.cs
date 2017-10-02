using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Web.EASE.Models;
using Web.EASE.Services;

namespace Web.EASE.Controllers
{
    public class WordController : ApiController
    {
        private QueryClass _quaryClass = new QueryClass();

        // GET api/values
        public List<WordSetModel> Get(string from, string to)
        {
            return _quaryClass.GetWordsByQuery(from, to);
        }

        // GET api/values/5
        //public string Get(string query)
        //{
        //    return "value";
        //}

        //// POST api/values
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/values/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //public void Delete(int id)
        //{
        //}
    }
}
