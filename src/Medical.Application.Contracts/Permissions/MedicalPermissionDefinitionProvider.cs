using Medical.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Medical.Permissions;

public class MedicalPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(MedicalPermissions.GroupName, L("Permission:Medical"));

        var ProductsPermission = myGroup.AddPermission(MedicalPermissions.Products.Default, L("Permission:Products"));
        ProductsPermission.AddChild(MedicalPermissions.Products.Create, L("Permission:Products.Create"));
        ProductsPermission.AddChild(MedicalPermissions.Products.Edit, L("Permission:Products.Edit"));
        ProductsPermission.AddChild(MedicalPermissions.Products.Delete, L("Permission:Products.Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<MedicalResource>(name);
    }
}
