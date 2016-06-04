using System.Collections.Generic;

namespace SoftwareArchitecture.Data.Visitor
{
    public interface IVisitor
    {
        List<TTo> VisitMapToList<TFrom, TTo>(List<TFrom> list);
    }
}
