using System;
using System.Collections.Generic;
using System.Text;
using TrainMetasolAbp.Localization;
using Volo.Abp.Application.Services;

namespace TrainMetasolAbp;

/* Inherit your application services from this class.
 */
public abstract class TrainMetasolAbpAppService : ApplicationService
{
    protected TrainMetasolAbpAppService()
    {
        LocalizationResource = typeof(TrainMetasolAbpResource);
    }
}
