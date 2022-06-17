using System.Globalization;
using CardCastleToMoxField.Models;
using CsvHelper;

using var reader = new StreamReader("D:\\Downloads\\CardCastle.csv");
using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
using var writer = new StreamWriter("D:\\Downloads\\MoxField.csv");
using var csvwriter = new CsvWriter(writer, CultureInfo.InvariantCulture);

csvwriter.WriteRecords(
        csv.GetRecords<CardCastle>()
            .Select(c => MoxField.build(c)));