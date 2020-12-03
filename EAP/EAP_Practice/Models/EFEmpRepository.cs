using System.Linq;

namespace EAP_Practice.Models
{
    public class EFEmpRepository : IEmpRepository
    {
        private EmpDBContext context;

        public EFEmpRepository(EmpDBContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Employee> Employees => context.Employees; 
    }
}
