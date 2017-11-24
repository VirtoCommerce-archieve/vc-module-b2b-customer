using System;
using FluentValidation;
using VirtoCommerce.B2BCustomerModule.Web.Model.Extensions;
using VirtoCommerce.B2BCustomerModule.Web.Model.Security;
using VirtoCommerce.Domain.Customer.Services;
using VirtoCommerce.Domain.Store.Services;
using VirtoCommerce.Platform.Core.Security;

namespace VirtoCommerce.B2BCustomerModule.Web.Services.Validation
{
    [CLSCompliant(false)]
    public abstract class CompanyMemberRegistrationDataBaseValidator<T> : RegistrationDataBaseValidator<T>
        where T: CompanyMemberRegistrationDataBase
    {
        protected CompanyMemberRegistrationDataBaseValidator(ISecurityService securityService, IStoreService storeService, IMemberService memberService): base(securityService, storeService)
        {
            RuleFor(x => x.CompanyId).NotEmpty().CompanyExist(memberService);
        }
    }
}