using System;
using Volo.Abp.Application.Dtos;

namespace SignalRDemo2
{
    public class SignalRTestDto:EntityDto<Guid>
    {
        public string? Name { get; set; }
    }
}