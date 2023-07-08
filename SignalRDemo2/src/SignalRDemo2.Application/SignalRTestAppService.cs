using Microsoft.Extensions.Logging;
using SignalRDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Uow;

namespace SignalRDemo2
{
    public class SignalRTestAppService : ApplicationService, ISignalRTestAppService
    {
        private readonly ISignalRTestRepository _signalRTestRepository;
        public SignalRTestAppService(ISignalRTestRepository signalRTestRepository)
        {
            _signalRTestRepository = signalRTestRepository;
        }

        //[UnitOfWork(true)]
        //public async Task<SignalRTestDto> GetOrCreateAsync(string targetUserName)
        //{
        //    var result = await _signalRTestRepository.FindAsync(s => s.Name == targetUserName);
        //    Logger.LogDebug("CurrentUnitOfWork.Id:{0}", CurrentUnitOfWork.Id);
        //    if (result == null)
        //    {
        //        result = new SignalRTest(targetUserName);
        //        await _signalRTestRepository.InsertAsync(result, true);
        //        await CurrentUnitOfWork.CompleteAsync();
        //    }
        //    return ObjectMapper.Map<SignalRTest, SignalRTestDto>(result);
        //}

        public async Task<SignalRTestDto> GetOrCreateAsync(string targetUserName)
        {
            var result = await _signalRTestRepository.FindAsync(s => s.Name == targetUserName);
            using(var uow = UnitOfWorkManager.Begin())
            {
                Logger.LogDebug("CurrentUnitOfWork.Id:{0}", CurrentUnitOfWork.Id);
                if (result == null)
                {
                    result = new SignalRTest(targetUserName);
                    await _signalRTestRepository.InsertAsync(result, true);
                    await CurrentUnitOfWork.CompleteAsync();
                }
            }
            return ObjectMapper.Map<SignalRTest, SignalRTestDto>(result);
        }
    }
}
