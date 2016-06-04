using System.Collections.Generic;
using System.Web;
using SoftwareArchitecture.Data.Controllers.Impl;

namespace SoftwareArchitecture.Data.Proxy
{
    public class ProxySiteSearchRequest
    {
        private readonly SiteSearchRequest _request;

        private readonly string _ip;

        public ProxySiteSearchRequest()
        {
            this._request = new SiteSearchRequest();
            _ip = HttpContext.Current.Request.UserHostAddress;
        }

        public List<SiteInfo> Get()
        {
            return this.Get(null);
        }

        public List<SiteInfo> Get(string param)
        {
            if (_ip == "::2")
                return new List<SiteInfo>();

            if(param != null)
                return _request.Get(param);

            return this._request.Get();
        }
    }
}
