using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ChatServer.Model {
    public class ChatMember {
        [BsonRepresentation (BsonType.ObjectId)]
        public string UserId { get; set; }

        [BsonIgnore]
        public User User { get; set; }
    }
}