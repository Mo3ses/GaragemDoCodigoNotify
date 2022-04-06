using Newtonsoft.Json;
using System;
using System.Collections.Generic;

public class YoutubeItem
{
    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("pubDate")]
    public string PubDate { get; set; }

    [JsonProperty("link")]
    public string Link { get; set; }

    [JsonProperty("guid")]
    public string Guid { get; set; }

    [JsonProperty("author")]
    public string Author { get; set; }

    [JsonProperty("thumbnail")]
    public string Thumbnail { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("content")]
    public string Content { get; set; }
}