﻿using System;
using VirtoCommerce.B2BCustomerModule.Web.Model.Security;
using VirtoCommerce.Domain.Customer.Services;
using VirtoCommerce.Domain.Store.Services;
using VirtoCommerce.Platform.Core.Security;

namespace VirtoCommerce.B2BCustomerModule.Web.Services.Validation
{
    [CLSCompliant(false)]
    public class CompanyMemberRegistrationByInviteDataValidator : CompanyMemberRegistrationDataBaseValidator<CompanyMemberRegistrationByInviteData>
    {
        public CompanyMemberRegistrationByInviteDataValidator(ISecurityService securityService, IStoreService storeService, IMemberService memberService) : base(securityService, storeService, memberService)
        {
        }
    }
}