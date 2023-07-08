using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using SignalRDemo2;
using Volo.Abp.AspNetCore.SignalR;
using Volo.Abp.Identity;
using Volo.Abp.Users;

namespace SignalRDemo.Web
{
    [Authorize]
    public class ChatHub : AbpHub
    {
        private readonly IIdentityUserRepository _identityUserRepository;
        private readonly ISignalRTestAppService _signalRTestAppService;
        private readonly ILookupNormalizer _lookupNormalizer;

        public ChatHub(IIdentityUserRepository identityUserRepository
            , ILookupNormalizer lookupNormalizer
            , ISignalRTestAppService signalRTestAppService
            )
        {
            _identityUserRepository = identityUserRepository;
            _lookupNormalizer = lookupNormalizer;
            _signalRTestAppService = signalRTestAppService;
        }

        public async Task SendMessage(string targetUserName, string message)
        {
            var targetUser = await _signalRTestAppService.GetOrCreateAsync(targetUserName);

            message = $"Id={targetUser.Id},Name={targetUser.Name}: {message}";

            await Clients
                .User(CurrentUser.GetId().ToString())
                .SendAsync("ReceiveMessage", message);
        }
    }
}
