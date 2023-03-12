using Prototype.Models;

namespace Prototype
{
    internal interface IEmployeePrototype
    {
        Employee GetClone();
    }
}