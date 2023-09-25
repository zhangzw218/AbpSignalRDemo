using System;
using System.Collections.Generic;
using System.Text;
using MigrationDemo.Localization;
using Volo.Abp.Application.Services;

namespace MigrationDemo
{
    /* Inherit your application services from this class.
     */
    public abstract class MigrationDemoAppService : ApplicationService
    {
        protected MigrationDemoAppService()
        {
            LocalizationResource = typeof(MigrationDemoResource);
        }
    }
}
