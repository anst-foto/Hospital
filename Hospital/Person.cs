namespace Hospital;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName => $"{LastName} {FirstName}";

    public DateTime DateOfBirth { get; set; }
    public int Age
    {
        get
        {
            var now = DateTime.Now;
            return now.Year - DateOfBirth.Year - 1 + ((now.Month > DateOfBirth.Month || now.Month == DateOfBirth.Month && now.Day >= DateOfBirth.Day) ? 1 : 0);
        }
    }
}