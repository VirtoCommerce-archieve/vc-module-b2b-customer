using System;
using FluentValidation;
using VirtoCommerce.B2BCustomerModule.Web.Model.Extensions;
using VirtoCommerce.B2BCustomerModule.Web.Model.Security;
using VirtoCommerce.Domain.Store.Services;
using VirtoCommerce.Platform.Core.Security;
using VirtoCommerce.Platform.Core.Settings;

namespace VirtoCommerce.B2BCustomerModule.Web.Services.Validation
{
    [CLSCompliant(false)]
    public abstract class RegistrationDataBaseValidator<T> : AbstractValidator<T>
        where T : RegistrationDataBase
    {
        protected RegistrationDataBaseValidator(ISecurityService securityService, IStoreService storeService, ISettingsManager settingsManager)
        {
            CascadeMode = CascadeMode.StopOnFirstFailure;            
            RuleFor(x => x.RecaptchaResponse).NotEmpty().RecaptchaValid(settingsManager);
            RuleFor(x => x.StoreId).NotEmpty().StoreExist(storeService);
            RuleFor(x => x.FirstName).NotEmpty();
            RuleFor(x => x.LastName).NotEmpty();
            //RuleFor(x => x.Title).NotEmpty();
            RuleFor(x => x.Email).EmailAddress();
            RuleFor(x => x.UserName).NotEmpty().UserDoesNotExist(securityService);
            RuleFor(x => x.Password).NotEmpty();
        }
    }
}