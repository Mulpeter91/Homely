namespace Homely.Models
{
    public class UserAccount
    {
        public Guid Id { get; set; }
        public Roles? Role { get; set; }
        public DateTime? Created { get; set; }
        public PersonalInformation? PersonalInformation { get; set; }
        public List<UserApplication>? UserApplications { get; set; }
    }

    public class PersonalInformation
    {
        public string? FirstName { get; set; }
        public string? Surname { get; set; }
        public string? Email { get; set; }
        public string? ProfilePicture { get; set; }
        public string? DefaultBio { get; set; }
        public string? LinkedInUrl { get; set; }
        public string? InstagramUrl { get; set; }
    }

    public class UserApplication
    {
        public Guid? Id { get; set; }
        public Guid? PropertyId { get; set; }
        public DateTime? Submitted { get; set; }
        public UserApplicationStatus Status { get; set; }
        public string SubmittedBio { get; set; }
    }

    public enum Roles
    {
        User,
        Admin
    }

    public enum UserApplicationStatus
    {
        Draft,
        Active,
        Inactive
    }
}
