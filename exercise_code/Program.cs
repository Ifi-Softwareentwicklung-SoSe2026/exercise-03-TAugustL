using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using RaumfahrtMission;

class Program
{
    static void Main(string[] args)
    {
        // Aufgabe 1: Himmelskörper erstellen (aus Aufgabe 02)
        Stern sonne = new Stern("Sonne", 10001, 'G', -26.74f);
        Planet erde = new Planet("Erde", 20001, 1.0f, 10001);
        Mond mond = new Mond("Mond", 30001, 0.0748f, 20001);
        var halley = new Planet(
            name: "Halley'scher Komet",
            katalogNummer: 40001,
            umlaufzeit: 76.0f,
            katalogNummerReferenz: 10001
        );

        /*
        // Aufgabe 1: Interfaces testen
        IMissionsobjekt[] objekte = { sonne, erde, mond };
        foreach (var obj in objekte)
        {
            Console.WriteLine(obj.GetStatusBericht());
        }
        Console.WriteLine(erde.IstGroesserAls(mond));
        Console.WriteLine(sonne.VergleicheMit(erde));//*/


        /*
        // Aufgabe 2: MissionsKatalog mit generischen Kollektionen
        MissionsKatalog katalog = new MissionsKatalog();
        katalog.Hinzufuegen(sonne);
        katalog.Hinzufuegen(erde);
        katalog.Hinzufuegen(mond);
        katalog.Hinzufuegen(halley);

        foreach (var planet in katalog.OfType<Planet>())
            Console.WriteLine(planet);

        var gefunden = katalog.FindeNachKatalogNummer(20001);
        Console.WriteLine(gefunden?.GetStatusBericht() ?? "Nicht gefunden");

        var langsamePlaneten = katalog.OfType<Planet>()
                                       .Where(p => p.Umlaufzeit > 1.0f)
                                       .OrderBy(p => p.Umlaufzeit);
        Console.WriteLine("Planeten mit Umlaufzeit > 1 Jahr:");
        foreach (var p in langsamePlaneten)
            Console.WriteLine($"  {p.Name}: {p.Umlaufzeit} Jahre");//*/


        /*
        // Aufgabe 3: CSV-Serialisierung
        KatalogSerializer serializer = new KatalogSerializer();
        serializer.SpeichereAlsCsv(katalog, "mission_katalog.csv");
        Console.WriteLine("Katalog gespeichert.");

        MissionsKatalog geladenerKatalog = serializer.LadeAusCsv("mission_katalog.csv");
        Console.WriteLine($"Geladene Himmelskörper: {geladenerKatalog.Count()}");
        foreach (var k in geladenerKatalog)
            Console.WriteLine(k.GetStatusBericht());//*/


        /*
        // Aufgabe 4: Erweiterungsmethoden
        Console.WriteLine("=== Alle Sterne ===");
        katalog.NurSterne().AlleAusgeben();

        Console.WriteLine("=== Planeten nach Umlaufzeit ===");
        katalog.NurPlaneten()
               .OrderBy(p => p.Umlaufzeit)
               .AlleAusgeben();//*/
    }
}
