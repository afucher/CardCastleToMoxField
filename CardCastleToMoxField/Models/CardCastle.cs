using CsvHelper.Configuration.Attributes;

namespace CardCastleToMoxField.Models;

//Count,Card Name,Set Name,Collector Number,Foil
public class CardCastle
{
    public int Count { get; set; }
    [Name("Card Name")]
    public string CardName { get; set; }
    [Name("Set Name")]
    public string SetName { get; set; }
    [Name("Collector Number")]
    public string CollectorNumber { get; set; }
    public bool Foil { get; set; }
}