namespace Homely.Models
{
    public class User
    {
        public PersonalInformation PersonalInformation { get; set; }
    }

    public class PersonalInformation
    {
        public string FirstName { get; set; }
        public string FamilyName { get; set; }
        public string Email { get; set; }
    }
}
