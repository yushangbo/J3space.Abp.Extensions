﻿using J3space.Abp.IdentityServer;
using J3space.Abp.SettingManagement;
using Volo.Abp.Account;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;

namespace J3space.Sample
{
    [DependsOn(
        typeof(AbpAccountHttpApiClientModule),
        typeof(AbpFeatureManagementHttpApiClientModule),
        typeof(AbpIdentityHttpApiClientModule),
        typeof(AbpIdentityServerHttpApiClientModule),
        typeof(AbpPermissionManagementHttpApiClientModule),
        typeof(AbpSettingManagementHttpApiClientModule),
        typeof(SampleApplicationContractsModule)
    )]
    public class SampleHttpApiClientModule : AbpModule
    {
    }
}