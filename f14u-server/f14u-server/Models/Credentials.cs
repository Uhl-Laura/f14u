using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace f14u_server.Models
{
    public class Credentials
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("car")]
        public string car { get; set; }
        [BsonElement("change")]
        public string change { get; set; }
        [BsonElement("constructor")]
        public string constructor { get; set; }
        [BsonElement("count")]
        public int count { get; set; }
        [BsonElement("driver")]
        public string driver { get; set; }
    }
}
