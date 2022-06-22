namespace Homely.Models
{
    public interface IUserRepository
    {
        public List<User> GetUsers();
        public User GetUser(Guid id);
    }
}
