using System.Collections.Generic;
using System.Linq;
using SoftwareArchitecture.Data.Prototype;

namespace SoftwareArchitecture.Data.Controllers.Impl
{
    public class SiteSearchRequest : ISearchRequest<SiteInfo>
    {
        public List<SiteInfo> Get()
        {
            DatabaseContext context = new DatabaseContext();//Context.GetConext() as DatabaseContext;
            return context.Sites.ToList();
        }

        public List<SiteInfo> Get(string param)
        {
            DatabaseContext context = Context.GetConext() as DatabaseContext;
            var res = from m in context.Sites
                      where m.Title.Contains(param)
                      select m;

            return res.ToList();
        }
    }
}
