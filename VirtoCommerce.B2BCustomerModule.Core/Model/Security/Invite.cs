using FluentValidation.Attributes;
using VirtoCommerce.B2BCustomerModule.Core.Services.Validation;

namespace VirtoCommerce.B2BCustomerModule.Core.Model.Security
{
    [Validator(typeof(InviteValidator))]
    public class Invite
    {
        public string Value { get; set; }
    }
}