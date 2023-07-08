﻿using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace SignalRDemo2;

public class SignalRDemo2WebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<SignalRDemo2WebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
