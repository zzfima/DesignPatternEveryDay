using Builder;
using Builder.Builders;
using Builder.Directors;

var employees = new List<Employee>()
{
    new Employee(){ Name="Shady", Salary = 3000},
    new Employee(){ Name="Abu Said", Salary = 2700}
};

var builder = new AwfullEmployeeReportBuilder(employees);

var director = new EmployeeReportDirectorGaza(builder);

director.Build();

Console.WriteLine(builder.GetEmployeeReport());

Console.ReadLine();