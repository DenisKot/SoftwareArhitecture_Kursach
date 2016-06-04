using System.Runtime.Serialization;

namespace SoftwareArchitecture.Data.Dto
{
    [DataContract]
    public class SiteDto
    {
        public int Id { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public string Url { get; set; }
    }
}
