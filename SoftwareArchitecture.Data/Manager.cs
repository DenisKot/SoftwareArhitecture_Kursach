using System.Collections.Generic;
using System.Linq;

namespace SoftwareArchitecture.Data
{
    public class Manager
    {
        public static IList<SiteInfo> GetSites()
        {
            var context = new DatabaseContext();

            return context.Sites.ToList();
        }
    }
}
