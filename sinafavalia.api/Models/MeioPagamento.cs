using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace sinafavalia.api.models
{
    public class MeioPagamento
    {
        public MeioPagamento()
        {
        }

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]

        public string Id { get; set; } = string.Empty;
        public string? nomeCliente { get; set; }

        public int valor { get; set; }
        public int linhaDigitavel { get; set; }

        public int qrcode { get; set; }
        public int tipoPagamento { get; set; }
        public string? processado { get; set; }

    }
}

