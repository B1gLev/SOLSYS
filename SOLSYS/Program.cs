using SOLSYS;

List<Bolygo> bolygok = new();
using (StreamReader r = new(path: "solsys.txt"))
{
    while (!r.EndOfStream)
        bolygok.Add(new Bolygo(r.ReadLine()));
}

Console.WriteLine($"{bolygok.Count} bolyóg van a naprendszerben");

var atlagHoldak = bolygok.Average(b => b.Holdak);
Console.WriteLine($"A nrpednszerben egy bolygónak átlaghosan {atlagHoldak} holdja van.");

var legTerfogatBoly = bolygok.SingleOrDefault(b => b.Terfogat == bolygok.Max(b2 => b2.Terfogat));
Console.WriteLine($"A legnagyobb téfegoatú bolygó a {legTerfogatBoly.Neve}");

Console.Write("Írd be a keresett bolygó nevét: ");
var bolyNev = Console.ReadLine();
Console.WriteLine(bolygok.SingleOrDefault(b => b.Neve == bolyNev) != null ? 
    "Van ilyen bolygó a naprendszerben." : 
    "Sajnos nincs ilyen nevű bolygó a naprendszerben.");

Console.Write("Írj be egy egész számot: ");
var szam = int.Parse(Console.ReadLine());
var tobbHold = bolygok.Where(b => b.Holdak > szam).Select(b => b.Neve).ToArray();
Console.WriteLine("A következő bolygóknak van 10-nál/nél több holdja:");
foreach (var i in tobbHold)
    Console.Write($"{i}, ");