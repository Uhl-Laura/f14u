<<<<<<< HEAD
﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
>>>>>>> 6ccada85e52d299e6f57d2cba011e05f27264f96

namespace f14u_server.Models
{
    public class CarComponent
<<<<<<< HEAD
    {   [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("team")]
        public string TeamName { get; set; }
        [BsonElement("driver")]
        public string DriverName { get; set; }
        [BsonElement("availabilitycount")]
        public int AvaibailityCount { get; set; }
        [BsonElement("name")]
        public string NameComponent { get; set; }
=======
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

>>>>>>> 6ccada85e52d299e6f57d2cba011e05f27264f96
    }
}
