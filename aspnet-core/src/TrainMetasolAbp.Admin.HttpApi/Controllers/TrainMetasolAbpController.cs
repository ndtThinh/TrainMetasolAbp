using TrainMetasolAbp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace TrainMetasolAbp.Admin.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class TrainMetasolAbpController : AbpControllerBase
{
    protected TrainMetasolAbpController()
    {
        LocalizationResource = typeof(TrainMetasolAbpResource);
    }
}
