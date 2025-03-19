using Task1;

int n = int.Parse(Console.ReadLine());
var patients = new List<Patient>();

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split();

    var patient = new Patient
    {
        Id = int.Parse(input[0]),
        Name = input[1],
        Age = int.Parse(input[2]),
        Severity = int.Parse(input[3])
    };

    patients.Add(patient);
}

var sortedPatients = patients.OrderByDescending(p => p.Severity).ThenBy(p => p.Age).ToList();

Console.WriteLine();
foreach (var patient in sortedPatients)
{
    Console.WriteLine($"{patient.Id} {patient.Name} {patient.Age} {patient.Severity}");
}