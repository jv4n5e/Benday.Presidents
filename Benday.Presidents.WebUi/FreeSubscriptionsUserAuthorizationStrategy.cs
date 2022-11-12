using Benday.Presidents.WebUi.Security;

namespace Benday.Presidents.WebUi
{
    public class FreeSubscriptionsUserAuthorizationStrategy : IUserAuthorizationStrategy
    {
        public FreeSubscriptionsUserAuthorizationStrategy()
        {
            IsAuthorizedForImages = true;
            IsAuthorizedForSearch = true;
        }
        
        public bool IsAuthorizedForSearch { get; private set; }
        public bool IsAuthorizedForImages { get; private set; }
    }
}