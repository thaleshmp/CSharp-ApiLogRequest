using System.Collections.Generic;
using System.Web.Http;

namespace LogRequestApi.Controllers
{
    public class ValuesController : ApiController
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpPost]
        public string Post(SimpleModel model)
        {
            return "Success";
        }
    }

    public class SimpleModel
    {
        public string key { get; set; }
        public string value { get; set; }
    }
}
