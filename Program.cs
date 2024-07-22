var marksPerSubject = new Dictionary<string, int>()
{
    {"math",10},
    {"chemistry",8 },
    {"literature",5 },
    {"geography",4 },
    {"physics",9},
    {"physical education",11 }
};
var marksForRetest = marksPerSubject.Where(mark => mark.Value < 6);
Console.WriteLine("The next marks need to be redone:");
foreach (var mark in marksForRetest)
{
    Console.WriteLine($"{mark.Key}:{mark.Value}");
}