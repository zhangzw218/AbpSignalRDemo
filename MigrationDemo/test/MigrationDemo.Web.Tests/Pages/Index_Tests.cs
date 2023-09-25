using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace MigrationDemo.Pages
{
    public class Index_Tests : MigrationDemoWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
