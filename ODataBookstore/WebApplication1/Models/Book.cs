using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ODataBookstore.Models
{
    [DataContract(Name="book")]
    public class Book
    {
        [Key]
        [Required]
        [DataMember(Name="isbn")]
        public string Isbn { get; set; }

        [Required]
        [DataMember(Name ="title")]
        public string Title { get; set; }

        [DataMember(Name="price")]
        public int Price { get; set; }
        
    }
}
