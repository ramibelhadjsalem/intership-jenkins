using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace intership_jenkins.Entities
{
    public class BaseEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        public DateTime CreatedAt { get; set; } =DateTime.UtcNow;
        public DateTime UpdateAt { get; set; }

        public DateTime DeletedAt { get; set; }

        public bool Enabeled { get; set; } = true;
    }
}
