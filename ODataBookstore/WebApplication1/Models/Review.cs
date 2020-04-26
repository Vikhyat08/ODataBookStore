using System.Runtime.Serialization;

namespace ODataBookstore.Models
{
    [DataContract(Name="bookReview")]
    public class BookReview
    {
        [DataMember(Name="rating")]
        public int Rating { get; set; }

        [DataMember(Name = "review")]
        public string Review { get; set; }
    }
}
