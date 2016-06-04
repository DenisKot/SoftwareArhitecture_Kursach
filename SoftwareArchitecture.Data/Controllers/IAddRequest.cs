namespace SoftwareArchitecture.Data.Controllers
{
    interface IAddRequest<T>
    {
        bool Add(T item);
    }
}
