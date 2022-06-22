namespace Homely.Models
{
    public interface IUserAccountRepository
    {
        public List<UserAccount> GetUserAccounts();
        public UserAccount GetUserAccount(Guid id);
    }
}
