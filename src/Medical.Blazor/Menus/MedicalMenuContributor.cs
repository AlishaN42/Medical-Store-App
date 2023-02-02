using System.Threading.Tasks;
using Medical.Localization;
using Medical.MultiTenancy;
using Medical.Permissions;
using Volo.Abp.Identity.Blazor;
using Volo.Abp.SettingManagement.Blazor.Menus;
using Volo.Abp.TenantManagement.Blazor.Navigation;
using Volo.Abp.UI.Navigation;

namespace Medical.Blazor.Menus;

public class MedicalMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        var administration = context.Menu.GetAdministration();
        var l = context.GetLocalizer<MedicalResource>();

        context.Menu.Items.Insert(
            0,
            new ApplicationMenuItem(
                MedicalMenus.Home,
                l["Dashboard"],
                "/",
                icon: "fa fa-tachometer",
                order: 0
            )
        );

       // if (await context.IsGrantedAsync(MedicalPermissions.Products.Default))
       // {

            context.Menu.AddItem(
                new ApplicationMenuItem(
                    "Medical",
                    l["Menu:Medical"],
                    icon: "fas fa-plus-square"
                ).AddItem(
                    new ApplicationMenuItem(
                        "Medical.Products",
                        l["Products"],
                        url: "/Products"
                    )
                )
            );


            if (MultiTenancyConsts.IsEnabled)
            {
                administration.SetSubItemOrder(TenantManagementMenuNames.GroupName, 1);
            }
            else
            {
                administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
            }

            administration.SetSubItemOrder(IdentityMenuNames.GroupName, 2);
            administration.SetSubItemOrder(SettingManagementMenus.GroupName, 3);

        return ;
        }
    }
//}
