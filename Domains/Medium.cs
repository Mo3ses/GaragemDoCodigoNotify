using System;
using System.Collections.Generic;

public class Medium
{
    public Guid Guid { get; set; }
    public string Title { get; set; }
    public DateTime PubDate { get; set; }
    public string Link { get; set; }
    public string Author { get; set; }
    public string Thumbnail { get; set; }
    public string Description { get; set; }
    public string Content { get; set; }
    public IList<string> Categories { get; set; }
}