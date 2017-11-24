using System;
using FluentValidation;
using VirtoCommerce.B2BCustomerModule.Core;
using VirtoCommerce.B2BCustomerModule.Core.Model;
using VirtoCommerce.B2BCustomerModule.Core.Model.Search;
using VirtoCommerce.B2BCustomerModule.Core.Resources;
using VirtoCommerce.B2BCustomerModule.Web.Model.Security;
using VirtoCommerce.Domain.Customer.Services;
using VirtoCommerce.Domain.Store.Services;
using VirtoCommerce.Platform.Core.Security;

namespace VirtoCommerce.B2BCustomerModule.Web.Services.Validation
{
    [CLSCompliant(false)]
    public class CompanyOwnerRegistrationDataValidator : RegistrationDataBaseValidator<CompanyOwnerRegistrationData>
    {
        public CompanyOwnerRegistrationDataValidator(ISecurityService securityService, IStoreService storeService, IMemberSearchService memberSearchService)
            : base(securityService, storeService)
        {
            RuleFor(x => x.CompanyName)
                .Must(x =>
                {
                    var r = memberSearchService.SearchMembers(new CorporateMembersSearchCriteria { Name = x, MemberType = typeof(Company).Name });
                    return r.TotalCount == 0;
                })
                .WithMessage(string.Format(B2BCustomerResources.CompanyAlreadyExist, Constants.PropertyValue));
        }
    }
}