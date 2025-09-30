using Volo.Abp.Modularity;

namespace ttshang.thingmodel;

/* Inherit from this class for your domain layer tests.
 * See SampleManager_Tests for example.
 */
public abstract class thingmodelDomainTestBase<TStartupModule> : thingmodelTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
