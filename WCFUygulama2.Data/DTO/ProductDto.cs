using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WCFUygulama2.Data.DTO
{
    [DataContract]
    public class ProductDto
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string ProductName { get; set; }
        [DataMember]
        public double Price { get; set; }
        [DataMember]
        public int Stock { get; set; }
        [DataMember]
        public string ImageBase64 { get; set; }

    }
}
