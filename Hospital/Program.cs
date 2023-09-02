using Hospital;

var patients = new List<Patient>
{
    new()
    {
        LastName = "Patient",
        FirstName = "Patient_2",
        DateOfBirth = new DateTime(2010, 1, 1),
        Diseases = new List<string>
        {
            "y1", "m10"
        }
    },
    new()
    {
        LastName = "Patient",
        FirstName = "Patient_1",
        DateOfBirth = new DateTime(2000, 1, 1),
        Diseases = new List<string>
        {
            "d1", "m10"
        }
    },
    new()
    {
        LastName = "Patient",
        FirstName = "Patient_5",
        DateOfBirth = new DateTime(1920, 1, 1),
        Diseases = new List<string>
        {
            "x1", "z10"
        }
    }
};

PrintPatients(patients);

Console.WriteLine(@"/// ||| \\\");

var sortedList = patients.OrderBy(p => p.FullName);
PrintPatients(sortedList);

Console.WriteLine(@"/// ||| \\\");

sortedList = patients.OrderBy(p => p.Age);
PrintPatients(sortedList);

Console.WriteLine(@"/// ||| \\\");

var disease = "m10";
var listOfPatients = patients.Where(p => p.Diseases.Contains(disease));
PrintPatients(listOfPatients);

return;

void PrintPatients(IEnumerable<Patient> patients)
{
    foreach (var patient in patients)
    {
        Console.Write($"{patient.FullName}, {patient.Age}: ");
        foreach (var disease in patient.Diseases)
        {
            Console.Write($"{disease} ");
        }
        Console.WriteLine();
    }
}