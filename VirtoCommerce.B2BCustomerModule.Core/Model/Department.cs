using VirtoCommerce.Domain.Customer.Model;

namespace VirtoCommerce.B2BCustomerModule.Core.Model
{
    public class Department : Member
    {
        public string ParentId { get; set; }
    }
}