
using MusicalInstrument.Abstracts;
using MusicalInstrument.Entities;
using System.Collections;
using System.Reflection;

ArrayList Instruments = new ArrayList();

Piano Piano = new Piano();
Gitar Gitar = new Gitar();
Flute Flute = new Flute();
Drums Drums = new Drums();

Piano.Sound();
Gitar.Sound();
Flute.Sound();
Drums.Sound();

Instruments.Add(Piano);
Instruments.Add(Gitar);
Instruments.Add(Flute);
Instruments.Add(Drums);

PrintAllInstruments(Instruments);

 
static void PrintAllInstruments(ArrayList instruments)
{
    foreach (var item in instruments)
    {
        var propinfo = item.GetType().GetProperties(BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);
        Console.WriteLine($"Instrument : {item.GetType().Name}");
        Console.WriteLine("Properties");

        Array.ForEach(propinfo, x => Console.WriteLine($"{x.Name} : {x.GetValue(item)}"));
        Console.WriteLine("---------------------");
    }
}