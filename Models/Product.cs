using ProductManager.Util;
using System.Text.Json.Serialization;

namespace ProductManager.Models
{
    public class Product
    {
        [JsonPropertyName("ID")]
        public string? ID { get; set; }
        [JsonPropertyName("Name")]
        public string? Name { get; set; }
        [JsonPropertyName("Price")]
        public string? Price { get; set; }
        [JsonPropertyName("Quantity")]
        public string? Quantity { get; set; }
    }
}
