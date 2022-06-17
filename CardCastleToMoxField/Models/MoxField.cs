using CsvHelper.Configuration.Attributes;

namespace CardCastleToMoxField.Models;

//"Count","Tradelist Count","Name","Edition","Condition","Language","Foil","Tags","Last Modified","Collector Number"
public class MoxField
{
    public int Count { get; set; }
    [Name("Tradelist Count")]
    public int TradelistCount { get; set; }
    public string Name { get; set; }
    public string Edition { get; set; }
    public string Condition { get; set; }
    public string Language { get; set; }
    public bool Foil { get; set; }
    public List<string> Tags { get; set; }
    [Name("Last Modified")]
    public DateTime LastModified { get; set; }
    [Name("Collector Number")]
    public string CollectorNumber { get; set; }

    public static MoxField build(CardCastle cardCastle)
    {
        return new MoxField
        {
            Count = cardCastle.Count,
            TradelistCount = cardCastle.Count,
            Name = cardCastle.CardName,
            Edition = cardCastle.SetName,
            Condition = "Near Mint",
            Language = "en",
            Foil = cardCastle.Foil,
            Tags = new List<string>(),
            LastModified = DateTime.Now,
            CollectorNumber = cardCastle.CollectorNumber
        };
    }
}