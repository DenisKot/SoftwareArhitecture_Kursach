using SoftwareArchitecture.Data.Prototype;

namespace SoftwareArchitecture.Data.Controllers.Impl
{
    public class SiteAddRequest : IAddRequest<SiteInfo>
    {
        public bool Add(SiteInfo item)
        {
            DatabaseContext context = new DatabaseContext();//Context.GetConext() as DatabaseContext;
            context.Sites.Add(item);
            context.SaveChanges();

            return true;
        }
    }
}
