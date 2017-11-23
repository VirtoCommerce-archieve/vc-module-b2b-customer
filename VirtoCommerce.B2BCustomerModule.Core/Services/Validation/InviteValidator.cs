using System;
using System.Linq;
using FluentValidation;
using VirtoCommerce.B2BCustomerModule.Core.Model;
using VirtoCommerce.B2BCustomerModule.Core.Model.Security;
using VirtoCommerce.B2BCustomerModule.Core.Resources;
using VirtoCommerce.Domain.Customer.Services;

namespace VirtoCommerce.B2BCustomerModule.Core.Services.Validation
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
                .Must(i => !member.SecurityAccounts.Any())
                .WithMessage(B2BCustomerResources.InviteAlreadyUsed);
        }
    }
}