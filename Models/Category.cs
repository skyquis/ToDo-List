namespace ToDo_List.Models
{
    public class Category : ICategory
    {
        public string CategoryId { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;

    }
}
