using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;

namespace ttshang.thingmodel.Samples;

[Area(thingmodelRemoteServiceConsts.ModuleName)]
[RemoteService(Name = thingmodelRemoteServiceConsts.RemoteServiceName)]
[Route("api/thingmodel/example")]
public class ExampleController : thingmodelController, ISampleAppService
{
    private readonly ISampleAppService _sampleAppService;

    public ExampleController(ISampleAppService sampleAppService)
    {
        _sampleAppService = sampleAppService;
    }

    [HttpGet]
    public async Task<SampleDto> GetAsync()
    {
        return await _sampleAppService.GetAsync();
    }

    [HttpGet]
    [Route("authorized")]
    [Authorize]
    public async Task<SampleDto> GetAuthorizedAsync()
    {
        return await _sampleAppService.GetAsync();
    }
}
