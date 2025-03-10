﻿using System.ComponentModel.DataAnnotations;

namespace project56.Configuration.Host.Dto
{
    public class HostSettingsEditDto
    {
        [Required]
        public GeneralSettingsEditDto General { get; set; }

        [Required]
        public HostUserManagementSettingsEditDto UserManagement { get; set; }

        [Required]
        public EmailSettingsEditDto Email { get; set; }

        [Required]
        public TenantManagementSettingsEditDto TenantManagement { get; set; }

        [Required]
        public SecuritySettingsEditDto Security { get; set; }
        
    }
}