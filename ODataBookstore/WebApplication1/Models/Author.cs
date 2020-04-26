using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ODataBookstore.Models
{
    [DataContract(Name = "author")]
    public class Author
    {
        [Key]
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name="name")]
        public string Name { get; set; }

        [DataMember(Name="books")]
        public IEnumerable<Book> Books { get; set; }

    }
}
