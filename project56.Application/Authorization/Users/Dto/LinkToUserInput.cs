using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;

namespace project56.Authorization.Users.Dto
{
    public class LinkToUserInput 
    {
        public string TenancyName { get; set; }

        [Required]
        public string UsernameOrEmailAddress { get; set; }

        [Required]
        public string Password { get; set; }
    }
}