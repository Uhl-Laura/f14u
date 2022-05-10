using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace f14u_server.Models
{
    public class CarComponent
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("team")]
        public string Team { get; set; }
        [BsonElement("driver")]
        public string Driver { get; set; }
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonElement("availabilityCount")]
        public int AvailabilityCount { get; set; } = 5;

    }
}