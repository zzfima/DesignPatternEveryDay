using Builder.Builders;

namespace Builder.Directors
{
    internal class EmployeeReportDirectorUS : IEmployeeReportDirector
    {
        public EmployeeReportDirectorUS(IEmployeeReportBuilder employeeReportBuilder)
        {
            EmployeeReportBuilder = employeeReportBuilder;
        }

        public IEmployeeReportBuilder EmployeeReportBuilder { get; }

        public void Build()
        {
            EmployeeReportBuilder.BuildHeader();
            EmployeeReportBuilder.BuildBody();
            EmployeeReportBuilder.BuildFooter();
        }
    }
}
