using Abp;
using Abp.Application.Services.Dto;

namespace project56.Authorization.Users.Dto
{
    public class UnlinkUserInput
    {
        public int? TenantId { get; set; }

        public long UserId { get; set; }

        public UserIdentifier ToUserIdentifier()
        {
            return new UserIdentifier(TenantId, UserId);
        }
    }
}