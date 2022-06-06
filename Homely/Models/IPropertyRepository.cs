namespace Homely.Models
{
    public interface IPropertyRepository
    {
        public List<Property> GetProperties();
        public Property GetProperty(Guid id);
    }
}