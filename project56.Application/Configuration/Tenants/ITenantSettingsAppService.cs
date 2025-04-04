﻿using System.Threading.Tasks;
using Abp.Application.Services;
using project56.Configuration.Tenants.Dto;

namespace project56.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}
