using System;
using VirtoCommerce.B2BCustomerModule.Web.Model.Security;
using VirtoCommerce.Domain.Customer.Services;
using VirtoCommerce.Domain.Store.Services;
using VirtoCommerce.Platform.Core.Security;
using VirtoCommerce.Platform.Core.Settings;

namespace VirtoCommerce.B2BCustomerModule.Web.Services.Validation
{
    [CLSCompliant(false)]
    public class PersonalCustomerRegistrationDataValidator : RegistrationDataBaseValidator<PersonalCustomerRegistrationData>
    {
        public PersonalCustomerRegistrationDataValidator(ISecurityService securityService, IStoreService storeService, IMemberSearchService memberSearchService, ISettingsManager settingsManager)
            : base(securityService, storeService, settingsManager)
        {
        }
    }
}