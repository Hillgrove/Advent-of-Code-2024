
string input = """
7 6 4 2 1
1 2 7 8 9
9 7 6 2 1
1 3 2 4 5
8 6 4 4 1
1 3 6 7 9
""";

int MIN_DIFFERENCE = 1;
int MAX_DIFFERENCE = 3;

var rows = input.Split("\r\n");
var data = rows.Select(row => row.Trim()
                                 .Split(" ")
                                 .Select(int.Parse)
                                 .ToList())
               .ToList();

foreach (var row in data)
{
    Console.WriteLine($"[{String.Join(", ", row)}]");
}

int safeReports = 0;
foreach (var row in data)
{
    for (int i = 0; i < row.Count - 1; i++)
    {
        int difference = Math.Abs(row[i] - row[i + 1]);
        if (MIN_DIFFERENCE < difference || difference > MAX_DIFFERENCE)
        {
            break;
        }


    }
}