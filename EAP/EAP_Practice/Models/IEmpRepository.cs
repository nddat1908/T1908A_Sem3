using System.Linq;

namespace EAP_Practice.Models
{
    public interface IEmpRepository
    {
        IQueryable<Employee> Employees { get; }
    }
}
