﻿using Microsoft.EntityFrameworkCore;
using Senparc.Core.Models;
using Senparc.Ncf.Core.Models;
using Senparc.Ncf.Core.Models.DataBaseModel;
using System;

namespace Senparc.Service
{
    /// <summary>
    /// 当前 Entities 只为帮助 SenparcEntities 生成 Migration 信息而存在，没有特别的操作意义。
    /// </summary>
    public class BasePoolEntities : SenparcEntities
    {
        public BasePoolEntities(DbContextOptions/*<BasePoolEntities>*/ dbContextOptions, IServiceProvider serviceProvider) : base(dbContextOptions, serviceProvider)
        {
        }

        #region 系统表（无特殊情况不要修改）

        /// <summary>
        /// 系统设置
        /// </summary>
        public DbSet<SystemConfig> SystemConfigs { get; set; }


        /// <summary>
        /// 系统角色
        /// </summary>
        public DbSet<SysRole> SysRoles { get; set; }

        /// <summary>
        /// 角色菜单表
        /// </summary>
        public DbSet<SysPermission> SysPermission { get; set; }

        /// <summary>
        /// 角色人员表
        /// </summary>
        public DbSet<SysRoleAdminUserInfo> SysRoleAdminUserInfos { get; set; }

        /// <summary>
        /// 扩展模块
        /// </summary>
        public DbSet<XncfModule> XncfModules { get; set; }

        #endregion
    }
}
