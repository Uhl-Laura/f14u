using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace f14u_server.Models
{
    public class Driver
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("driver")]
        public string DriverName { get; set; }
<<<<<<< HEAD
        [BsonElement("team")]
        public string TeamName { get;set; }
=======
       [BsonElement("team")]
       public string TeamName { get;set; }
>>>>>>> 6ccada85e52d299e6f57d2cba011e05f27264f96
        [BsonElement("username")]
        public string Username { get; set; }
    }
}
