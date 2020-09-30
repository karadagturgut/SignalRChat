using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ChatDeneme.Models
{
    public class ChatInfoModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string RoomId { get; set; }
        public Guid UserId { get; set; }
        public string Context { get; set; }
        public DateTime SendDate { get; set; }
    }
}