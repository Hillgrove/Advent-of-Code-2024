
string filename = "input.txt";

List<int> column1 = new List<int>();
List<int> column2 = new List<int>();

using (StreamReader reader = new StreamReader(filename))
{
    string line;
    while ((line = reader.ReadLine()) != null)
    {
        string[] parts = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        if (parts.Length >= 2)
        {
            column1.Add(int.Parse(parts[0]));
            column2.Add(int.Parse(parts[1]));
        }
    }
}

column1.Sort();
column2.Sort();


// Part 1
int distance = 0;
for (int i = 0; i < column1.Count; i++)
{
    distance += Math.Abs(column1[i] - column2[i]);
}

Console.WriteLine("Solution to part 1");
Console.WriteLine($"The distance is: {distance}");




// Part 2: Calculate similarity
var column2Counts = column2.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());
int similarity = 0;
foreach (var value in column1)
{
    if (column2Counts.TryGetValue(value, out int count))
    {
        similarity += count * value;
    }
}

Console.WriteLine("Solution to part 2");
Console.WriteLine($"The similarity is: {similarity}");
