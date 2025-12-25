using System.Collections.Generic;
using Newtonsoft.Json;

namespace LLMChatApp
{
    // API'ye göndereceğimiz istek yapısı
    public class CompletionRequest
    {
        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("messages")]
        public List<Message> Messages { get; set; }
    }

    // Mesaj yapısı (Hem istek hem cevap için)
    public class Message
    {
        [JsonProperty("role")]
        public string Role { get; set; } // "user" veya "assistant"

        [JsonProperty("content")]
        public string Content { get; set; }
    }

    // API'den dönen cevap yapısı
    public class CompletionResponse
    {
        [JsonProperty("choices")]
        public List<Choice> Choices { get; set; }
    }

    public class Choice
    {
        [JsonProperty("message")]
        public Message Message { get; set; }
    }
}