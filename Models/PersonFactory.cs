class PersonFactory
{
    static List<string> Names { get; set; } = new List<string>();

    static void ReadNames()
    {
        var filePath = @"I:\Dev\Personal Projects\c-sharp-tutorial\TemporalParcelDelivery\Data\sci_fi_names.csv";
        var sciFiNames = new List<string>();

        using (var reader = new StreamReader(filePath))
        {
            // Skip header
            reader.ReadLine();

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var value = line.Trim(); // or split if more than one column
                sciFiNames.Add(value);
            }
        }
        Names = sciFiNames;
    }

    public static void Initialize()
    {
        ReadNames();
    }

    public static string GetRandomName()
    {
        Random i = new Random();
        return Names[i.Next(0, Names.Count + 1)];
    }
}