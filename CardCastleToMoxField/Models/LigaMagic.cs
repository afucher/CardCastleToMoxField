using CsvHelper.Configuration.Attributes;

namespace CardCastleToMoxField.Models;

//"Edicao (PTBR)","Edicao (EN)","Edicao (Sigla)","Card (PT)","Card (EN)","Quantidade","Qualidade (M NM SP MP HP D)","Idioma (BR EN DE ES FR IT JP KO RU TW)","Raridade (M R U C)","Cor (W U B R G M A L)","Extras","Card #","Comentario"
public class LigaMagic
{
    [Name("Quantidade")]
    public int Count { get; set; }
    [Name("Qualidade (M NM SP MP HP D)")]
    public string Condition { get; set; }
    [Name("Card (EN)")]
    public string CardName { get; set; }

    private string _SetName;
    [Name("Edicao (Sigla)")]
    public string SetName
    {
        get
        {
            switch (_SetName)
            {
                case "mb1":
                case "plist": return "plst";
                case "sh": return "sth";
                case "4eb": return "4ed";
                case "tp": return "tmp";
                default: return _SetName;
            }
        }
        set => _SetName = value;
    }
    [Name("Card #")]
    public string CollectorNumber { get; set; }
    [Name("Extras")]
    public string ExtraInfo { get; set; }
}