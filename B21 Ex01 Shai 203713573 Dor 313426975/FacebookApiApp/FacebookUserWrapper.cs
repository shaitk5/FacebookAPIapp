using FacebookWrapper.ObjectModel;

namespace FacebookApiApp
{
    public class FacebookUserWrapper
    {
        public User UserWrapper
        {
            get;
            set;
        }

        public int Counter
        {
            get;
            set;
        }

        public FacebookUserWrapper(User i_User)
        {
            UserWrapper = i_User;
            Counter = 0;
        }
    }
}
