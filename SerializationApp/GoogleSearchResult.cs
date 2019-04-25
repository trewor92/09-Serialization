using System.Collections.Generic;
using System.Runtime.Serialization;
namespace SerializationApp
{

    // TODO: Implement GoogleSearchResult class to be deserialized from Google Search API response
    // Specification is available at: https://developers.google.com/custom-search/v1/using_rest#WorkingResults
    // The test json file is at Serialization.Tests\Resources\GoogleSearchJson.txt


    [DataContract]
    [KnownType(typeof(Url))]
    [KnownType(typeof(Queries))]
    [KnownType(typeof(Context))]
    [KnownType(typeof(Item))]
    public class GoogleSearchResult
    {
        [DataMember(Name = "kind")]  public string Kind { get; set; }
        [DataMember(Name = "url")]  public Url Url { get; set; }
        [DataMember(Name = "queries")]  public Queries Queries { get; set; }
        [DataMember(Name = "context")]  public Context Context { get; set; }
        [DataMember(Name = "items")]  public Item[] Items { get; set; }
    }

    [DataContract]
    public class Url
    {
        [DataMember(Name = "type")]  public string Type { get; set; }
        [DataMember(Name = "template")]  public string Template { get; set; }
    }

    [DataContract]
    [KnownType(typeof(Nextpage))]
    [KnownType(typeof(Request))]
    public class Queries
    {
        [DataMember(Name = "nextPage")] public Nextpage[] NextPage { get; set; }
        [DataMember(Name = "request")] public Request[] Request { get; set; }
        [DataMember(Name = "previousPage")] public string PreviousPage { get; set; }  //
}

    [DataContract]
    public class Nextpage
    {
        [DataMember(Name = "title")] public string Title { get; set; }
        [DataMember(Name = "totalResults")] public long TotalResults { get; set; }
        [DataMember(Name = "searchTerms")] public string SearchTerms { get; set; }
        [DataMember(Name = "count")] public int Count { get; set; }
        [DataMember(Name = "startIndex")] public int StartIndex { get; set; }
        [DataMember(Name = "inputEncoding")] public string InputEncoding { get; set; }
        [DataMember(Name = "outputEncoding")] public string OutputEncoding { get; set; }
        [DataMember(Name = "cx")] public string Cx { get; set; }
    }

    [DataContract]
    public class Request
    {
        [DataMember(Name = "title")] public string Title { get; set; }
        [DataMember(Name = "totalResults")] public long TotalResults { get; set; }
        [DataMember(Name = "searchTerms")] public string SearchTerms { get; set; }
        [DataMember(Name = "count")] public int Count { get; set; }
        [DataMember(Name = "startIndex")] public int StartIndex { get; set; }
        [DataMember(Name = "inputEncoding")] public string InputEncoding { get; set; }
        [DataMember(Name = "outputEncoding")] public string OutputEncoding { get; set; }
        [DataMember(Name = "cx")] public string Cx { get; set; }
    }

    [DataContract]
    public class Context
    {
        [DataMember(Name = "title")] public string Title { get; set; }
    }

    [DataContract]
    [KnownType(typeof(Pagemap))]
    public class Item
    {
        [DataMember(Name = "kind")] public string Kind { get; set; }
        [DataMember(Name = "title")] public string Title { get; set; }
        [DataMember(Name = "htmlTitle")] public string HtmlTitle { get; set; }
        [DataMember(Name = "link")] public string Link { get; set; }
        [DataMember(Name = "displayLink")] public string DisplayLink { get; set; }
        [DataMember(Name = "snippet")] public string Snippet { get; set; }
        [DataMember(Name = "htmlSnippet")] public string HtmlSnippet { get; set; }
        [DataMember(Name = "pagemap")] public Pagemap Pagemap { get; set; }
    }

    [DataContract]
    [KnownType(typeof(RTO))]
    public class Pagemap
    {
        [DataMember] public RTO[] RTO { get; set; }
    }

    [DataContract]
    public class RTO
    {
        [DataMember] public string format { get; set; }
        [DataMember] public string group_impression_tag { get; set; }
        [DataMember] public string Optmax_rank_top { get; set; }
        [DataMember] public string Optthreshold_override { get; set; }
        [DataMember] public string Optdisallow_same_domain { get; set; }
        [DataMember] public string Outputtitle { get; set; }
        [DataMember] public string Outputwant_title_on_right { get; set; }
        [DataMember] public string Outputnum_lines1 { get; set; }
        [DataMember] public string Outputtext1 { get; set; }
        [DataMember] public string Outputgray1b { get; set; }
        [DataMember] public string Outputno_clip1b { get; set; }
        [DataMember] public string UrlOutputurl2 { get; set; }
        [DataMember] public string Outputlink2 { get; set; }
        [DataMember] public string Outputtext2b { get; set; }
        [DataMember] public string UrlOutputurl2c { get; set; }
        [DataMember] public string Outputlink2c { get; set; }
        [DataMember] public string result_group_header { get; set; }
        [DataMember] public string Outputimage_url { get; set; }
        [DataMember] public string image_size { get; set; }
        [DataMember] public string Outputinline_image_width { get; set; }
        [DataMember] public string Outputinline_image_height { get; set; }
        [DataMember] public string Outputimage_border { get; set; }
    }



    
    }



