using System.Text;

namespace Builder.Models
{
    internal class EmployeeReport
    {
        public string? Header { get; set; }
        public string? Body { get; set; }
        public string? Footer { get; set; }

        public override string ToString() => new StringBuilder(Header).Append(Body).Append(Footer).ToString();
    }
}
