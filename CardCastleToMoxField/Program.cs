using System.Globalization;
using CardCastleToMoxField.Models;
using CsvHelper;

using var reader = new StreamReader("D:\\Downloads\\ligamagic.csv");
using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
using var writer = new StreamWriter("D:\\Downloads\\MoxField.csv");
using var csvwriter = new CsvWriter(writer, CultureInfo.InvariantCulture);

csvwriter.WriteRecords(
        csv.GetRecords<LigaMagic>()
            .Select(c => MoxField.build(c)));