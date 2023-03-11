using Builder.Builders;

namespace Builder.Directors
{
    internal class EmployeeReportDirectorGaza : IEmployeeReportDirector
    {
        public EmployeeReportDirectorGaza(IEmployeeReportBuilder employeeReportBuilder)
        {
            EmployeeReportBuilder = employeeReportBuilder;
        }

        public IEmployeeReportBuilder EmployeeReportBuilder { get; }

        public void Build()
        {
            EmployeeReportBuilder.BuildHeader();
            EmployeeReportBuilder.BuildHeader();
            EmployeeReportBuilder.BuildHeader();
        }
    }
}
