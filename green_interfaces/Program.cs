public interface ICookable
{
    string GetCookingSuggestion();
}

public interface IWoodProducer 
{
    string GetWoodUsage();
}

public abstract class Plants(string name, uint ageInYears)
{
    public string? Name { get; set; } = name;
    public uint Alter { get; set; } = ageInYears;

    public abstract string GetDescription();
}

public class AppleTree(string name, uint ageInYears) : Plants(name, ageInYears), ICookable, IWoodProducer
{

    public override string GetDescription() 
    {
        return "Apfelbaum mit Äpfeln";
    }

    public string GetCookingSuggestion()
    {
        return "Einfach essen.";
    }

    public string GetWoodUsage()
    {
        return "Apfelholz. Aha.";
    }
}

public class Pumpkin(string name, uint ageInYears) : Plants(name, ageInYears), ICookable
{
    public override string GetDescription() 
    {
        return "Oranger Kürbis.";
    }

    public string GetCookingSuggestion()
    {
        return "Kürbisjoghurt mit ganzen Früchten.";
    }
}

public class ChestnutTree(string name, uint ageInYears) : Plants(name, ageInYears), IWoodProducer
{
    public override string GetDescription() 
    {
        return "Eine elegante Rosskastanie.";
    }

    public string GetWoodUsage()
    {
        return "Kastanien sollte man nicht essen. Das Holz ist bestimmt nutzbar.";
    }
}

public class Program {

    public static void Main()
    {
        var plants = new List<Plants>
        {
            new AppleTree("Boskoop", ageInYears: 5),
            new Pumpkin("Hokkaido", ageInYears: 1),
            new ChestnutTree("Maroni", ageInYears: 12)
        };

        foreach (var plant in plants)
        {
            Console.WriteLine(plant.GetDescription());

            if (plant is ICookable cookable)
            {
                Console.WriteLine($"  -> Kochbar: {cookable.GetCookingSuggestion()}");
            }

            if (plant is IWoodProducer woodProducer)
            {
                Console.WriteLine($"  -> Holz nutzbar: {woodProducer.GetWoodUsage()}");
            }
        }
    }
}
