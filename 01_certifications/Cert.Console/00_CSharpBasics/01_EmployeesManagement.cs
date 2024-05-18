namespace CSharpBasics;

public class EmployeesManagement
{
    public static void Main() {}

    public static Dictionary<string, int> AverageAgeForEachCompany(List<Employee> employees)
    {
        var g = employees
        .GroupBy(x => x.Company)
        .OrderBy(x => x.Key)
        .ToDictionary(x => x.Key,
                      x => (int)Math.Round(x.Average(y => y.Age)));

        return g;
    }

    public static Dictionary<string, int> CountOfEmployeesForEachCompany(List<Employee> employees)
    {
        var g = employees
        .GroupBy(x => x.Company)
        .OrderBy(x => x.Key)
        .ToDictionary(x => x.Key, x => x.Count());

        return g;
    }

    public static Dictionary<string, Employee> OldestAgeForEachCompany(List<Employee> employees)
    {
        var g = employees
        .GroupBy(x => x.Company)
        .OrderBy(x => x.Key)
        .ToDictionary(x => x.Key,
                      x => x.OrderByDescending(y => y.Age)
                            .ToArray()[0]);

        return g;
    }

    public class Employee
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public int Age { get; set; }
        public required string Company { get; set; }
    }
}