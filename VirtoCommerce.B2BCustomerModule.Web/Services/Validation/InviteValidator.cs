using System;
using System.Linq;
using FluentValidation;
using VirtoCommerce.B2BCustomerModule.Core.Model;
using VirtoCommerce.B2BCustomerModule.Core.Resources;
using VirtoCommerce.B2BCustomerModule.Web.Model.Security;
using VirtoCommerce.Domain.Customer.Services;

namespace VirtoCommerce.B2BCustomerModule.Web.Services.Validation
{
    [CLSCompliant(false)]
    public class InviteValidator : AbstractValidator<Invite>
    {
        public InviteValidator(IMemberService memberService)
        {
            CascadeMode = CascadeMode.StopOnFirstFailure;

            CompanyMember member = null;
            RuleFor(x => x.Value).NotEmpty()
                .Must(i => (member = memberService.GetByIds(new[] { i }).OfType<CompanyMember>().SingleOrDefault()) != null)
                .WithMessage(B2BCustomerResources.InvalidInvite)
                .Must(i => (member = memberService.GetByIds(new[] { i }).OfType<CompanyMember>().SingleOrDefault()).IsActive)
                .WithMessage(B2BCustomerResources.InviteInactive)
                .Must(i => !member.SecurityAccounts.Any())
                .WithMessage(B2BCustomerResources.InviteAlreadyUsed);
        }
    }
}