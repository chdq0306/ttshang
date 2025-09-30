using Microsoft.Extensions.Localization;
using ttshang.Localization;
using Microsoft.Extensions.Localization;
using ttshang.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace ttshang.Blazor.Client;

[Dependency(ReplaceServices = true)]
public class ttshangBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<ttshangResource> _localizer;

    public ttshangBrandingProvider(IStringLocalizer<ttshangResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
