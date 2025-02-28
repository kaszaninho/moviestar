﻿using System.Text.Json.Serialization;

namespace MobileApp.ViewModels.AboutUs
{
    public class WebsiteResponse
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        [JsonPropertyName("titleName")]
        public string? TitleName { get; set; }
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        [JsonPropertyName("content")]
        public string? Content { get; set; }
    }
}
