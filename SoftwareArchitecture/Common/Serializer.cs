using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Newtonsoft.Json;

namespace SoftwareArchitecture.Common
{
    public class Serializer
    {
        public static List<TTo> SerializeToList<TFrom, TTo>(List<TFrom> list)
        {
            var res = new List<TTo>();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<TFrom, TTo>());
            var mapper = config.CreateMapper();

            foreach (var item in list)
            {
                res.Add(mapper.Map<TTo>(item));
            }

            return res;
        }

        public static IEnumerable<string> SerializeToEnumerable<TFrom, TTo>(List<TFrom> list)
        {
            var res = new List<string>();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<TFrom, TTo>());
            var mapper = config.CreateMapper();

            foreach (var item in list)
            {
                res.Add(JsonConvert.SerializeObject(mapper.Map<TTo>(item)));
            }

            return res;
        }

        public static string SerializeToJson<TFrom, TTo>(List<TFrom> list)
        {
            var sb = new StringBuilder();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<TFrom, TTo>());
            var mapper = config.CreateMapper();

            foreach (var item in list)
            {
                sb.Append(JsonConvert.SerializeObject(mapper.Map<TTo>(item)));
            }

            return sb.ToString();
        }
    }
}