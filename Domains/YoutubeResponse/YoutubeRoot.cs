using Newtonsoft.Json;
using System.Collections.Generic;
public class YoutubeRoot
{
    [JsonProperty("items")]
    public List<YoutubeItem> Items { get; set; }
}
