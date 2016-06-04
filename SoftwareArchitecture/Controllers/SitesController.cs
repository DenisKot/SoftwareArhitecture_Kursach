using System.Collections.Generic;
using System.Web.Http;
using SoftwareArchitecture.Data;
using SoftwareArchitecture.Data.Dto;
using SoftwareArchitecture.Data.Proxy;
using SoftwareArchitecture.Data.Visitor;

namespace SoftwareArchitecture.Controllers
{
    public class SitesController : ApiController
    {
        // GET api/<controller>
        public List<SiteDto> Get()
        {
            var request = new ProxySiteSearchRequest();
            var list = request.Get();

            var mapper = new VistorMapper();
            return mapper.VisitMapToList<SiteInfo, SiteDto>(list);
        }

        // GET api/<controller>/5
        public List<SiteDto> Get(string id)
        {
            var request = new ProxySiteSearchRequest();
            var list = request.Get(id);

            var mapper = new VistorMapper();
            return mapper.VisitMapToList<SiteInfo, SiteDto>(list);
        }

        // POST api/<controller>
        public List<SiteDto> Post([FromBody]string id)
        {
            var request = new ProxySiteSearchRequest();
            var list = request.Get(id);

            var mapper = new VistorMapper();
            return mapper.VisitMapToList<SiteInfo, SiteDto>(list);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}