using FluentValidation.Attributes;
using VirtoCommerce.B2BCustomerModule.Web.Services.Validation;

namespace VirtoCommerce.B2BCustomerModule.Web.Model.Security
{
    [Validator(typeof(CompanyMemberRegistrationByInviteDataValidator))]
    public class CompanyMemberRegistrationByInviteData : CompanyMemberRegistrationDataBase
    {
    }
}