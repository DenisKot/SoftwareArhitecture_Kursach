using System.Collections.Generic;
using System.Linq;
using AutoMapper;

namespace SoftwareArchitecture.Data.Visitor
{
    public class VistorMapper : IVisitor
    {
        public List<TTo> VisitMapToList<TFrom, TTo>(List<TFrom> list)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<TFrom, TTo>());
            var mapper = config.CreateMapper();

            return list.Select(item => mapper.Map<TTo>(item)).ToList();
        }
    }
}
