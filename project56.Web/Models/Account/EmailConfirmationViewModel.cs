using System.ComponentModel.DataAnnotations;

namespace project56.Web.Models.Account
{
    public class EmailConfirmationViewModel
    {
        /// <summary>
        /// Encrypted tenant id.
        /// </summary>
        public string TenantId { get; set; }

        /// <summary>
        /// Encrypted user id.
        /// </summary>
        [Required]
        public string UserId { get; set; }

        [Required]
        public string ConfirmationCode { get; set; }
    }
}