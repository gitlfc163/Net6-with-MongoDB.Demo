using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Net6.with.MongoDB.Demo.Models;

public class Book : MongoDocBase
{
    [BsonElement("Name")]
    public string BookName { get; set; }

    public decimal Price { get; set; }

    public string Category { get; set; }

    public string Author { get; set; }
}

public class MongoDocBase
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
    public DateTime? CreatedDate { get; set; }

    [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
    public DateTime? UpdatedDate { get; set; }
}