using dolgozat11_26;
using System.Text;

List<Nagyvaros> Nagyvarosok = new();

using StreamReader sr = new(@"../../../src/varosok.csv",Encoding.UTF8);
_ = sr.ReadLine();
while (!sr.EndOfStream)
{
    Nagyvarosok.Add(new(sr.ReadLine()));
}

Console.WriteLine(Nagyvarosok.Count);

var v1 = Nagyvarosok.Where(v => v.CountryName == "Kína").Sum(v => v.Population);
Console.WriteLine("\n1. feladat\n" +
    $"Kínai nagyvárosokban összesen: {v1} millió fő él.");

var v2 = Nagyvarosok.Where(v => v.CountryName == "India").Average(v => v.Population);
Console.WriteLine("\n2. feladat\n"+
    $"Indiai nagyvárosok átlaglélekszáma: {v2} millió fő.");

var v3 = Nagyvarosok.MaxBy(v => v.Population);
Console.WriteLine("\n3. feladat\n" +
    $"A legnépesebb nagyváros: {v3.CityName}");

var vlist1 = Nagyvarosok.Where(v => v.Population > 20).ToList().OrderByDescending(v=> v.Population);
Console.WriteLine("\n4. feladat\n" +
    "20M feletti város lista:");

foreach (var item in vlist1)
{
    Console.WriteLine(item.CityName);
}

var o1 = Nagyvarosok.GroupBy(v => v.CountryName).Count(v => v.Count() > 1);

Console.WriteLine("\n5. feladat\n" +
    $"{o1} nagyvaros");

var o2 = Nagyvarosok.GroupBy(v => v.CityName[0]).MaxBy(v=> v.Count());
Console.WriteLine("\n6. feladat\n" +
    $"Lrgtobb angyvaros neve: \"{o2.Key}\" betűvel kezdődik.");

Console.ReadKey();