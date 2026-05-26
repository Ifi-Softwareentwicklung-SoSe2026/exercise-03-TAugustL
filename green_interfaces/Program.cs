using green_interfaces;

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
