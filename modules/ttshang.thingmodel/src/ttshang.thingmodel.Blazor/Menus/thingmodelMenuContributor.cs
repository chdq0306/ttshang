using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace ttshang.thingmodel.Blazor.Menus;

public class thingmodelMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        //Add main menu items.
        context.Menu.AddItem(new ApplicationMenuItem(thingmodelMenus.Prefix, displayName: "thingmodel", "/thingmodel", icon: "fa fa-globe"));

        return Task.CompletedTask;
    }
}
