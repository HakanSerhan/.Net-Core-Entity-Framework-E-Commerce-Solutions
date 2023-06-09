using VirtoCommerce.Platform.Core.Events;

namespace VirtoCommerce.Platform.Core.Security.Events
{
    public class UserResetPasswordEvent : DomainEvent
    {
        public UserResetPasswordEvent(string userId, string customPasswordHash)
        {
            UserId = userId;
            CustomPasswordHash = customPasswordHash;
        }

        public string UserId { get; set; }

        /// <summary>
        /// Password hash for external hash storage. This provided as workaround until password hash storage would implemented
        /// </summary>         
        public string CustomPasswordHash { get; set; }
    }
}
