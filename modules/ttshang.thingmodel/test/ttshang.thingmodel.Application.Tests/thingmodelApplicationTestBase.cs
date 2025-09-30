using Volo.Abp.Modularity;

namespace ttshang.thingmodel;

/* Inherit from this class for your application layer tests.
 * See SampleAppService_Tests for example.
 */
public abstract class thingmodelApplicationTestBase<TStartupModule> : thingmodelTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
