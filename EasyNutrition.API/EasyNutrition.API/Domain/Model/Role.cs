namespace EasyNutrition.API.Domain.Model
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IList<User> Users { get; set; } = new List<User>();

    }
}
