using FluentValidation.Attributes;
using VirtoCommerce.B2BCustomerModule.Core.Services.Validation;
using VirtoCommerce.Domain.Customer.Model;

namespace VirtoCommerce.B2BCustomerModule.Core.Model
{
    [Validator(typeof(CompanyMemberValidator))]
    public class CompanyMember : Contact
    {
        public string Title { get; set; }
        public bool IsActive { get; set; }
    }
}