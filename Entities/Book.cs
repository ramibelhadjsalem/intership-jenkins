using MongoDB.Bson.Serialization.Attributes;

namespace intership_jenkins.Entities
{
    public class Book :BaseEntity
    {
        [BsonElement("Name")]
        public string BookName { get; set; } = null!;

        public decimal Price { get; set; }

        public string Category { get; set; } = null!;

        public string Author { get; set; } = null!;
    }
}
