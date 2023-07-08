using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using Volo.Abp.AspNetCore.SignalR;
using Volo.Abp.Identity;
using Volo.Abp.Users;

namespace SignalRDemo.Web
{
    [Authorize]
    public class ChatHub : AbpHub
    {
        private readonly IIdentityUserRepository _identityUserRepository;
        private readonly ISignalRTestRepository _signalRTestRepository;
        private readonly ILookupNormalizer _lookupNormalizer;

        public ChatHub(IIdentityUserRepository identityUserRepository
            , ILookupNormalizer lookupNormalizer
            , ISignalRTestRepository signalRTestRepository
            )
        {
            _identityUserRepository = identityUserRepository;
            _lookupNormalizer = lookupNormalizer;
            _signalRTestRepository = signalRTestRepository;
        }

        public async Task SendMessage(string targetUserName, string message)
        {
            var targetUser = await _signalRTestRepository.FindAsync(s => s.Name == targetUserName);
            if (targetUser == null)
            {
                targetUser = new SignalRTest(targetUserName);
                await _signalRTestRepository.InsertAsync(targetUser, true);
            }

            message = $"Id={targetUser.Id},Name={targetUser.Name}: {message}";

            await Clients
                .User(CurrentUser.GetId().ToString())
                .SendAsync("ReceiveMessage", message);
        }
    }
}
