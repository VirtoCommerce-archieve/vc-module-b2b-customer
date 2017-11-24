using FluentValidation.Attributes;
using VirtoCommerce.B2BCustomerModule.Core.Model;
using VirtoCommerce.B2BCustomerModule.Web.Services.Validation;

namespace VirtoCommerce.B2BCustomerModule.Web.Model.Security
{
    [Validator(typeof(CompanyMemberRegistrationDataValidator))]
    public class CompanyMemberRegistrationData : CompanyMemberRegistrationDataBase
    {
        public string Role { get; set; }

        public override CompanyMember ToCompanyMember(CompanyMember companyMember, string memberId)
        {
            var retVal = base.ToCompanyMember(companyMember, memberId);
            retVal.IsActive = false;
            return retVal;
        }
    }
}