using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ool_service_user.Models
{
    public class User
    {
        [JsonIgnore]
        public ObjectId Id { get; set; }
        [BsonRequired]
        public string Email { get; set; }
        [BsonRequired]
        public string Password { get; set; }
        [BsonRequired]
        public string Name { get; set; }
        [JsonProperty]
        public string IdUser
        {
            get => this.Id.ToString();
        }
    }
}
