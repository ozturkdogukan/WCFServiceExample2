using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace WCFUygulama2.Data.DTO
{
    [DataContract]
    public class CustomerDto
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]

        public string UserName { get; set; }
        [DataMember]

        public string Password { get; set; }

        [DataMember]

        public string Mail { get; set; }
    }
}
