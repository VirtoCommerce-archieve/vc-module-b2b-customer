using FluentValidation.Attributes;
using VirtoCommerce.B2BCustomerModule.Web.Services.Validation;

namespace VirtoCommerce.B2BCustomerModule.Web.Model.Security
{
    [Validator(typeof(InviteValidator))]
    public class Invite
    {
        public string Value { get; set; }
    }
}