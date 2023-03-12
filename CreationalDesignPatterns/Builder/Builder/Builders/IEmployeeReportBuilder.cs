using Builder.Models;

namespace Builder.Builders
{
    internal interface IEmployeeReportBuilder
    {
        void BuildHeader();
        void BuildBody();
        void BuildFooter();

        EmployeeReport GetEmployeeReport();
    }
}
