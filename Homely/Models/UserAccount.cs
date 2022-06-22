namespace Homely.Models
{
    public class UserAccount
    {
        public Guid? Id { get; set; }
        public Roles? Role { get; set; }
        public DateTime? Created { get; set; }
        public PersonalInformation? PersonalInformation { get; set; }
        public List<Application>? Applications { get; set; }
    }

    public class PersonalInformation
    {
        public string? FirstName { get; set; }
        public string? Surname { get; set; }
        public string? Email { get; set; }
        public string? ProfilePicture { get; set; }
    }

    public class Application
    {
        public Guid? PropertyId { get; set; }
        public DateTime? Created { get; set; }
    }

    public enum Roles
    {
        User, 
        Admin
    }
}
