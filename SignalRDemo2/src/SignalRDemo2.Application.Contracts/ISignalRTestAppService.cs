using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace SignalRDemo2
{
    public interface ISignalRTestAppService : IApplicationService
    {
        Task<SignalRTestDto> GetOrCreateAsync(string targetUserName);
    }
}
