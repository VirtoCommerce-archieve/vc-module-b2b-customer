using System.Linq;
using VirtoCommerce.B2BCustomerModule.Data.Model;

namespace VirtoCommerce.B2BCustomerModule.Data.Repositories
{
    public interface ICorporateMembersRepository
    {
        IQueryable<DepartmentDataEntity> Departments { get; }
    }
}