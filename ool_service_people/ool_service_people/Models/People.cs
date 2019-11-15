using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ool_service_people.Models
{
    public class People
    {

        [JsonIgnore]
        public ObjectId Id { get; set; }
        [BsonRequired]
        public string IdUser { get; set; }
        [BsonRequired]
        public string Name { get; set; }
        [BsonRequired]
        public int Age { get; set; }
        [BsonRequired]
        public Genre Genre { get; set; }
        [BsonRequired]
        public Attributes Attributes { get; set; }
        [JsonProperty("IdPeople")]
        public string IdPeople
        {
            get => this.Id.ToString();
        }
    }
}
