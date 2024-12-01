
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

int result = 0;
for (int i = 0; i < column1.Count; i++)
{
    result += Math.Abs(column1[i] - column2[i]);
}

Console.WriteLine(result);