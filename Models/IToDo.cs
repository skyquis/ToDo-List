namespace ToDo_List.Models
{
    public interface IToDo
    {
        Category Category { get; set; }
        string CategoryId { get; set; }
        string Description { get; set; }
        DateTime? DueDate { get; set; }
        int Id { get; set; }
        bool Overdue { get; }
        Status Status { get; set; }
        string StatusId { get; set; }
    }
}