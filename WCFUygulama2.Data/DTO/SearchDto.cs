using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WCFUygulama2.Data.DTO
{
    [DataContract]
    public class SearchDto
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int SkipCount { get; set; }
        [DataMember]

        public string DateTime { get; set; }

        [DataMember]
        public int Size { get; set; }
        [DataMember]
        public int From { get; set; }
    }
}
