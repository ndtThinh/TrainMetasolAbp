using System;
using System.Collections.Generic;
using System.Text;
using TrainMetasolAbp.Localization;
using Volo.Abp.Application.Services;

namespace TrainMetasolAbp.Admin;

/* Inherit your application services from this class.
 */
public abstract class TrainMetasolAbpAdminAppService : ApplicationService
{
    protected TrainMetasolAbpAdminAppService()
    {
        LocalizationResource = typeof(TrainMetasolAbpResource);
    }
}
