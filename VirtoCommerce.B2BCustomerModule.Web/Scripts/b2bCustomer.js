//Call this to register our module to main application
var moduleTemplateName = "virtoCommerce.b2bCustomerModule";

if (AppDependencies !== undefined) {
    AppDependencies.push(moduleTemplateName);
}

angular.module(moduleTemplateName, [])
    .run(['virtoCommerce.customerModule.memberTypesResolverService', function (memberTypesResolverService) {
        // override Organization with Company
        var oldName = 'Organization';
        var newName = 'Company';
        var foundTemplate = memberTypesResolverService.resolve(oldName);
        angular.extend(foundTemplate, {
            memberType: newName,
            fullTypeName: 'VirtoCommerce.B2BCustomerModule.Core.Model.Company',
            icon: 'fa-building-o'
        });
        _.each(memberTypesResolverService.objects, function (template) {
            idx = template.knownChildrenTypes.indexOf(oldName);
            if (idx > -1) {
                template.knownChildrenTypes.splice(idx, 1, newName);
            }
        });
        
        // override Contact with CompanyMember
        oldName = 'Contact';
        newName = 'CompanyMember';
        foundTemplate = memberTypesResolverService.resolve(oldName);
        angular.extend(foundTemplate, {
            memberType: newName,
            fullTypeName: 'VirtoCommerce.B2BCustomerModule.Core.Model.CompanyMember',
            icon: 'fa-user-circle-o'
        });
        _.each(memberTypesResolverService.objects, function (template) {
            idx = template.knownChildrenTypes.indexOf(oldName);
            if (idx > -1) {
                template.knownChildrenTypes.splice(idx, 1, newName);
            }
        });
    }]);