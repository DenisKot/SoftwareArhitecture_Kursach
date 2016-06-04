using System.Collections.Generic;

namespace SoftwareArchitecture.Data.Controllers
{
    interface ISearchRequest<T>
    {
        List<T> Get();

        List<T> Get(string param);
    }
}
