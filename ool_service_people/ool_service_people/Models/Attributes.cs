using MongoDB.Bson.Serialization.Attributes;

namespace ool_service_people.Models
{
    public class Attributes
    {
        [BsonRequired]
        public int Force { get; set; }
        [BsonRequired]
        public int Intelligence { get; set; }
        [BsonRequired]
        public int Charisma { get; set; }
        [BsonRequired]
        public int Agility { get; set; }
    }
}