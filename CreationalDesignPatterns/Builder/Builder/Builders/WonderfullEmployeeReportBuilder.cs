using System.Text;

namespace Builder.Builders
{
    internal class WonderfullEmployeeReportBuilder : IEmployeeReportBuilder
    {
        private EmployeeReport _employeeReport;
        public IEnumerable<Employee> Employees { get; }

        public WonderfullEmployeeReportBuilder(IEnumerable<Employee> employees)
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
                body.Append(" very good and get ");
                body.Append(employee.Salary);
                body.Append("$ monthly. We need up the salary! \n");
            }
            _employeeReport.Body += body.ToString();
        }

        public void BuildFooter() => _employeeReport.Footer += "This all about wonderfull employee\n";

        public void BuildHeader() => _employeeReport.Header += "Wonderfull employee report\n";

        public EmployeeReport GetEmployeeReport() => _employeeReport;
    }
}
