using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace f14u_server.Models
{
    public class Penalty
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("teamname")]
        public string TeamName { get; set; }
        [BsonElement("drivername")]
        public string DriverName { get; set; }
        [BsonElement("stewardname")]
        public string StewardName { get; set; }
    }
}
