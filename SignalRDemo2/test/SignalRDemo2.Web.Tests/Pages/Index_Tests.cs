﻿using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace SignalRDemo2.Pages;

public class Index_Tests : SignalRDemo2WebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
