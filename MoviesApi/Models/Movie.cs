using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace MoviesApi.Models
{
    public class Movie
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Title")]
        [JsonProperty("Title")]
        public string MovieTitle { get; set; }

        public string Director { get; set; }

        public string Category { get; set; }

        public string Rating { get; set; }
    }
}