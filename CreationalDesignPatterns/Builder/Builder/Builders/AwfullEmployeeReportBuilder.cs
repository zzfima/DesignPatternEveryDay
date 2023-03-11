using System.Text;

namespace Builder.Builders
{
    internal class AwfullEmployeeReportBuilder : IEmployeeReportBuilder
    {
        private EmployeeReport _employeeReport;
        public IEnumerable<Employee> Employees { get; }

        public AwfullEmployeeReportBuilder(IEnumerable<Employee> employees)
        {
            _employeeReport = new EmployeeReport();
            Employees = employees;
        }

        public void BuildBody()
        {
            var body = new StringBuilder();
            foreach (var employee in Employees)
            {
                body.Append("Employee ");
                body.Append(employee.Name);
                body.Append(" not soo good and get ");
                body.Append(employee.Salary);
                body.Append("$ monthly. Its too much\n");
            }
            _employeeReport.Body += body.ToString();
        }

        public void BuildFooter() => _employeeReport.Footer += "This all about this awfull employee\n";

        public void BuildHeader() => _employeeReport.Header += "Awfull employee report\n";

        public EmployeeReport GetEmployeeReport() => _employeeReport;
    }
}
